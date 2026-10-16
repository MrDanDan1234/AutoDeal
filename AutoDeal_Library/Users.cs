using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDeal_Library
{
    internal class Users
    {
        public string SaleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Phone { get; set; }
        public string UserRole { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedAt { get; set; }

    }
}
