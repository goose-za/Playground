using System;
using System.Runtime.Serialization;

namespace JobApplicationService
{
    [DataContract]
    public class RiskAssessment
    {
        [DataMember]
        public Grantee ApplyingGrantee { get; set; }

        [DataMember]
        public DateTime RiskAssessmentDate { get; set; }
    }
}
