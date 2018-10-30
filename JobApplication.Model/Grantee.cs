using System.Runtime.Serialization;

namespace JobApplication.Model
{
    [DataContract]
    public class Grantee
    {
        [DataMember]
        public long GranteeId { get; set; }

        [DataMember]
        public string OrgName { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }
    }
}
