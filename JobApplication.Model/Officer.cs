using System.Runtime.Serialization;

namespace JobApplication.Model
{
    [DataContract]
    public class Officer
    {
        [DataMember]
        public int OfficerId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }
    }
}
