using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyCarpetsService.Repository.Context;
using MyCarpetsService.Entities;

namespace MyCarpetsService.Repository.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private MyCarpetsContext context;

        public Repository()
        {
            this.context = new MyCarpetsContext();
        }

        public Repository(MyCarpetsContext context)
        {
            this.context = context;
        }

        public List<Product> GetProducts()
        {
            return context.Set<Product>().Include(l => l.ColoursLookup)
                                         .Include(l => l.MaterialsLookup)
                                         .Include(l => l.StylesLookup)
                                         .Include(l => l.TypesLookup)
                                         .Include(l => l.Widths)
                                         .Select(p => p).ToList();
        }

        public List<Product> GetCarpets()
        {
            return context.Set<Product>().Include(l => l.ColoursLookup)
                                         .Include(l => l.MaterialsLookup)
                                         .Include(l => l.StylesLookup)
                                         .Include(l => l.TypesLookup)
                                         .Include(l => l.Widths)
                                         .Where(p => p.TypeId == 2).ToList();
        }


        public List<Lookup> ReturnAllLookups()
        {
            return context.Set<Lookup>().Select(l => l).ToList();
        }
    }
}
