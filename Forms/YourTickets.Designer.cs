
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
            this.userTicketView = new System.Windows.Forms.DataGridView();
            this.ticketIDLabel = new System.Windows.Forms.Label();
            this.closeBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userTicketView)).BeginInit();
            this.SuspendLayout();
            // 
            // userTicketView
            // 
            this.userTicketView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.userTicketView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTicketView.Location = new System.Drawing.Point(102, 56);
            this.userTicketView.Name = "userTicketView";
            this.userTicketView.RowTemplate.Height = 25;
            this.userTicketView.Size = new System.Drawing.Size(600, 218);
            this.userTicketView.TabIndex = 0;
            this.userTicketView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userTicketView_CellContentClick);
            // 
            // ticketIDLabel
            // 
            this.ticketIDLabel.AutoSize = true;
            this.ticketIDLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticketIDLabel.ForeColor = System.Drawing.Color.White;
            this.ticketIDLabel.Location = new System.Drawing.Point(232, 293);
            this.ticketIDLabel.Name = "ticketIDLabel";
            this.ticketIDLabel.Size = new System.Drawing.Size(99, 17);
            this.ticketIDLabel.TabIndex = 1;
            this.ticketIDLabel.Text = "Enter TicketID:";
            // 
            // closeBox
            // 
            this.closeBox.Location = new System.Drawing.Point(337, 292);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(141, 23);
            this.closeBox.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(359, 343);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(106, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close Ticket";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // YourTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(783, 394);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.ticketIDLabel);
            this.Controls.Add(this.userTicketView);
            this.Name = "YourTickets";
            this.Text = "YourTickets";
            this.Load += new System.EventHandler(this.YourTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userTicketView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userTicketView;
        private System.Windows.Forms.Label ticketIDLabel;
        private System.Windows.Forms.TextBox closeBox;
        private System.Windows.Forms.Button closeButton;
    }
}