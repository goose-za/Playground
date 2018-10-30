using System.Activities;

namespace JobApplicationService.Activities
{
    public sealed class ProvideFeedbackToCandidate : CodeActivity
    {
        // Define activity arguments
        [RequiredArgument]
        public InArgument<string> MessageToCandidate { get; set; }

        [RequiredArgument]
        public InArgument<string> EmailAddress { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the input arguments
            string message = context.GetValue(this.MessageToCandidate);
            string address = context.GetValue(this.EmailAddress);
        }
    }
}
