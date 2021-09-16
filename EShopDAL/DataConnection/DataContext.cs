using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using EShopDAL.Entity;
using System.Data.Entity;

namespace EShopDAL.DataConnection
{
    public class DataContext :IdentityDbContext<Users>{    
        public DataContext() : base("EShopModels") {}

    }  
}
