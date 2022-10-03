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
    public class ExamineeRepository : IExamineeRepository
    {
        private readonly EFContext context;
        public ExamineeRepository(EFContext context)
        {
            this.context = context;
        }
        public void createExaminee(Examinee Examinee)
        {
            context.Examinees.Add(Examinee);
            context.SaveChanges();
        }

        public void editExaminee(Examinee Examinee)
        {
            context.Examinees.Update(Examinee);
            context.SaveChanges();
        }

        public IEnumerable<Examinee> Examinees()
        {
            return context.Examinees.ToList();
        }

        public Examinee FindByID(int id)
        {
            return context.Examinees.Find(id);
        }

        public void removeExaminee(int id)
        {
            context.Examinees.Remove(context.Examinees.Find(id));
            context.SaveChanges();
        }
    }
}
