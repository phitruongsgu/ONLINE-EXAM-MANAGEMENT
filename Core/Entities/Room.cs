using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoId { get; set; }

        public string RoomName { get; set; }
        public string Description { get; set; }
        public int? Total { get; set; }
        public string DateExam { get; set; }
        public string ExaminationId { get; set; }
    }
}
