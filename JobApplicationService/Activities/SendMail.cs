﻿using System;
using System.Activities;
using System.Threading;
using System.Diagnostics;
using System.Net.Mail;

namespace JobApplicationService.Activities
{

    public sealed class SendMail : AsyncCodeActivity
    {
        // Define an activity input argument of type string
        [RequiredArgument]
        public InArgument<string> ToAddress { get; set; }

        [RequiredArgument]
        public InArgument<string> FromAddress { get; set; }

        [RequiredArgument]
        public InArgument<string> Subject { get; set; }

        [RequiredArgument]
        public InArgument<string> Body { get; set; }

        protected override IAsyncResult BeginExecute(AsyncCodeActivityContext context, AsyncCallback callback, object state)
        {
            MailMessage mail = new MailMessage();

            mail.To.Add(new MailAddress(ToAddress.Get(context)));
            mail.From = new MailAddress(FromAddress.Get(context));
            mail.Subject = Subject.Get(context);
            mail.Body = Body.Get(context);
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();

            Action action = () =>
            {
                ManualResetEvent manualResetEvent = new ManualResetEvent(false);
                smtp.SendCompleted += (o, args) =>
                {
                    manualResetEvent.Set();
                    Debug.WriteLine("Send mail completed");
                };

                smtp.SendAsync(mail, null);
                manualResetEvent.WaitOne(TimeSpan.FromSeconds(30));
            };

            context.UserState = action;
            return action.BeginInvoke(callback, state);
        }

        protected override void EndExecute(AsyncCodeActivityContext context, IAsyncResult result)
        {
            Action action = context.UserState as Action;
            action.EndInvoke(result);
        }
    }
}
