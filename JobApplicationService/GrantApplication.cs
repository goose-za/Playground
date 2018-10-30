using System.Runtime.Serialization;

namespace JobApplicationService
{
    [DataContract]
    public class GrantApplication
    {
        [DataMember]
        public string GrantTypeId { get; set; }

        [DataMember]
        public Grantee ApplyingGrantee { get; set; }

        [DataMember]
        public string OrgId { get; set; }
    }
}
