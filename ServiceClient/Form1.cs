using System;
using System.Windows.Forms;

namespace ServiceClient
{
    public partial class frmJobApplicationService : Form
    {
        private JobPostingService.JobApplicationServiceClient jobApplicationService = null;
        private string jobApplicationRef = string.Empty;

        public frmJobApplicationService()
        {
            InitializeComponent();
            jobApplicationService = new JobPostingService.JobApplicationServiceClient();
        }

        private void btnCreateApplication_Click(object sender, EventArgs e)
        {
            var application = new JobPostingService.JobApplication()
            {
                ApplyingCandidate = new JobPostingService.Candidate
                {
                    FirstName = "John",
                    LastName = "Smith",
                    EmailAddress = "john.smith@acme.com",
                    SSN = "555-45-4444"
                },
                JobPosting = new JobPostingService.JobPosting
                {
                    JobPostingId = 5
                }
            };

            jobApplicationRef = jobApplicationService.ApplyForJob(application);
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            if (txtJobRefId.Text != "")
            {
                var application = jobApplicationService.GetJobApplicationStatus(txtJobRefId.Text);
            }
            else
            {
                var application = jobApplicationService.GetJobApplicationStatus(jobApplicationRef);
            }            
        }

        private void btnInterviewFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                jobApplicationService.InterviewCandidate(jobApplicationRef, chkPassedInterview.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
        }

        private void btnCompleteProcess_Click(object sender, EventArgs e)
        {
            try
            {
                jobApplicationService.TerminateJobApplication(jobApplicationRef);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
