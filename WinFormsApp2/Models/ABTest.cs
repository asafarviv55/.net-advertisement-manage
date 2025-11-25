using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class ABTest
    {
        public int ABTestID { get; set; }
        public int CampaignID { get; set; }
        public string TestName { get; set; }
        public string TestDescription { get; set; }
        public int VariantAAdID { get; set; }
        public int VariantBAdID { get; set; }
        public decimal TrafficSplitPercentage { get; set; } // Percentage of traffic to Variant A (remainder goes to B)
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; } // Active, Completed, Paused
        public int? WinningVariantAdID { get; set; }
        public string WinningMetric { get; set; } // CTR, Conversions, Revenue, Engagement
        public string TestHypothesis { get; set; }
        public string TestResults { get; set; }
        public decimal StatisticalSignificance { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedOn { get; set; }

        public Campaign Campaign { get; set; }
    }
}
