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
    public class ExaminationRepository : IExaminationRepository
    {
        private readonly EFContext context;
        public ExaminationRepository(EFContext context)
        {
            this.context = context;
        }
        public IEnumerable<Examination> Examinations()
        {
            return context.Examinations.ToList();
        }

        public Examination FindByID(int id)
        {
            return context.Examinations.Find(id);
        }
    }
}
