using System.Runtime.Serialization;

namespace JobApplicationService
{
    [DataContract]
    public class Grantee
    {
        [DataMember]
        public string GranteeId { get; set; }

        [DataMember]
        public string OrgName { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }
    }
}
