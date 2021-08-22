
namespace TicketTracker.Forms
{
    partial class TicketComments
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
            this.commentGridView = new System.Windows.Forms.DataGridView();
            this.commentBox = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.commentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // commentGridView
            // 
            this.commentGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.commentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentGridView.Location = new System.Drawing.Point(23, 12);
            this.commentGridView.Name = "commentGridView";
            this.commentGridView.RowTemplate.Height = 25;
            this.commentGridView.Size = new System.Drawing.Size(298, 233);
            this.commentGridView.TabIndex = 0;
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(23, 265);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(298, 96);
            this.commentBox.TabIndex = 1;
            this.commentBox.Text = "Enter new comment....";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Location = new System.Drawing.Point(135, 391);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // TicketComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.commentGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TicketComments";
            this.Text = "Comments";
            this.Load += new System.EventHandler(this.TicketComments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView commentGridView;
        private System.Windows.Forms.RichTextBox commentBox;
        private System.Windows.Forms.Button submitButton;
    }
}