namespace Project_12_2
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.groupBoxGuestTicketEnter = new System.Windows.Forms.GroupBox();
			this.lblTickets = new System.Windows.Forms.Label();
			this.groupBoxTicketAvailibilityDisplay = new System.Windows.Forms.GroupBox();
			this.btnIssueTicket = new System.Windows.Forms.Button();
			this.lblTimeofEntry = new System.Windows.Forms.Label();
			this.lblOutsandingTicketTotal = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.listBoxTicketQueueList = new System.Windows.Forms.ListBox();
			this.btnOptions = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.timerTimeNow = new System.Windows.Forms.Timer(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBoxGuestTicketEnter.SuspendLayout();
			this.groupBoxTicketAvailibilityDisplay.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxGuestTicketEnter
			// 
			this.groupBoxGuestTicketEnter.Controls.Add(this.lblTickets);
			this.groupBoxGuestTicketEnter.Location = new System.Drawing.Point(10, 11);
			this.groupBoxGuestTicketEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxGuestTicketEnter.Name = "groupBoxGuestTicketEnter";
			this.groupBoxGuestTicketEnter.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxGuestTicketEnter.Size = new System.Drawing.Size(223, 67);
			this.groupBoxGuestTicketEnter.TabIndex = 0;
			this.groupBoxGuestTicketEnter.TabStop = false;
			this.groupBoxGuestTicketEnter.Text = "Guests with the following tickets may enter:";
			// 
			// lblTickets
			// 
			this.lblTickets.AutoSize = true;
			this.lblTickets.Location = new System.Drawing.Point(5, 28);
			this.lblTickets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTickets.Name = "lblTickets";
			this.lblTickets.Size = new System.Drawing.Size(35, 13);
			this.lblTickets.TabIndex = 0;
			this.lblTickets.Text = "label1";
			// 
			// groupBoxTicketAvailibilityDisplay
			// 
			this.groupBoxTicketAvailibilityDisplay.Controls.Add(this.btnIssueTicket);
			this.groupBoxTicketAvailibilityDisplay.Controls.Add(this.lblTimeofEntry);
			this.groupBoxTicketAvailibilityDisplay.Controls.Add(this.lblOutsandingTicketTotal);
			this.groupBoxTicketAvailibilityDisplay.Controls.Add(this.label2);
			this.groupBoxTicketAvailibilityDisplay.Controls.Add(this.label1);
			this.groupBoxTicketAvailibilityDisplay.Location = new System.Drawing.Point(10, 83);
			this.groupBoxTicketAvailibilityDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxTicketAvailibilityDisplay.Name = "groupBoxTicketAvailibilityDisplay";
			this.groupBoxTicketAvailibilityDisplay.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxTicketAvailibilityDisplay.Size = new System.Drawing.Size(223, 139);
			this.groupBoxTicketAvailibilityDisplay.TabIndex = 1;
			this.groupBoxTicketAvailibilityDisplay.TabStop = false;
			this.groupBoxTicketAvailibilityDisplay.Text = "Ticket Availiblity:";
			// 
			// btnIssueTicket
			// 
			this.btnIssueTicket.Location = new System.Drawing.Point(10, 102);
			this.btnIssueTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnIssueTicket.Name = "btnIssueTicket";
			this.btnIssueTicket.Size = new System.Drawing.Size(81, 29);
			this.btnIssueTicket.TabIndex = 4;
			this.btnIssueTicket.Text = "&Issue Ticket";
			this.btnIssueTicket.UseVisualStyleBackColor = true;
			this.btnIssueTicket.Click += new System.EventHandler(this.btnIssueTicket_Click);
			// 
			// lblTimeofEntry
			// 
			this.lblTimeofEntry.AutoSize = true;
			this.lblTimeofEntry.Location = new System.Drawing.Point(107, 56);
			this.lblTimeofEntry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTimeofEntry.Name = "lblTimeofEntry";
			this.lblTimeofEntry.Size = new System.Drawing.Size(35, 13);
			this.lblTimeofEntry.TabIndex = 3;
			this.lblTimeofEntry.Text = "label4";
			// 
			// lblOutsandingTicketTotal
			// 
			this.lblOutsandingTicketTotal.AutoSize = true;
			this.lblOutsandingTicketTotal.Location = new System.Drawing.Point(99, 30);
			this.lblOutsandingTicketTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblOutsandingTicketTotal.Name = "lblOutsandingTicketTotal";
			this.lblOutsandingTicketTotal.Size = new System.Drawing.Size(35, 13);
			this.lblOutsandingTicketTotal.TabIndex = 2;
			this.lblOutsandingTicketTotal.Text = "label3";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 56);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Next Availible Entry:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ticket Total:";
			// 
			// listBoxTicketQueueList
			// 
			this.listBoxTicketQueueList.FormattingEnabled = true;
			this.listBoxTicketQueueList.Location = new System.Drawing.Point(10, 218);
			this.listBoxTicketQueueList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.listBoxTicketQueueList.Name = "listBoxTicketQueueList";
			this.listBoxTicketQueueList.Size = new System.Drawing.Size(224, 173);
			this.listBoxTicketQueueList.TabIndex = 2;
			// 
			// btnOptions
			// 
			this.btnOptions.Location = new System.Drawing.Point(10, 413);
			this.btnOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnOptions.Name = "btnOptions";
			this.btnOptions.Size = new System.Drawing.Size(84, 32);
			this.btnOptions.TabIndex = 3;
			this.btnOptions.Text = "&Options";
			this.btnOptions.UseVisualStyleBackColor = true;
			this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(148, 413);
			this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(84, 32);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "&Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// timerTimeNow
			// 
			this.timerTimeNow.Enabled = true;
			this.timerTimeNow.Interval = 1000;
			this.timerTimeNow.Tick += new System.EventHandler(this.timeNowForm);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnIssueTicket;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(428, 453);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnOptions);
			this.Controls.Add(this.listBoxTicketQueueList);
			this.Controls.Add(this.groupBoxTicketAvailibilityDisplay);
			this.Controls.Add(this.groupBoxGuestTicketEnter);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBoxGuestTicketEnter.ResumeLayout(false);
			this.groupBoxGuestTicketEnter.PerformLayout();
			this.groupBoxTicketAvailibilityDisplay.ResumeLayout(false);
			this.groupBoxTicketAvailibilityDisplay.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGuestTicketEnter;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.GroupBox groupBoxTicketAvailibilityDisplay;
        private System.Windows.Forms.Button btnIssueTicket;
        private System.Windows.Forms.Label lblTimeofEntry;
        private System.Windows.Forms.Label lblOutsandingTicketTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxTicketQueueList;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timerTimeNow;
        private System.Windows.Forms.Timer timer1;
    }
}

