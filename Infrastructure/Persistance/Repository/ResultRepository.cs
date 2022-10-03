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
    public class ResultRepository : IResultRepository
    {
        private readonly EFContext context;
        public ResultRepository(EFContext context)
        {
            this.context = context;
        }
        public Result FindByID(int id)
        {
            return context.Results.Find(id);
        }

        public IEnumerable<Result> Results()
        {
            return context.Results.ToList();
        }
    }
}
