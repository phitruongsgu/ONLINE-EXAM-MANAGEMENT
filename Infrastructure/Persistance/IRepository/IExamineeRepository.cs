using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Infrastructure.Persistance.IRepository
{
    public interface IExamineeRepository
    {
        Examinee FindByID(int id);
        IEnumerable<Examinee> Examinees();
        void createExaminee(Examinee Examinee);
        void editExaminee(Examinee Examinee);
        void removeExaminee(int id);
    }
}
