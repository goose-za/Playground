using System.Collections.Generic;

namespace SBAdmin.Models
{
    public class PODashboardSummary
    {
        public List<GrantInfoSummary> GrantInfoSummary { get; set; }
        public GrantTotals GrantTotals { get; set; }
    }
}