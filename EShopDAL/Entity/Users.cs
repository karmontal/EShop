using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopDAL.Entity
{
    public class Users : IdentityUser {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
