using Core.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnline_HK2_2021.Models
{
    public class ExamineeModel
    {

        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        [Display(Name = "Họ tên")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập chứng minh nhân dân")]
        [Display(Name = "Chứng minh nhân dân")]
        public string CardId { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn khoá thi")]
        [Display(Name = "Khoá thi")]
        public string ExaminationId { get; set; }

        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Vui lòng nhập ngày sinh")]
        public string DoB { get; set; }

        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Vui lòng nhập giới tính")]
        public string Gender { get; set; }
    }
}
