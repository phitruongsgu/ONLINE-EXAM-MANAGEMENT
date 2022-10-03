using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnline_HK2_2021.Models
{
    public class SearchRoomModel
    {
        [Required(ErrorMessage = "Vui lòng nhập họ tên của bạn!")]
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại!")]
        public string PhoneNumber { get; set; }
    }
}
