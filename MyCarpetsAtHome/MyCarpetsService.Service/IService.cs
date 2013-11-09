using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using MyCarpetsService.Entities;
using System.Threading.Tasks;

namespace MyCarpetsService.Service
{

    [ServiceContract]
    public interface IService
    {
        #region Products

        [OperationContract]
        List<Product> ReturnAllProducts();

        [OperationContract]
        List<Product> ReturnAllCarpets();

        #endregion

        #region Lookups

        [OperationContract]
        List<Lookup> ReturnAllLookups();

        #endregion
    }
}

