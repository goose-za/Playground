using System.Activities;

namespace JobApplicationService.Activities
{
    /// <summary>
    /// <para>
    /// Bookmarks allow event-driven communication to occur to an activity within a workflow,
    /// from an outside source, using the WF runtime as the channel of communication. 
    /// </para>
    /// <para>
    /// A bookmark in WF holds the last place a workflow executed, usually because the workflow
    /// is waiting on some external event to happen, so that it can back up.
    /// </para>
    /// </summary>
    /// <typeparam name="TResult">
    /// Any object that can be returned fro the WF runtime. 
    /// </typeparam>
    public sealed class WaitForResponse<TResult> : NativeActivity<TResult>
    {
        /// <summary>
        /// The class constructor
        /// </summary>
        public WaitForResponse()
            : base()
        {

        }

        /// <summary>
        /// The name of the bookmark
        /// </summary>
        public string ResponseName { get; set; }

        protected override bool CanInduceIdle
        {
            // override when the custom activity is allowed to make the workflow go idle
            get
            {
                return true;
            }
        }

        protected override void Execute(NativeActivityContext context)
        {
            context.CreateBookmark(this.ResponseName, new BookmarkCallback(this.ReceivedResponse));
        }

        void ReceivedResponse(NativeActivityContext context, Bookmark bookmark, object obj)
        {
            this.Result.Set(context, (TResult)obj);
        }
    }
}