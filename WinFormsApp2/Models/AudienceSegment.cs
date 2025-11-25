using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class AudienceSegment
    {
        public int AudienceSegmentID { get; set; }
        public int CustomerID { get; set; }
        public string SegmentName { get; set; }
        public string SegmentDescription { get; set; }
        public string SegmentType { get; set; } // Behavioral, Demographic, Geographic, Psychographic, Custom
        public string SegmentCriteria { get; set; } // JSON or serialized criteria
        public int EstimatedSize { get; set; }
        public string AgeRange { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public string Interests { get; set; }
        public string PurchaseHistory { get; set; }
        public string EngagementLevel { get; set; } // High, Medium, Low
        public bool IsActive { get; set; }
        public DateTime LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedOn { get; set; }

        public Customer Customer { get; set; }
    }
}
