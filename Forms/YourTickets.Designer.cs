
namespace TicketTracker.Forms
{
    partial class YourTickets
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketIDLabel = new System.Windows.Forms.Label();
            this.closeBox = new System.Windows.Forms.TextBox();
            this.closeTicketButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(724, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // ticketIDLabel
            // 
            this.ticketIDLabel.AutoSize = true;
            this.ticketIDLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticketIDLabel.ForeColor = System.Drawing.Color.White;
            this.ticketIDLabel.Location = new System.Drawing.Point(267, 298);
            this.ticketIDLabel.Name = "ticketIDLabel";
            this.ticketIDLabel.Size = new System.Drawing.Size(99, 17);
            this.ticketIDLabel.TabIndex = 1;
            this.ticketIDLabel.Text = "Enter TicketID:";
            // 
            // closeBox
            // 
            this.closeBox.Location = new System.Drawing.Point(372, 297);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(141, 23);
            this.closeBox.TabIndex = 2;
            // 
            // closeTicketButton
            // 
            this.closeTicketButton.BackColor = System.Drawing.Color.White;
            this.closeTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeTicketButton.Location = new System.Drawing.Point(334, 343);
            this.closeTicketButton.Name = "closeTicketButton";
            this.closeTicketButton.Size = new System.Drawing.Size(106, 23);
            this.closeTicketButton.TabIndex = 3;
            this.closeTicketButton.Text = "Close Ticket";
            this.closeTicketButton.UseVisualStyleBackColor = false;
            // 
            // YourTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(783, 394);
            this.Controls.Add(this.closeTicketButton);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.ticketIDLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "YourTickets";
            this.Text = "YourTickets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ticketIDLabel;
        private System.Windows.Forms.TextBox closeBox;
        private System.Windows.Forms.Button closeTicketButton;
    }
}