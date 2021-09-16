using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entity;
using DAL.Entity.User;
using System.Data.Entity;

namespace DAL.DataConnection
{
    public class DataContext IdentityDbContext<UserData> {    
        public DataContext(): base("DefaultConnection") {}

    }  
}
