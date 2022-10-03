using Core.Entities;
using ExamOnline_HK2_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnline_HK2_2021.ViewModels
{
    public class ModelView
    {
        public IEnumerable<Examination> Examinations { get; set; }
        public Examination examination { get; set; }

        public IEnumerable<Examinee> Examinees { get; set; }
        public Examinee examinee { get; set; }

        public IEnumerable<Level> Levels { get; set; }
        public Level level { get; set; }

        public IEnumerable<Result> Results { get; set; }
        public Result result { get; set; }

        public IEnumerable<Room> Rooms { get; set; }
        public Room room { get; set; }

        public SearchRoomModel SearchRoomModel { get; set; }
    }
}
