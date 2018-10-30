namespace ServiceClient
{
    partial class frmJobApplicationService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateApplication = new System.Windows.Forms.Button();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.txtJobRefId = new System.Windows.Forms.TextBox();
            this.chkPassedInterview = new System.Windows.Forms.CheckBox();
            this.btnInterviewFeedback = new System.Windows.Forms.Button();
            this.btnCompleteProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateApplication
            // 
            this.btnCreateApplication.Location = new System.Drawing.Point(75, 12);
            this.btnCreateApplication.Name = "btnCreateApplication";
            this.btnCreateApplication.Size = new System.Drawing.Size(138, 23);
            this.btnCreateApplication.TabIndex = 0;
            this.btnCreateApplication.Text = "Create Job Application";
            this.btnCreateApplication.UseVisualStyleBackColor = true;
            this.btnCreateApplication.Click += new System.EventHandler(this.btnCreateApplication_Click);
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.Location = new System.Drawing.Point(75, 176);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(138, 23);
            this.btnCheckStatus.TabIndex = 1;
            this.btnCheckStatus.Text = "Check Status";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // txtJobRefId
            // 
            this.txtJobRefId.Location = new System.Drawing.Point(75, 56);
            this.txtJobRefId.Name = "txtJobRefId";
            this.txtJobRefId.Size = new System.Drawing.Size(138, 20);
            this.txtJobRefId.TabIndex = 2;
            // 
            // chkPassedInterview
            // 
            this.chkPassedInterview.AutoSize = true;
            this.chkPassedInterview.Location = new System.Drawing.Point(75, 101);
            this.chkPassedInterview.Name = "chkPassedInterview";
            this.chkPassedInterview.Size = new System.Drawing.Size(104, 17);
            this.chkPassedInterview.TabIndex = 3;
            this.chkPassedInterview.Text = "PassedInterview";
            this.chkPassedInterview.UseVisualStyleBackColor = true;
            // 
            // btnInterviewFeedback
            // 
            this.btnInterviewFeedback.Location = new System.Drawing.Point(75, 135);
            this.btnInterviewFeedback.Name = "btnInterviewFeedback";
            this.btnInterviewFeedback.Size = new System.Drawing.Size(138, 23);
            this.btnInterviewFeedback.TabIndex = 4;
            this.btnInterviewFeedback.Text = "Interview Feedback";
            this.btnInterviewFeedback.UseVisualStyleBackColor = true;
            this.btnInterviewFeedback.Click += new System.EventHandler(this.btnInterviewFeedback_Click);
            // 
            // btnCompleteProcess
            // 
            this.btnCompleteProcess.Location = new System.Drawing.Point(202, 221);
            this.btnCompleteProcess.Name = "btnCompleteProcess";
            this.btnCompleteProcess.Size = new System.Drawing.Size(75, 23);
            this.btnCompleteProcess.TabIndex = 5;
            this.btnCompleteProcess.Text = "Complete";
            this.btnCompleteProcess.UseVisualStyleBackColor = true;
            this.btnCompleteProcess.Click += new System.EventHandler(this.btnCompleteProcess_Click);
            // 
            // frmJobApplicationService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 256);
            this.Controls.Add(this.btnCompleteProcess);
            this.Controls.Add(this.btnInterviewFeedback);
            this.Controls.Add(this.chkPassedInterview);
            this.Controls.Add(this.txtJobRefId);
            this.Controls.Add(this.btnCheckStatus);
            this.Controls.Add(this.btnCreateApplication);
            this.Name = "frmJobApplicationService";
            this.Text = "Job Application Service Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateApplication;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.TextBox txtJobRefId;
        private System.Windows.Forms.CheckBox chkPassedInterview;
        private System.Windows.Forms.Button btnInterviewFeedback;
        private System.Windows.Forms.Button btnCompleteProcess;
    }
}

