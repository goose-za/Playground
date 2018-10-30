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
    public class JobApplicationStatus
    {
        [DataMember]
        public Guid JobApplicationId { get; set; }

        [DataMember]
        public JobApplication SubmittedApplication { get; set; }

        [DataMember]
        public bool PassedInterview { get; set; }

        [DataMember]
        public bool PassedBackgroundCheck { get; set; }

        [DataMember]
        public JobPosting JobAppliedTo { get; set; }
    }
}
