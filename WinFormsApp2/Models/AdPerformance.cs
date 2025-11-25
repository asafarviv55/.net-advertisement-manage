using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class AdPerformance
    {
        public int AdPerformanceID { get; set; }
        public int AdID { get; set; }
        public DateTime RecordDate { get; set; }
        public long Impressions { get; set; }
        public long Clicks { get; set; }
        public decimal CTR { get; set; } // Click-Through Rate (Clicks/Impressions * 100)
        public long Conversions { get; set; }
        public decimal ConversionRate { get; set; } // Conversions/Clicks * 100
        public decimal CostPerClick { get; set; }
        public decimal CostPerImpression { get; set; }
        public decimal CostPerConversion { get; set; }
        public decimal TotalSpend { get; set; }
        public decimal Revenue { get; set; }
        public decimal ROI { get; set; } // Return on Investment
        public long UniqueReach { get; set; }
        public decimal EngagementRate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedOn { get; set; }

        public Advertisement Advertisement { get; set; }
    }
}
