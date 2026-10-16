using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDeal_Library
{
    public class Announcment
    {
        public string AnnouncementID { get; set; }
        public string Title { get; set; }
        public string MessageText { get; set; }
        public string PublishDate { get; set; }
        public bool IsActive { get; set; }
        public string TargetRole { get; set; }

    }
}
