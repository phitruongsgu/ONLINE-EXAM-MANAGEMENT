using Core.Entities;
using Infrastructure.Persistance.DBcontext;
using Infrastructure.Persistance.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamOnline_HK2_2021.Models;
using ExamOnline_HK2_2021.ViewModels;

namespace ExamOnline_HK2_2021.Controllers
{
    public class StatisticalController : Controller
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IExamineeRepository _examineeRepository;
        private readonly IExaminationRepository _examinationRepository;
        private readonly ILevelRepository _levelRepository;

        public StatisticalController(IRoomRepository roomRepository, IExamineeRepository examineeRepository, IExaminationRepository examinationRepository, ILevelRepository levelRepository)
        {
            _levelRepository = levelRepository;
            _roomRepository = roomRepository;
            _examineeRepository = examineeRepository;
            _examinationRepository = examinationRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Level> levels = _levelRepository.Levels();
            IEnumerable<Examination> examinations = _examinationRepository.Examinations();
            ModelView vm = new ModelView
            {
                Levels = levels,
                Examinations = examinations
            };

            return View(vm);
        }

        public IActionResult Exam()
        {
            IEnumerable<Level> levels = _levelRepository.Levels();
            ModelView vm = new ModelView
            {
                Levels = levels
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Exam(string LevelName)
        {
            IEnumerable<Level> levels = _levelRepository.Levels();
            IEnumerable<Examination> examinations = _examinationRepository.Examinations();
            IEnumerable<Room> rooms = _roomRepository.Rooms();

            var exam = examinations.Where(x => x.LevelName == LevelName).ToList(); // tìm khoá thi trong bảng Examination với level truyền vào so vs cột LevelName trong Examination
            List<Room> statisticRoom = new List<Room>();
            foreach (var i in rooms)
            {
                foreach (var j in exam)
                {
                    if (i.ExaminationId == j.ExaminationId) // check xem id khoá thi trong Examination có trùng với id khoá thi trong Room hay k
                    {
                        statisticRoom.Add(i); // thêm vào List
                    }
                }
            }
            ModelView mv = new ModelView
            {
                Rooms = statisticRoom, // số lượng phòng thi 19
                Examinations = exam, // số lượng khoá thi 12
                Levels = levels
            };
            return View(mv);
        }

        public IActionResult ListExaminee()
        {
            IEnumerable<Examination> examinations = _examinationRepository.Examinations();
            IEnumerable<Level> levels = _levelRepository.Levels();
            ModelView mv = new ModelView
            {
                Levels = levels,
                Examinations = examinations
            };
            return View(mv);
        }

        [HttpPost]
        public IActionResult ListExaminee(string LevelName, string Examination)
        {
            IEnumerable<Examination> examinations = _examinationRepository.Examinations();
            IEnumerable<Room> rooms = _roomRepository.Rooms();
            IEnumerable<Examinee> examinees = _examineeRepository.Examinees();
            IEnumerable<Level> levels = _levelRepository.Levels();

            List<Examination> exam = new List<Examination>();
            List<Examinee> examines = new List<Examinee>();
            List<Examination> examfilter = new List<Examination>();
            exam = examinations.Where(x => x.LevelName == LevelName).ToList(); // tìm list khoá thi theo level xem level trong Examination có bằng với param level truyền vào hay k A2
            examfilter = exam.Where(x => x.ExaminationId == Examination).ToList(); // lọc theo khoá thi mình truyền vào A2-01
            foreach (var i in examinees)
            {
                foreach (var j in examfilter)
                {
                    if (i.ExaminationId == j.ExaminationId)
                    {
                        examines.Add(i);
                    }

                }
            }
            ModelView mv = new ModelView
            {
                Examinees = examines,
                Examinations = examinations,
                Levels = levels
            };
            return View(mv);
        }
    }
}
