using Core.Entities;
using Infrastructure.Persistance.DBcontext;
using Infrastructure.Persistance.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly EFContext context;
        public RoomRepository(EFContext context)
        {
            this.context = context;
        }
        public Room FindByID(int id)
        {
            return context.Rooms.Find(id);
        }

        public IEnumerable<Room> Rooms()
        {
            return context.Rooms.ToList();
        }
    }
}
