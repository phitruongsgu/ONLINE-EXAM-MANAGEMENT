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
    public class LevelRepository : ILevelRepository
    {
        private readonly EFContext context;

        public LevelRepository(EFContext context)
        {
            this.context = context;
        }

        void ILevelRepository.editLevel(Level level)
        {
            context.Levels.Update(level);
            context.SaveChanges();
        }

        Level ILevelRepository.FindByID(int id)
        {
            return context.Levels.Find(id);
        }

        IEnumerable<Level> ILevelRepository.Levels()
        {
            return context.Levels.ToList();
        }
    }
}
