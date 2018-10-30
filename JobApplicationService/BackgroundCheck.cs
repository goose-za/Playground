using System;
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
    public class BackgroundCheck
    {
        [DataMember]
        public Candidate ApplyingCandidate { get; set; }

        [DataMember]
        public DateTime BackgroundCheckDate { get; set; }
    }
}