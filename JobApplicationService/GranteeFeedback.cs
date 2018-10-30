using System.Runtime.Serialization;

namespace JobApplicationService
{
    [DataContract]
    public class GranteeFeedback
    {
        [DataMember]
        public Grantee ApplyingGrantee { get; set; }

        [DataMember]
        public string ApplicationFeedback { get; set; }
    }
}
