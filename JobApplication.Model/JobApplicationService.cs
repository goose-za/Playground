using JobApplication.Model.Contracts;
using System;

namespace JobApplication.Model
{
    public class JobApplicationService : IJobApplicationService
    {
        public void ApplyForJob(JobApplication application) 
        {
            throw new NotImplementedException();
        }

        public bool EmailCandidateFeedback(GranteeFeedback feedback)
        {
            throw new NotImplementedException();
        }

        public bool HireEmployee(JobApplication application)
        {
            throw new NotImplementedException();
        }

        public bool HireEmployee(JobApplicationService application)
        {
            throw new NotImplementedException();
        }

        public bool InterviewCandidate(Manager manager, Candidate candidate)
        {
            throw new NotImplementedException();
        }

        public bool PerformBackgroundCheck(BackgroundCheck candidateBackground)
        {
            throw new NotImplementedException();
        }
    }





}