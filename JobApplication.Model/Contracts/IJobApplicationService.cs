using System.ServiceModel;

namespace JobApplication.Model.Contracts
{
    /// <summary>
    /// <para>
    /// A contract for a service is implemented through an interface object. 
    /// An interface provides a contract that a class must agree to if the 
    /// class decides to implement the interface. 
    /// </para>
    /// <para>
    ///  ServiceContract indicates that the interface supports a WCF service 
    ///  and that the interface is the contract for how the service is set up. 
    /// </para>
    /// <para>
    /// OperationContract indicates each of the methods that will be used within 
    /// the service.
    /// </para>
    /// <para>
    ///  Other attribute information can be included for each of the operations 
    ///  for different results. For instance, if a method is not expected to return 
    ///  a result, then IsOneWay=true can be used to decorate the operation contract, 
    ///  indicating that there should not be a response returned back to the client.
    /// </para>
    /// </summary>
    [ServiceContract]
    public interface IJobApplicationService
    {
        [OperationContract(IsOneWay=true)]
        void ApplyForJob(JobApplication application);   

        [OperationContract]
        bool PerformBackgroundCheck(BackgroundCheck candidateBackground);

        [OperationContract]
        bool EmailCandidateFeedback(GranteeFeedback feedback);

        [OperationContract]
        bool InterviewCandidate(Manager manager, Candidate candidate);

        [OperationContract]
        bool HireEmployee(JobApplication application);
    }
}