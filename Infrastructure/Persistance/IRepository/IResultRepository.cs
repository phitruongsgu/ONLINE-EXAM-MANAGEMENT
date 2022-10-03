using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.IRepository
{
    public interface IResultRepository
    {
        Result FindByID(int id);
        IEnumerable<Result> Results();
    }
}
