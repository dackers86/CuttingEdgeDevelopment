using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCarpetsService.Repository.Repository;

namespace MyCarpetsService.Repository.UnitofWork
{
    public interface IUnitofWork
    {
        void Save();
        IRepository<T> Repository<T>() where T : class;
    }
}
