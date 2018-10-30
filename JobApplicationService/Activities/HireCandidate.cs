using System.Activities;

namespace JobApplicationService.Activities
{
    public class HireCandidate: CodeActivity
    {
        [RequiredArgument]
        public InArgument<JobApplicationStatus> ApplicationStatus { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var status = context.GetValue(ApplicationStatus);
            //Custom logic for creating a new employee
        }
    }
}