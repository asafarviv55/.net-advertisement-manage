using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class Campaign
    {
        public int CampaignID { get; set; }
        public int CustomerID { get; set; }
        public string CampaignName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } // Active, Paused, Scheduled, Completed, Cancelled
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalBudget { get; set; }
        public decimal SpentBudget { get; set; }
        public string Objective { get; set; } // Brand Awareness, Lead Generation, Conversions, Traffic
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedOn { get; set; }

        public Customer Customer { get; set; }
        public ICollection<Advertisement> Advertisements { get; set; }
    }
}
