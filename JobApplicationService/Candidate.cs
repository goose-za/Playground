using System.Runtime.Serialization;

namespace JobApplicationService
{
    /// <summary>
    /// WCF services can also share data among the service and clients, 
    /// using parameters and data returned from called functions. A DataContract 
    /// is required in order for data to be communicated back and forth from service 
    /// to host. A DataContract defines the data structure to be used and is represented 
    /// as nothing more than a class defining an object.
    /// </summary>
    [DataContract]
    public class Candidate
    {
        [DataMember]
        public int CandidateId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public string SSN { get; set; }
    }
}