namespace Project_12_2
{
    partial class Main
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
            this.groupBoxGuestTicketEnter.SuspendLayout();
            this.groupBoxTicketAvailibilityDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGuestTicketEnter
            // 
            this.groupBoxGuestTicketEnter.Controls.Add(this.lblTickets);
            this.groupBoxGuestTicketEnter.Location = new System.Drawing.Point(13, 13);
            this.groupBoxGuestTicketEnter.Name = "groupBoxGuestTicketEnter";
            this.groupBoxGuestTicketEnter.Size = new System.Drawing.Size(297, 82);
            this.groupBoxGuestTicketEnter.TabIndex = 0;
            this.groupBoxGuestTicketEnter.TabStop = false;
            this.groupBoxGuestTicketEnter.Text = "Guests with the following tickets may enter:";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(7, 34);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(45, 16);
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
            this.groupBoxTicketAvailibilityDisplay.Location = new System.Drawing.Point(13, 102);
            this.groupBoxTicketAvailibilityDisplay.Name = "groupBoxTicketAvailibilityDisplay";
            this.groupBoxTicketAvailibilityDisplay.Size = new System.Drawing.Size(297, 219);
            this.groupBoxTicketAvailibilityDisplay.TabIndex = 1;
            this.groupBoxTicketAvailibilityDisplay.TabStop = false;
            this.groupBoxTicketAvailibilityDisplay.Text = "Ticket Availiblity:";
            // 
            // btnIssueTicket
            // 
            this.btnIssueTicket.Location = new System.Drawing.Point(13, 125);
            this.btnIssueTicket.Name = "btnIssueTicket";
            this.btnIssueTicket.Size = new System.Drawing.Size(108, 36);
            this.btnIssueTicket.TabIndex = 4;
            this.btnIssueTicket.Text = "&Issue Ticket";
            this.btnIssueTicket.UseVisualStyleBackColor = true;
            // 
            // lblTimeofEntry
            // 
            this.lblTimeofEntry.AutoSize = true;
            this.lblTimeofEntry.Location = new System.Drawing.Point(143, 69);
            this.lblTimeofEntry.Name = "lblTimeofEntry";
            this.lblTimeofEntry.Size = new System.Drawing.Size(45, 16);
            this.lblTimeofEntry.TabIndex = 3;
            this.lblTimeofEntry.Text = "label4";
            // 
            // lblOutsandingTicketTotal
            // 
            this.lblOutsandingTicketTotal.AutoSize = true;
            this.lblOutsandingTicketTotal.Location = new System.Drawing.Point(143, 38);
            this.lblOutsandingTicketTotal.Name = "lblOutsandingTicketTotal";
            this.lblOutsandingTicketTotal.Size = new System.Drawing.Size(45, 16);
            this.lblOutsandingTicketTotal.TabIndex = 2;
            this.lblOutsandingTicketTotal.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Next Availible Entry:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Total:";
            // 
            // listBoxTicketQueueList
            // 
            this.listBoxTicketQueueList.FormattingEnabled = true;
            this.listBoxTicketQueueList.ItemHeight = 16;
            this.listBoxTicketQueueList.Location = new System.Drawing.Point(13, 328);
            this.listBoxTicketQueueList.Name = "listBoxTicketQueueList";
            this.listBoxTicketQueueList.Size = new System.Drawing.Size(297, 212);
            this.listBoxTicketQueueList.TabIndex = 2;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(13, 566);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(112, 39);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "&Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(198, 566);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 647);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.listBoxTicketQueueList);
            this.Controls.Add(this.groupBoxTicketAvailibilityDisplay);
            this.Controls.Add(this.groupBoxGuestTicketEnter);
            this.Name = "Main";
            this.Text = "Form1";
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
    }
}

