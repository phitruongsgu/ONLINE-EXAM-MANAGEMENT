using Core.Entities;
using Infrastructure.Persistance.DBcontext;
using Infrastructure.Persistance.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamOnline_HK2_2021.Models;
using ExamOnline_HK2_2021.ViewModels;

namespace ExamOnline_HK2_2021.Controllers
{
    public class SearchController : Controller
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IExamineeRepository _examineeRepository;
        private readonly IExaminationRepository _examinationRepository;

        public SearchController(IRoomRepository roomRepository,IExamineeRepository examineeRepository, IExaminationRepository examinationRepository)
        {
            _roomRepository = roomRepository;
            _examineeRepository = examineeRepository;
            _examinationRepository = examinationRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchRoom(SearchRoomModel search)
        {
            IEnumerable<Room> rooms = _roomRepository.Rooms();
            IEnumerable<Examinee> examinee = _examineeRepository.Examinees();
            IEnumerable<Examination> examination = _examinationRepository.Examinations();
            var svRoom = examinee.Where(x => x.Phone == search.PhoneNumber && x.FullName == (search.FullName)).Select(x => x.RoomName).FirstOrDefault();
            ModelView mv = null;
            Room roomIndex = null;
            foreach(var i in rooms)
            {
                if (i.RoomName == svRoom) // nếu pt trong cột RoomName của bảng Rooms = pt trong cột RoomName của bảng Examinee mà mình tìm dc select ở trên
                {
                    roomIndex = i;
                    break;
                }
            }
            if (svRoom != null)
            {
                mv = new ModelView
                {
                    room = roomIndex, // roomIndex là hàng infor chi tiết theo RoomName, gán vào entity Room
                    Examinees = _examineeRepository.Examinees()
                };
            }

            return View(mv);
        }


        public IActionResult SearchListExam()
        {
            IEnumerable<Room> rooms = _roomRepository.Rooms();
            IEnumerable<Examinee> examinees = _examineeRepository.Examinees();
            IEnumerable<Examination> examinations = _examinationRepository.Examinations();
            List<SelectListItem> Rs = new List<SelectListItem>();
            foreach (var item in _roomRepository.Rooms())
            {
                Rs.Add(new SelectListItem { Text = item.RoomName, Value = item.RoomName });
            }
            List<SelectListItem> Exs = new List<SelectListItem>();
            foreach (var item in _examinationRepository.Examinations())
            {
                Exs.Add(new SelectListItem { Text = item.ExaminationId, Value = item.ExaminationId });
            }
            ViewBag.RoomName = Rs;
            ViewBag.ExaminationId = Exs;
            ModelView mv = new ModelView
            {
                Rooms = rooms,
                Examinations = examinations
            };
            return View(mv);
        }

        [HttpPost]
        public IActionResult SearchListExam(string RoomName,string ExaminationId)
        {
            IEnumerable<Room> rooms = _roomRepository.Rooms(); // 20
            IEnumerable<Examinee> examinees = _examineeRepository.Examinees(); // 15
            IEnumerable<Examination> examinations = _examinationRepository.Examinations(); //24

            var room1 = rooms.Where(x => x.RoomName == RoomName).FirstOrDefault();
            var exam = examinations.Where(x => x.ExaminationId == ExaminationId).FirstOrDefault();
            var ListExaminee = examinees.Where(x => x.ExaminationId == exam.ExaminationId && x.RoomName == room1.RoomName).ToList();

            ModelView mv = new ModelView
            {
                Rooms = rooms,
                Examinations = examinations,
                room = room1,
                Examinees = ListExaminee,
                examination = exam
            };
            return View(mv);
        }
    }
}
