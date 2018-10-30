using System.Runtime.Serialization;

namespace JobApplicationService
{
    [DataContract]
    public class Officer
    {
        [DataMember]
        public string OfficerId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }
    }
}
