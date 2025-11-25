using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class BudgetAllocation
    {
        public int BudgetAllocationID { get; set; }
        public int CampaignID { get; set; }
        public decimal DailyBudget { get; set; }
        public decimal MonthlyBudget { get; set; }
        public decimal RemainingBudget { get; set; }
        public string BiddingStrategy { get; set; } // CPC (Cost Per Click), CPM (Cost Per Mille), CPA (Cost Per Acquisition), Manual
        public decimal MaxCPC { get; set; }
        public decimal MaxCPM { get; set; }
        public decimal MaxCPA { get; set; }
        public string BudgetPacing { get; set; } // Standard, Accelerated
        public DateTime AllocationDate { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedOn { get; set; }

        public Campaign Campaign { get; set; }
    }
}
