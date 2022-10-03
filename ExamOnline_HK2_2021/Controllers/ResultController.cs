using Core.Entities;
using ExamOnline_HK2_2021.ViewModels;
using Infrastructure.Persistance.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnline_HK2_2021.Controllers
{
    public class ResultController : Controller
    {
        private readonly IExamineeRepository _examineeRepository;
        private readonly IExaminationRepository _examinationRepository;
        private readonly IResultRepository _resultRepository;

        public ResultController(IExamineeRepository examineeRepository, IExaminationRepository examinationRepository, IResultRepository resultRepository)
        {
            _examineeRepository = examineeRepository;
            _examinationRepository = examinationRepository;
            _resultRepository = resultRepository;
        }
        public IActionResult Detail()
        {
            IEnumerable<Examination> examinations = _examinationRepository.Examinations();
            IEnumerable<Examinee> examinees = _examineeRepository.Examinees();
            IEnumerable<Result> results = _resultRepository.Results();
            ModelView VM = new ModelView
            {
                Examinees = examinees,
                Examinations = examinations,
                Results = results
            };
            return View(VM);
        }
    }
}
