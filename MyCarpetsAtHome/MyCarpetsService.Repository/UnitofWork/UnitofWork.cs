using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MyCarpetsService.Repository.Context;
using MyCarpetsService.Repository.Repository;

namespace MyCarpetsService.Repository.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {
        private readonly IMyCarpetsContext _context;

        private Hashtable _repositories;

        public UnitofWork(MyCarpetsContext context)
        {
            _context = context;
        }

        public UnitofWork()
        {
            _context = new MyCarpetsContext();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public IRepository<T> Repository<T>() where T : class
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Repository<>);

                var repositoryInstance =
                    Activator.CreateInstance(repositoryType
                            .MakeGenericType(typeof(T)), _context);

                _repositories.Add(type, repositoryInstance);
            }

            return (IRepository<T>)_repositories[type];
        }
    }
}
