
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
            this.ClosedTicketView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ClosedTicketView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClosedTicketView
            // 
            this.ClosedTicketView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClosedTicketView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClosedTicketView.Location = new System.Drawing.Point(56, 56);
            this.ClosedTicketView.Name = "ClosedTicketView";
            this.ClosedTicketView.RowTemplate.Height = 25;
            this.ClosedTicketView.Size = new System.Drawing.Size(724, 218);
            this.ClosedTicketView.TabIndex = 0;
            // 
            // ClosedTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(809, 318);
            this.Controls.Add(this.ClosedTicketView);
            this.Name = "ClosedTickets";
            this.Text = "ClosedTickets";
            ((System.ComponentModel.ISupportInitialize)(this.ClosedTicketView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClosedTicketView;
    }
}