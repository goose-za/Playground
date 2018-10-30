using System.Runtime.Serialization;

namespace JobApplication.Model
{
    [DataContract]
    public class GrantApplication
    {
        [DataMember]
        public int GrantTypeId { get; set; }

        [DataMember]
        public Grantee ApplyingGrantee { get; set; }

        [DataMember]
        public long OrgId { get; set; }
    }
}
