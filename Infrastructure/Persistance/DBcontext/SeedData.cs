using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.DBcontext
{
    public class SeedData
    {
        public static void createDataOnBuild(EFContext context)
        {
            //câu lệnh bên dưới dùng để ensure(tạo mới) data khi table chưa có data
            context.Database.EnsureCreated();

            // kiểm tra đã có dữ liệu sẵn trong table chưa, nếu chưa thì tạo mới, nếu có rồi thì những lần build sau không cần tạo thêm
            if (context.Examinations.Any()) return;
            context.Examinations.AddRange(new List<Examination>
            {
                new Examination
                {
                    ExaminationId = "A2-01",
                    Month = "1",
                    Description = "",
                    LevelName = "A2"
                },
                 new Examination
                {
                    ExaminationId = "A2-02",
                    Month = "2",
                    Description = "",
                    LevelName = "A2"
                }
            });

            if (context.Examinees.Any()) return;
            context.Examinees.AddRange(new List<Examinee>
            {
                new Examinee
                {
                    ExaminationId="XRCHPBB6ING8M2YJPH",
                    FullName="Trần Thị Thiên Tú",
                    DoB="12/09/1999",
                    CardId="012471856",
                    Email = "thientu@gmail.com",
                    Phone = "0784127569",
                    ExamineeId = "A2-01",
                    RoomName = "A2P01",
                    CodeId = "3117410111",
                    DateSign = "15/09/2021 1:55:29 AM",
                    Gender = "Nữ"
                },
                new Examinee
                {
                    ExaminationId="MNQMIEJTYLGNNLW25P",
                    FullName="Nguyễn Thị Mỹ Dung",
                    DoB="23/05/2000",
                    CardId="023112009",
                    Email = "mydung@gmail.com",
                    Phone = "0992928177",
                    ExamineeId = "A2-01",
                    RoomName = "A2P01",
                    CodeId = "3118410113",
                    DateSign = "15/09/2021 1:55:29 AM",
                    Gender = "Nữ"
                }
            });

            if (context.Levels.Any()) return;
            context.Levels.AddRange(new List<Level>
            {
                new Level
                {
                    LevelName="A2",
                    Description="Chứng chỉ tiếng anh trình độ A2",
                },
                new Level
                {
                    LevelName="B1",
                    Description="Chứng chỉ tiếng anh trình độ B1",
                }
            });

            if (context.Results.Any()) return;
            context.Results.AddRange(new List<Result>
            {
                new Result
                {
                    ResultId="4XUKG8UCLYAEMGBG2H",
                    ExamineeId="4GPVA0GMVEQ8R968YA",
                    ListenGrade = 8,
                    ReadGrade = 9,
                    SpeakGrade = 10,
                    WriteGrade = 7
                },
                new Result
                {
                    ResultId="XRCHPBB6IN2jauakkH",
                    ExamineeId="XRCHPBB6ING8M2YJPH",
                    ListenGrade = 6,
                    ReadGrade = 7,
                    SpeakGrade = 5,
                    WriteGrade = 6.5
                }
            });

            if (context.Rooms.Any()) return;
            context.Rooms.AddRange(new List<Room>
            {
                new Room
                {
                    RoomName="A2P01",
                    Description="Phòng thi A2P01",
                    Total = 10,
                    DateExam = "18/09/2021",
                    ExaminationId = "A2-01"
                },
                new Room
                {
                    RoomName="A2P016",
                    Description="Phòng thi A2P016",
                    Total = 10,
                    DateExam = "15/09/2021",
                    ExaminationId = "A2-01"
                }
            });

            context.SaveChanges();
        }
    }
}
