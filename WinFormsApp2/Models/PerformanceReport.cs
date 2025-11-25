using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class PerformanceReport
    {
        public int PerformanceReportID { get; set; }
        public int CampaignID { get; set; }
        public string ReportName { get; set; }
        public string ReportType { get; set; } // Daily, Weekly, Monthly, Quarterly, Custom
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long TotalImpressions { get; set; }
        public long TotalClicks { get; set; }
        public decimal AverageCTR { get; set; }
        public long TotalConversions { get; set; }
        public decimal AverageConversionRate { get; set; }
        public decimal TotalSpend { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal OverallROI { get; set; }
        public decimal AverageCPC { get; set; }
        public decimal AverageCPM { get; set; }
        public decimal AverageCPA { get; set; }
        public string TopPerformingAds { get; set; } // JSON list of top ads
        public string KeyInsights { get; set; }
        public string Recommendations { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedOn { get; set; }

        public Campaign Campaign { get; set; }
    }
}
