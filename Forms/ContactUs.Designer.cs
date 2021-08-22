
namespace TicketTracker.Forms
{
    partial class ContactUs
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
            this.subjectLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.mailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.subjectLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectLabel.ForeColor = System.Drawing.Color.White;
            this.subjectLabel.Location = new System.Drawing.Point(170, 131);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(57, 17);
            this.subjectLabel.TabIndex = 0;
            this.subjectLabel.Text = "Subject:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.messageLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.ForeColor = System.Drawing.Color.White;
            this.messageLabel.Location = new System.Drawing.Point(162, 172);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(65, 17);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Message:";
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(233, 130);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(244, 23);
            this.subjectBox.TabIndex = 1;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(233, 171);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(240, 160);
            this.messageBox.TabIndex = 2;
            this.messageBox.Text = "";
            // 
            // mailButton
            // 
            this.mailButton.BackColor = System.Drawing.Color.White;
            this.mailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mailButton.Location = new System.Drawing.Point(308, 358);
            this.mailButton.Name = "mailButton";
            this.mailButton.Size = new System.Drawing.Size(75, 23);
            this.mailButton.TabIndex = 3;
            this.mailButton.Text = "Send";
            this.mailButton.UseVisualStyleBackColor = false;
            this.mailButton.Click += new System.EventHandler(this.mailButton_Click);
            // 
            // ContactUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(769, 520);
            this.Controls.Add(this.mailButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.subjectLabel);
            this.Name = "ContactUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ContactUs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.Button mailButton;
    }
}