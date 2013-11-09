using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCarpetsService.Entities;

namespace MyCarpetsService.Repository.Repository
{
        public interface IRepository<TEntity> where TEntity : class
        {
            List<Product> GetProducts();

            List<Product> GetCarpets();

            List<Lookup> ReturnAllLookups();
        }
}
