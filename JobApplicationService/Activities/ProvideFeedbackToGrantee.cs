using System.Activities;

namespace JobApplicationService.Activities
{
    public sealed class ProvideFeedbackToGrantee : CodeActivity
    {
        // Define activity arguments
        [RequiredArgument]
        public InArgument<string> MessageToGrantee { get; set; }

        [RequiredArgument]
        public InArgument<string> EmailAddress { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the input arguments
            string message = context.GetValue(this.MessageToGrantee);
            string address = context.GetValue(this.EmailAddress);
        }
    }
}
