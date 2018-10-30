using System.Activities;

namespace JobApplicationService.Activities
{
    public class AwardGrant: CodeActivity
    {
        [RequiredArgument]
        public InArgument<GrantApplicationStatus> ApplicationStatus { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var status = context.GetValue(ApplicationStatus);
            //Custom logic for awarding a new grant
        }
    }
}