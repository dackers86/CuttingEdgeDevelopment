using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCarpetsService.Repository.UnitofWork;
using MyCarpetsService.Entities;

namespace MyCarpetsService.Service
{
    public class Service : IService
    {
        private readonly IUnitofWork _UnitofWork;

        public Service()
        {
            _UnitofWork = new UnitofWork();
        }

        public Service(IUnitofWork uow)
        {
            _UnitofWork = uow;
        }

        #region Products

        public List<Product> ReturnAllProducts()
        {
            return _UnitofWork.Repository<Product>().GetProducts();
        }

        #endregion

        #region Carpets

        public List<Product> ReturnAllCarpets()
        {
            return _UnitofWork.Repository<Product>().GetCarpets();
        }

        #endregion


        #region lookups

        public List<Lookup> ReturnAllLookups()
        {
            return _UnitofWork.Repository<Lookup>().ReturnAllLookups();
        }

        #endregion

    }
}
