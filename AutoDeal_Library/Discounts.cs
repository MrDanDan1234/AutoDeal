using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDeal_Library
{
    public class Discounts
    {
        public string DiscountID { get; set; }
        public string UserID { get; set; }
        public string CarID { get; set; }
        public string DiscountPercent { get; set; }

        public string StartDate { get; set; }

        public bool IsActive { get; set; }

        public string DiscountDescription { get; set; }
    }
}
