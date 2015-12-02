namespace Project_12_2
{
    partial class frmOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinWindow = new System.Windows.Forms.TextBox();
            this.txtGuestWindow = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtFirstTicket = new System.Windows.Forms.TextBox();
            this.btnOptionsOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutes per window:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guests per window:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Start time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "End time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "First ticket number:";
            // 
            // txtMinWindow
            // 
            this.txtMinWindow.Location = new System.Drawing.Point(123, 10);
            this.txtMinWindow.Name = "txtMinWindow";
            this.txtMinWindow.Size = new System.Drawing.Size(100, 20);
            this.txtMinWindow.TabIndex = 2;
            this.txtMinWindow.Tag = "MinutesPer";
            this.txtMinWindow.Text = "5";
            // 
            // txtGuestWindow
            // 
            this.txtGuestWindow.Location = new System.Drawing.Point(123, 42);
            this.txtGuestWindow.Name = "txtGuestWindow";
            this.txtGuestWindow.Size = new System.Drawing.Size(100, 20);
            this.txtGuestWindow.TabIndex = 3;
            this.txtGuestWindow.Tag = "f";
            this.txtGuestWindow.Text = "5";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(123, 66);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(100, 20);
            this.txtStartTime.TabIndex = 4;
            this.txtStartTime.Tag = "StartTime";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(123, 92);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(100, 20);
            this.txtEndTime.TabIndex = 5;
            this.txtEndTime.Tag = "EndTime";
            // 
            // txtFirstTicket
            // 
            this.txtFirstTicket.Location = new System.Drawing.Point(123, 118);
            this.txtFirstTicket.Name = "txtFirstTicket";
            this.txtFirstTicket.Size = new System.Drawing.Size(100, 20);
            this.txtFirstTicket.TabIndex = 6;
            this.txtFirstTicket.Tag = "FirstTicket";
            this.txtFirstTicket.Text = "1";
            // 
            // btnOptionsOK
            // 
            this.btnOptionsOK.Location = new System.Drawing.Point(135, 161);
            this.btnOptionsOK.Name = "btnOptionsOK";
            this.btnOptionsOK.Size = new System.Drawing.Size(75, 23);
            this.btnOptionsOK.TabIndex = 7;
            this.btnOptionsOK.Text = "OK";
            this.btnOptionsOK.UseVisualStyleBackColor = true;
            this.btnOptionsOK.Click += new System.EventHandler(this.btnOptionsOK_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 196);
            this.Controls.Add(this.btnOptionsOK);
            this.Controls.Add(this.txtFirstTicket);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtGuestWindow);
            this.Controls.Add(this.txtMinWindow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOptions";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinWindow;
        private System.Windows.Forms.TextBox txtGuestWindow;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtFirstTicket;
        private System.Windows.Forms.Button btnOptionsOK;
    }
}