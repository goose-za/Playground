using System;
using System.Runtime.Serialization;

namespace JobApplicationService
{
    [DataContract]
    public class GrantApplicationStatus
    {
        [DataMember]
        public Guid GrantApplicationId { get; set; }

        [DataMember]
        public GrantApplication SubmittedApplication { get; set; }

        [DataMember]
        public bool PassedReview { get; set; }

        [DataMember]
        public bool PassedRiskAssessment { get; set; }

        [DataMember]
        public string GrantTypeAppliedFor { get; set; }
    }
}
