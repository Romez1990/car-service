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
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.usersLabel = new System.Windows.Forms.Label();
            this.refreshUsersButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.usersListBox = new System.Windows.Forms.ListBox();
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
            this.mainSplitContainer.Panel1.Controls.Add(this.addUserButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.refreshUsersButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.usersLabel);
            this.mainSplitContainer.Panel1.Controls.Add(this.refreshUsersButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.usersListBox);
            this.mainSplitContainer.Size = new System.Drawing.Size(800, 458);
            this.mainSplitContainer.SplitterDistance = 266;
            this.mainSplitContainer.TabIndex = 3;
            //
            // usersLabel
            //
            this.usersLabel.AutoSize = true;
            this.usersLabel.Location = new System.Drawing.Point(3, 11);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(80, 13);
            this.usersLabel.TabIndex = 1;
            this.usersLabel.Text = "Пользователи";
            //
            // refreshUsersButton
            //
            this.refreshUsersButton.Location = new System.Drawing.Point(89, 6);
            this.refreshUsersButton.Name = "refreshUsersButton";
            this.refreshUsersButton.Size = new System.Drawing.Size(75, 23);
            this.refreshUsersButton.TabIndex = 2;
            this.refreshUsersButton.Text = "Обновить";
            this.refreshUsersButton.UseVisualStyleBackColor = true;
            this.refreshUsersButton.Click += new System.EventHandler(this.refreshUsersButton_Click);
            //
            // addUserButton
            //
            this.addUserButton.Location = new System.Drawing.Point(170, 6);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 23);
            this.addUserButton.TabIndex = 3;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            //
            // usersListBox
            //
            this.usersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.Location = new System.Drawing.Point(3, 35);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(260, 420);
            this.usersListBox.TabIndex = 0;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Service";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Button refreshUsersButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.ListBox usersListBox;
    }
}

