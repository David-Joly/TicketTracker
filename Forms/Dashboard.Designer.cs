
namespace TicketTracker
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dashPanel = new System.Windows.Forms.Panel();
            this.contactButton = new System.Windows.Forms.Button();
            this.closedTickButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.createTicketButton = new System.Windows.Forms.Button();
            this.yourTicketsButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.topDashPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.borderPanel = new System.Windows.Forms.Panel();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.statsLabel = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.commentsMadeLabel = new System.Windows.Forms.Label();
            this.completedTickLabel = new System.Windows.Forms.Label();
            this.openTicketLabel = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.ticketGridView = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.dashPanel.SuspendLayout();
            this.topDashPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.desktopPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dashPanel
            // 
            this.dashPanel.BackColor = System.Drawing.Color.White;
            this.dashPanel.Controls.Add(this.contactButton);
            this.dashPanel.Controls.Add(this.closedTickButton);
            this.dashPanel.Controls.Add(this.usersButton);
            this.dashPanel.Controls.Add(this.createTicketButton);
            this.dashPanel.Controls.Add(this.yourTicketsButton);
            this.dashPanel.Controls.Add(this.dashboardButton);
            this.dashPanel.Controls.Add(this.topDashPanel);
            this.dashPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashPanel.Location = new System.Drawing.Point(0, 0);
            this.dashPanel.Name = "dashPanel";
            this.dashPanel.Size = new System.Drawing.Size(171, 570);
            this.dashPanel.TabIndex = 0;
            // 
            // contactButton
            // 
            this.contactButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contactButton.FlatAppearance.BorderSize = 0;
            this.contactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.contactButton.Image = global::TicketTracker.Properties.Resources.email;
            this.contactButton.Location = new System.Drawing.Point(0, 528);
            this.contactButton.Name = "contactButton";
            this.contactButton.Size = new System.Drawing.Size(171, 42);
            this.contactButton.TabIndex = 1;
            this.contactButton.Text = "Contact Us";
            this.contactButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.contactButton.UseVisualStyleBackColor = true;
            this.contactButton.Click += new System.EventHandler(this.ContactUs_Click);
            // 
            // closedTickButton
            // 
            this.closedTickButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.closedTickButton.FlatAppearance.BorderSize = 0;
            this.closedTickButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedTickButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closedTickButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.closedTickButton.Image = global::TicketTracker.Properties.Resources.check_box;
            this.closedTickButton.Location = new System.Drawing.Point(0, 267);
            this.closedTickButton.Name = "closedTickButton";
            this.closedTickButton.Size = new System.Drawing.Size(171, 42);
            this.closedTickButton.TabIndex = 1;
            this.closedTickButton.Text = "Closed Tickets ";
            this.closedTickButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closedTickButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.closedTickButton.UseVisualStyleBackColor = true;
            this.closedTickButton.Click += new System.EventHandler(this.closedTickButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersButton.FlatAppearance.BorderSize = 0;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.usersButton.Image = global::TicketTracker.Properties.Resources.group;
            this.usersButton.Location = new System.Drawing.Point(0, 225);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(171, 42);
            this.usersButton.TabIndex = 1;
            this.usersButton.Text = "Users        ";
            this.usersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // createTicketButton
            // 
            this.createTicketButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createTicketButton.FlatAppearance.BorderSize = 0;
            this.createTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTicketButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTicketButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.createTicketButton.Image = global::TicketTracker.Properties.Resources.create;
            this.createTicketButton.Location = new System.Drawing.Point(0, 183);
            this.createTicketButton.Name = "createTicketButton";
            this.createTicketButton.Size = new System.Drawing.Size(171, 42);
            this.createTicketButton.TabIndex = 1;
            this.createTicketButton.Text = "Create Ticket    ";
            this.createTicketButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createTicketButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.createTicketButton.UseVisualStyleBackColor = true;
            this.createTicketButton.Click += new System.EventHandler(this.createTicketButton_Click);
            // 
            // yourTicketsButton
            // 
            this.yourTicketsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.yourTicketsButton.FlatAppearance.BorderSize = 0;
            this.yourTicketsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yourTicketsButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yourTicketsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.yourTicketsButton.Image = global::TicketTracker.Properties.Resources.local_activity;
            this.yourTicketsButton.Location = new System.Drawing.Point(0, 141);
            this.yourTicketsButton.Name = "yourTicketsButton";
            this.yourTicketsButton.Size = new System.Drawing.Size(171, 42);
            this.yourTicketsButton.TabIndex = 1;
            this.yourTicketsButton.Text = "Your Tickets     ";
            this.yourTicketsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yourTicketsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.yourTicketsButton.UseVisualStyleBackColor = true;
            this.yourTicketsButton.Click += new System.EventHandler(this.yourTicketsButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.dashboardButton.Image = global::TicketTracker.Properties.Resources.home1;
            this.dashboardButton.Location = new System.Drawing.Point(0, 99);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(171, 42);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "Dashboard       ";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // topDashPanel
            // 
            this.topDashPanel.BackColor = System.Drawing.Color.White;
            this.topDashPanel.Controls.Add(this.pictureBox1);
            this.topDashPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topDashPanel.Location = new System.Drawing.Point(0, 0);
            this.topDashPanel.Name = "topDashPanel";
            this.topDashPanel.Size = new System.Drawing.Size(171, 99);
            this.topDashPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicketTracker.Properties.Resources.bugslogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // borderPanel
            // 
            this.borderPanel.BackColor = System.Drawing.Color.White;
            this.borderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderPanel.Location = new System.Drawing.Point(171, 0);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(840, 10);
            this.borderPanel.TabIndex = 1;
            // 
            // desktopPanel
            // 
            this.desktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.desktopPanel.Controls.Add(this.userLabel);
            this.desktopPanel.Controls.Add(this.welcomeLabel);
            this.desktopPanel.Controls.Add(this.statsLabel);
            this.desktopPanel.Controls.Add(this.statsPanel);
            this.desktopPanel.Controls.Add(this.monthCalendar);
            this.desktopPanel.Controls.Add(this.ticketGridView);
            this.desktopPanel.Controls.Add(this.exitButton);
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(171, 10);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(840, 560);
            this.desktopPanel.TabIndex = 2;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(41, 68);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(44, 21);
            this.userLabel.TabIndex = 8;
            this.userLabel.Text = "User";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(25, 47);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(86, 21);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome,";
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statsLabel.ForeColor = System.Drawing.Color.White;
            this.statsLabel.Location = new System.Drawing.Point(155, 99);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(89, 21);
            this.statsLabel.TabIndex = 7;
            this.statsLabel.Text = "Your Stats ";
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.Color.White;
            this.statsPanel.Controls.Add(this.commentsMadeLabel);
            this.statsPanel.Controls.Add(this.completedTickLabel);
            this.statsPanel.Controls.Add(this.openTicketLabel);
            this.statsPanel.Location = new System.Drawing.Point(102, 137);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(208, 162);
            this.statsPanel.TabIndex = 6;
            // 
            // commentsMadeLabel
            // 
            this.commentsMadeLabel.AutoSize = true;
            this.commentsMadeLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.commentsMadeLabel.Location = new System.Drawing.Point(14, 109);
            this.commentsMadeLabel.Name = "commentsMadeLabel";
            this.commentsMadeLabel.Size = new System.Drawing.Size(120, 17);
            this.commentsMadeLabel.TabIndex = 0;
            this.commentsMadeLabel.Text = "Comments Made: ";
            // 
            // completedTickLabel
            // 
            this.completedTickLabel.AutoSize = true;
            this.completedTickLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.completedTickLabel.Location = new System.Drawing.Point(12, 67);
            this.completedTickLabel.Name = "completedTickLabel";
            this.completedTickLabel.Size = new System.Drawing.Size(130, 17);
            this.completedTickLabel.TabIndex = 0;
            this.completedTickLabel.Text = "Completed Tickets: ";
            // 
            // openTicketLabel
            // 
            this.openTicketLabel.AutoSize = true;
            this.openTicketLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openTicketLabel.Location = new System.Drawing.Point(12, 25);
            this.openTicketLabel.Name = "openTicketLabel";
            this.openTicketLabel.Size = new System.Drawing.Size(96, 17);
            this.openTicketLabel.TabIndex = 0;
            this.openTicketLabel.Text = "Open Tickets: ";
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.Color.White;
            this.monthCalendar.Location = new System.Drawing.Point(454, 131);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 5;
            // 
            // ticketGridView
            // 
            this.ticketGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ticketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketGridView.Location = new System.Drawing.Point(102, 361);
            this.ticketGridView.Name = "ticketGridView";
            this.ticketGridView.RowTemplate.Height = 25;
            this.ticketGridView.Size = new System.Drawing.Size(600, 187);
            this.ticketGridView.TabIndex = 4;
            this.ticketGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketGridView_CellContentClick);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(794, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(34, 33);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 570);
            this.Controls.Add(this.desktopPanel);
            this.Controls.Add(this.borderPanel);
            this.Controls.Add(this.dashPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.dashPanel.ResumeLayout(false);
            this.topDashPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.desktopPanel.ResumeLayout(false);
            this.desktopPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dashPanel;
        private System.Windows.Forms.Panel topDashPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button contactButton;
        private System.Windows.Forms.Button closedTickButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button createTicketButton;
        private System.Windows.Forms.Button yourTicketsButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Panel borderPanel;
        private System.Windows.Forms.Panel desktopPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label statsLabel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label commentsMadeLabel;
        private System.Windows.Forms.Label completedTickLabel;
        private System.Windows.Forms.Label openTicketLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridView ticketGridView;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label welcomeLabel;
    }
}

