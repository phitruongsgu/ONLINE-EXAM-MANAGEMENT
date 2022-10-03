using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Result
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoId { get; set; }
        public string ResultId { get; set; }
        public string ExamineeId { get; set; }
        public double? ListenGrade { get; set; }
        public double? SpeakGrade { get; set; }
        public double? ReadGrade { get; set; }
        public double? WriteGrade { get; set; }
    }
}
