using Core.Entities;
using ExamOnline_HK2_2021.Models;
using ExamOnline_HK2_2021.ViewModels;
using Infrastructure.Persistance.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnline_HK2_2021.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IExamineeRepository _examineeRepository;
        private readonly IExaminationRepository _examinationRepository;

        public HomeController(ILogger<HomeController> logger, IExamineeRepository examineeRepository, IExaminationRepository examinationRepository)
        {
            _examineeRepository = examineeRepository;
            _examinationRepository = examinationRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Examination> examinations = _examinationRepository.Examinations();
            IEnumerable<Examinee> examinees = _examineeRepository.Examinees();
            ModelView VM = new ModelView
            {
                Examinees = examinees,
                Examinations = examinations
            };
            return View(VM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
