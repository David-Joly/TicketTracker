
namespace TicketTracker.Forms
{
    partial class TicketCreation
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
            this.issueLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.issueBox = new System.Windows.Forms.RichTextBox();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.createTicketButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.issueLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.issueLabel.ForeColor = System.Drawing.Color.White;
            this.issueLabel.Location = new System.Drawing.Point(184, 130);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(43, 17);
            this.issueLabel.TabIndex = 0;
            this.issueLabel.Text = "Issue:";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priorityLabel.ForeColor = System.Drawing.Color.White;
            this.priorityLabel.Location = new System.Drawing.Point(169, 291);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(58, 17);
            this.priorityLabel.TabIndex = 0;
            this.priorityLabel.Text = "Priority:";
            // 
            // issueBox
            // 
            this.issueBox.Location = new System.Drawing.Point(233, 130);
            this.issueBox.Name = "issueBox";
            this.issueBox.Size = new System.Drawing.Size(316, 143);
            this.issueBox.TabIndex = 1;
            this.issueBox.Text = "";
            // 
            // priorityBox
            // 
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.priorityBox.Location = new System.Drawing.Point(233, 290);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(123, 23);
            this.priorityBox.TabIndex = 2;
            // 
            // createTicketButton
            // 
            this.createTicketButton.BackColor = System.Drawing.Color.White;
            this.createTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTicketButton.Location = new System.Drawing.Point(311, 345);
            this.createTicketButton.Name = "createTicketButton";
            this.createTicketButton.Size = new System.Drawing.Size(147, 23);
            this.createTicketButton.TabIndex = 3;
            this.createTicketButton.Text = "Submit Ticket";
            this.createTicketButton.UseVisualStyleBackColor = false;
            this.createTicketButton.Click += new System.EventHandler(this.createTicketButton_Click);
            // 
            // TicketCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(931, 518);
            this.Controls.Add(this.createTicketButton);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.issueBox);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.issueLabel);
            this.Name = "TicketCreation";
            this.Text = "TicketCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.RichTextBox issueBox;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.Button createTicketButton;
    }
}