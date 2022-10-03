using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Examinee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoId { get; set; }
        public string ExamineeId { get; set; }
        public string FullName { get; set; }
        public string DoB { get; set; }
        public string CardId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ExaminationId { get; set; }
        public string RoomName { get; set; }
        public string CodeId { get; set; }
        public string DateSign { get; set; }
        public string Gender { get; set; }
    }
}
