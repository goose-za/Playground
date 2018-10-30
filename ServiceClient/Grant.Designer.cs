namespace ServiceClient
{
    partial class frmGrantApplicationService
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
            this.cmdCreateApplication = new System.Windows.Forms.Button();
            this.cmdCheckStatus = new System.Windows.Forms.Button();
            this.txtGrantRefId = new System.Windows.Forms.TextBox();
            this.btnCompleteProcess = new System.Windows.Forms.Button();
            this.btnInterviewFeedback = new System.Windows.Forms.Button();
            this.chkPassedReview = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmdCreateApplication
            // 
            this.cmdCreateApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCreateApplication.AutoSize = true;
            this.cmdCreateApplication.Location = new System.Drawing.Point(75, 12);
            this.cmdCreateApplication.Name = "cmdCreateApplication";
            this.cmdCreateApplication.Size = new System.Drawing.Size(138, 23);
            this.cmdCreateApplication.TabIndex = 0;
            this.cmdCreateApplication.Text = "Create Grant Application";
            this.cmdCreateApplication.UseVisualStyleBackColor = true;
            this.cmdCreateApplication.Click += new System.EventHandler(this.cmdCreateApplication_Click);
            // 
            // cmdCheckStatus
            // 
            this.cmdCheckStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCheckStatus.Location = new System.Drawing.Point(75, 175);
            this.cmdCheckStatus.Name = "cmdCheckStatus";
            this.cmdCheckStatus.Size = new System.Drawing.Size(138, 23);
            this.cmdCheckStatus.TabIndex = 1;
            this.cmdCheckStatus.Text = "Check Status";
            this.cmdCheckStatus.UseVisualStyleBackColor = true;
            this.cmdCheckStatus.Click += new System.EventHandler(this.cmdCheckStatus_Click);
            // 
            // txtGrantRefId
            // 
            this.txtGrantRefId.Location = new System.Drawing.Point(75, 57);
            this.txtGrantRefId.Name = "txtGrantRefId";
            this.txtGrantRefId.Size = new System.Drawing.Size(138, 20);
            this.txtGrantRefId.TabIndex = 3;
            // 
            // btnCompleteProcess
            // 
            this.btnCompleteProcess.Location = new System.Drawing.Point(197, 226);
            this.btnCompleteProcess.Name = "btnCompleteProcess";
            this.btnCompleteProcess.Size = new System.Drawing.Size(75, 23);
            this.btnCompleteProcess.TabIndex = 6;
            this.btnCompleteProcess.Text = "Complete";
            this.btnCompleteProcess.UseVisualStyleBackColor = true;
            this.btnCompleteProcess.Click += new System.EventHandler(this.btnCompleteProcess_Click);
            // 
            // btnInterviewFeedback
            // 
            this.btnInterviewFeedback.Location = new System.Drawing.Point(73, 135);
            this.btnInterviewFeedback.Name = "btnInterviewFeedback";
            this.btnInterviewFeedback.Size = new System.Drawing.Size(138, 23);
            this.btnInterviewFeedback.TabIndex = 8;
            this.btnInterviewFeedback.Text = "Interview Feedback";
            this.btnInterviewFeedback.UseVisualStyleBackColor = true;
            this.btnInterviewFeedback.Click += new System.EventHandler(this.btnInterviewFeedback_Click);
            // 
            // chkPassedReview
            // 
            this.chkPassedReview.AutoSize = true;
            this.chkPassedReview.Location = new System.Drawing.Point(73, 101);
            this.chkPassedReview.Name = "chkPassedReview";
            this.chkPassedReview.Size = new System.Drawing.Size(104, 17);
            this.chkPassedReview.TabIndex = 7;
            this.chkPassedReview.Text = "PassedInterview";
            this.chkPassedReview.UseVisualStyleBackColor = true;
            // 
            // frmGrantApplicationService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnInterviewFeedback);
            this.Controls.Add(this.chkPassedReview);
            this.Controls.Add(this.btnCompleteProcess);
            this.Controls.Add(this.txtGrantRefId);
            this.Controls.Add(this.cmdCheckStatus);
            this.Controls.Add(this.cmdCreateApplication);
            this.Name = "frmGrantApplicationService";
            this.Text = "Grant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCreateApplication;
        private System.Windows.Forms.Button cmdCheckStatus;
        private System.Windows.Forms.TextBox txtGrantRefId;
        private System.Windows.Forms.Button btnCompleteProcess;
        private System.Windows.Forms.Button btnInterviewFeedback;
        private System.Windows.Forms.CheckBox chkPassedReview;
    }
}