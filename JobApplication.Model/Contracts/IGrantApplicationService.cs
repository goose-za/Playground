using System.ServiceModel;

namespace JobApplication.Model.Contracts
{
    [ServiceContract]
    public interface IGrantApplicationService
    {
        [OperationContract(IsOneWay=true)]
        void ApplyForGrant(GrantApplication application);
        [OperationContract]
        bool PerformRiskAssessment(RiskAssessment GranteeBackground);
        [OperationContract]
        bool EmailGranteeFeedBack(GranteeFeedback feedback);
        [OperationContract]
        bool ReviewApplication(Officer officer, Grantee grantee);
        [OperationContract]
        bool AwardGrant(GrantApplication application);


    }
}
