namespace CarService
{
    partial class MainForm
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.usersLabel = new System.Windows.Forms.Label();
            this.refreshUsersButton = new System.Windows.Forms.Button();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.refreshServicesButton = new System.Windows.Forms.Button();
            this.deleteServiceButton = new System.Windows.Forms.Button();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.servicesLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.deleteUserButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.addUserButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.usersLabel);
            this.mainSplitContainer.Panel1.Controls.Add(this.refreshUsersButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.usersListBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.refreshServicesButton);
            this.mainSplitContainer.Panel2.Controls.Add(this.deleteServiceButton);
            this.mainSplitContainer.Panel2.Controls.Add(this.addServiceButton);
            this.mainSplitContainer.Panel2.Controls.Add(this.servicesLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.dataGridView1);
            this.mainSplitContainer.Size = new System.Drawing.Size(919, 512);
            this.mainSplitContainer.SplitterDistance = 296;
            this.mainSplitContainer.TabIndex = 3;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(222, 6);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.deleteUserButton.TabIndex = 4;
            this.deleteUserButton.Text = "Удалить";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(141, 6);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 23);
            this.addUserButton.TabIndex = 3;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Location = new System.Drawing.Point(3, 11);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(51, 13);
            this.usersLabel.TabIndex = 1;
            this.usersLabel.Text = "Клиенты";
            // 
            // refreshUsersButton
            // 
            this.refreshUsersButton.Location = new System.Drawing.Point(60, 6);
            this.refreshUsersButton.Name = "refreshUsersButton";
            this.refreshUsersButton.Size = new System.Drawing.Size(75, 23);
            this.refreshUsersButton.TabIndex = 2;
            this.refreshUsersButton.Text = "Обновить";
            this.refreshUsersButton.UseVisualStyleBackColor = true;
            this.refreshUsersButton.Click += new System.EventHandler(this.refreshUsersButton_Click);
            // 
            // usersListBox
            // 
            this.usersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.Location = new System.Drawing.Point(3, 35);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(290, 472);
            this.usersListBox.TabIndex = 0;
            // 
            // refreshServicesButton
            // 
            this.refreshServicesButton.Location = new System.Drawing.Point(52, 6);
            this.refreshServicesButton.Name = "refreshServicesButton";
            this.refreshServicesButton.Size = new System.Drawing.Size(75, 23);
            this.refreshServicesButton.TabIndex = 6;
            this.refreshServicesButton.Text = "Обновить";
            this.refreshServicesButton.UseVisualStyleBackColor = true;
            this.refreshServicesButton.Click += new System.EventHandler(this.refreshServicesButton_Click);
            // 
            // deleteServiceButton
            // 
            this.deleteServiceButton.Location = new System.Drawing.Point(214, 6);
            this.deleteServiceButton.Name = "deleteServiceButton";
            this.deleteServiceButton.Size = new System.Drawing.Size(75, 23);
            this.deleteServiceButton.TabIndex = 5;
            this.deleteServiceButton.Text = "Удалить";
            this.deleteServiceButton.UseVisualStyleBackColor = true;
            this.deleteServiceButton.Click += new System.EventHandler(this.deleteServiceButton_Click);
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(133, 6);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(75, 23);
            this.addServiceButton.TabIndex = 5;
            this.addServiceButton.Text = "Добавить";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // servicesLabel
            // 
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.Location = new System.Drawing.Point(3, 11);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(43, 13);
            this.servicesLabel.TabIndex = 1;
            this.servicesLabel.Text = "Услуги";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(614, 471);
            this.dataGridView1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 512);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Service";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Button refreshUsersButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Label servicesLabel;
        private System.Windows.Forms.Button refreshServicesButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button deleteServiceButton;
    }
}

