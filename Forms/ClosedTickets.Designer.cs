
namespace TicketTracker.Forms
{
    partial class ClosedTickets
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
            this.closedTicketView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.closedTicketView)).BeginInit();
            this.SuspendLayout();
            // 
            // closedTicketView
            // 
            this.closedTicketView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.closedTicketView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.closedTicketView.Location = new System.Drawing.Point(56, 56);
            this.closedTicketView.Name = "closedTicketView";
            this.closedTicketView.RowTemplate.Height = 25;
            this.closedTicketView.Size = new System.Drawing.Size(600, 218);
            this.closedTicketView.TabIndex = 0;
            // 
            // ClosedTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(809, 318);
            this.Controls.Add(this.closedTicketView);
            this.Name = "ClosedTickets";
            this.Text = "ClosedTickets";
            this.Load += new System.EventHandler(this.ClosedTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closedTicketView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView closedTicketView;
    }
}