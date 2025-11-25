using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class AdPlacement
    {
        public int AdPlacementID { get; set; }
        public int AdID { get; set; }
        public string PlacementName { get; set; }
        public string PlacementType { get; set; } // Website Banner, Social Media Feed, Search Results, Video Pre-roll, Mobile App, Email
        public string Platform { get; set; } // Facebook, Google, Instagram, LinkedIn, Twitter, Website, Mobile App
        public string Position { get; set; } // Top, Sidebar, Bottom, In-Feed, Stories, Overlay
        public string Size { get; set; } // 300x250, 728x90, 1200x628, Full Screen, etc.
        public int Priority { get; set; }
        public decimal BidAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public string Frequency { get; set; } // Daily, Hourly, Per Session
        public int FrequencyCap { get; set; } // Maximum times to show ad per user
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedOn { get; set; }

        public Advertisement Advertisement { get; set; }
    }
}
