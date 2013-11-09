using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyCarpetsService.Repository.Context
{
    public class MyCarpetsContext : DbContext, IMyCarpetsContext
    {
        static MyCarpetsContext()
        {
            Database.SetInitializer<MyCarpetsContext>(null);
        }

        public MyCarpetsContext()
            : base("Name=MyCarpetsAtHomeEntities")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public override int SaveChanges()
        {
            //this.ApplyStateChanges();
            return base.SaveChanges();
        }
    }
}
