using Core.Entities;
using ExamOnline_HK2_2021.Models;
using ExamOnline_HK2_2021.ViewModels;
using Infrastructure.Persistance.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExamOnline_HK2_2021.Controllers
{
    public class ExamineeController : Controller
    {
        private readonly IExamineeRepository _examineeRepository;
        private readonly IExaminationRepository _examinationRepository;
        private readonly IRoomRepository _roomRepository;

        public ExamineeController(IExamineeRepository examineeRepository, IExaminationRepository examinationRepository, IRoomRepository roomRepository)
        {
            _examineeRepository = examineeRepository;
            _examinationRepository = examinationRepository;
            _roomRepository = roomRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Examinee> examinees = _examineeRepository.Examinees();

            ModelView VM = new ModelView
            {
                Examinees = examinees.OrderByDescending(s => s.AutoId)
            };
            return View(VM);
        }

        public IActionResult Register()
        {
            List<SelectListItem> Examination = new List<SelectListItem>();
            foreach (var item in _examinationRepository.Examinations())
            {
                Examination.Add(new SelectListItem { Text = item.ExaminationId, Value = item.ExaminationId });
            }
            ViewBag.Examination = Examination;
            return View(new ExamineeModel());
        }

        [HttpPost]
        public IActionResult Register(ExamineeModel rm)
        {
            if (ModelState.IsValid)
            {
                var examinee = new Examinee();
                examinee.ExamineeId = Guid.NewGuid().ToString();
                examinee.FullName = rm.FullName;
                examinee.CardId = rm.CardId;
                examinee.Phone = rm.Phone;
                examinee.ExaminationId = rm.ExaminationId;
                examinee.DoB = rm.DoB;
                examinee.Gender = rm.Gender;
                _examineeRepository.createExaminee(examinee);
            }
            return RedirectToAction("Index", "Examinee");
        }

        public IActionResult Detail(int id)
        {
            Examinee ex = _examineeRepository.FindByID(id);
            ModelView m = new ModelView()
            {
                examinee = ex
            };
            return View(m);
        }

        public IActionResult Search()
        {
            IEnumerable<Room> room = _roomRepository.Rooms();

            ModelView VM = new ModelView
            {
                Rooms = room
            };
            return View(VM);
        }

        [HttpPost]
        public IActionResult Search(string search)
        {
            search = RemoveVietnameseTone(search);
            var ex = _examineeRepository.Examinees().Where(p => RemoveVietnameseTone((p.FullName.ToLower())).Contains(search.ToLower())).ToList();
            ModelView m = new ModelView()
            {
                Examinees = ex,
            };
            return View(m);
        }

        public static string RemoveVietnameseTone(string text)
        {
            string result = text.ToLower();
            result = Regex.Replace(result, "à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ|/g", "a");
            result = Regex.Replace(result, "è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ|/g", "e");
            result = Regex.Replace(result, "ì|í|ị|ỉ|ĩ|/g", "i");
            result = Regex.Replace(result, "ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ|/g", "o");
            result = Regex.Replace(result, "ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ|/g", "u");
            result = Regex.Replace(result, "ỳ|ý|ỵ|ỷ|ỹ|/g", "y");
            result = Regex.Replace(result, "đ", "d");
            return result;
        }
    }
}
