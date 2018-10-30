using System.Runtime.Serialization;

namespace JobApplication.Model
{
    /// <summary>
    /// WCF services can also share data among the service and clients, 
    /// using parameters and data returned from called functions. A DataContract 
    /// is required in order for data to be communicated back and forth from service 
    /// to host. A DataContract defines the data structure to be used and is represented 
    /// as nothing more than a class defining an object.
    /// </summary>
    [DataContract]
    public class JobApplication
    {
        [DataMember]
        public JobPosting JobPostingId { get; set; }

        [DataMember]
        public Candidate ApplyingCandidate { get; set; }
    }
}