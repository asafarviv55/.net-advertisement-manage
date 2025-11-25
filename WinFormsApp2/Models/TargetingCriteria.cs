using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class TargetingCriteria
    {
        public int TargetingCriteriaID { get; set; }
        public int CampaignID { get; set; }
        public string AgeRangeMin { get; set; }
        public string AgeRangeMax { get; set; }
        public string Gender { get; set; } // Male, Female, All
        public string Locations { get; set; } // Comma-separated list of cities/regions
        public string Interests { get; set; } // Comma-separated list of interests
        public string Languages { get; set; } // Comma-separated list of languages
        public string DeviceTypes { get; set; } // Desktop, Mobile, Tablet
        public string OperatingSystems { get; set; } // iOS, Android, Windows
        public string IncomeLevel { get; set; } // Low, Medium, High
        public string EducationLevel { get; set; }
        public string MaritalStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedOn { get; set; }

        public Campaign Campaign { get; set; }
    }
}
