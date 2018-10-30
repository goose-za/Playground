using System.Runtime.Serialization;

namespace JobApplication.Model
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
