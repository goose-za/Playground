using System;
using System.Windows.Forms;

namespace ServiceClient
{
    public partial class frmGrantApplicationService : Form
    {
        private GrantApplicationService.GrantApplicationServiceClient grantApplicationService = null;
        private string grantApplicationRef = string.Empty;

        public frmGrantApplicationService()
        {
            InitializeComponent();
            grantApplicationService = new GrantApplicationService.GrantApplicationServiceClient();
        }

        private void cmdCreateApplication_Click(object sender, EventArgs e)
        {
            try
            {
                var application = new GrantApplicationService.GrantApplication()
                {
                    ApplyingGrantee = new GrantApplicationService.Grantee()
                    {
                        EmailAddress = "rfc@gmail.com",
                        GranteeId = "12345",
                        OrgName = "Results for Change"
                    },
                    GrantTypeId = "1",
                    OrgId = "1004"
                };

                grantApplicationRef = grantApplicationService.ApplyForGrant(application);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdCheckStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGrantRefId.Text != "")
                {
                    var application = grantApplicationService.GetGrantApplicationStatus(txtGrantRefId.Text);
                }
                else
                {
                    var application = grantApplicationService.GetGrantApplicationStatus(grantApplicationRef);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCompleteProcess_Click(object sender, EventArgs e)
        {
            try
            {
                grantApplicationService.TerminateJobApplication(grantApplicationRef);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInterviewFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                grantApplicationService.ReviewApplication(grantApplicationRef, chkPassedReview.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
        }
    }
}
