using System;
using JobApplication.Model.Contracts;

namespace JobApplication.Model
{
    public class GrantApplicationService : IGrantApplicationService
    {
        public void ApplyForGrant(GrantApplication application)
        {
            throw new NotImplementedException();
        }

        public bool AwardGrant(GrantApplication application)
        {
            throw new NotImplementedException();
        }

        public bool EmailGranteeFeedBack(GranteeFeedback feedback)
        {
            throw new NotImplementedException();
        }

        public bool PerformRiskAssessment(RiskAssessment GranteeBackground)
        {
            throw new NotImplementedException();
        }

        public bool ReviewApplication(Officer officer, Grantee grantee)
        {
            throw new NotImplementedException();
        }
    }
}
