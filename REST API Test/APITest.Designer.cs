namespace REST_API_Test
{
    partial class APITest
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
            this.connectButton = new System.Windows.Forms.Button();
            this.getEmployeesButton = new System.Windows.Forms.Button();
            this.getJobsButton = new System.Windows.Forms.Button();
            this.getCurrentUserButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.userpasswordTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentNameTextBox = new System.Windows.Forms.TextBox();
            this.currentInitialsTextBox = new System.Windows.Forms.TextBox();
            this.currentPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saveCurrentUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(856, 453);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(103, 35);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // getEmployeesButton
            // 
            this.getEmployeesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getEmployeesButton.Enabled = false;
            this.getEmployeesButton.Location = new System.Drawing.Point(90, 453);
            this.getEmployeesButton.Name = "getEmployeesButton";
            this.getEmployeesButton.Size = new System.Drawing.Size(108, 35);
            this.getEmployeesButton.TabIndex = 2;
            this.getEmployeesButton.Text = "Get Employees";
            this.getEmployeesButton.UseVisualStyleBackColor = true;
            this.getEmployeesButton.Click += new System.EventHandler(this.getEmployeesButton_Click);
            // 
            // getJobsButton
            // 
            this.getJobsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getJobsButton.Enabled = false;
            this.getJobsButton.Location = new System.Drawing.Point(204, 453);
            this.getJobsButton.Name = "getJobsButton";
            this.getJobsButton.Size = new System.Drawing.Size(108, 35);
            this.getJobsButton.TabIndex = 3;
            this.getJobsButton.Text = "Get Open Jobs";
            this.getJobsButton.UseVisualStyleBackColor = true;
            this.getJobsButton.Click += new System.EventHandler(this.getJobsButton_Click);
            // 
            // getCurrentUserButton
            // 
            this.getCurrentUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getCurrentUserButton.Enabled = false;
            this.getCurrentUserButton.Location = new System.Drawing.Point(851, 85);
            this.getCurrentUserButton.Name = "getCurrentUserButton";
            this.getCurrentUserButton.Size = new System.Drawing.Size(108, 35);
            this.getCurrentUserButton.TabIndex = 4;
            this.getCurrentUserButton.Text = "Get Current User";
            this.getCurrentUserButton.UseVisualStyleBackColor = true;
            this.getCurrentUserButton.Click += new System.EventHandler(this.getCurrentUserButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "User password:";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverTextBox.Location = new System.Drawing.Point(90, 6);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(499, 20);
            this.serverTextBox.TabIndex = 8;
            // 
            // userTextBox
            // 
            this.userTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTextBox.Location = new System.Drawing.Point(90, 34);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(499, 20);
            this.userTextBox.TabIndex = 9;
            // 
            // userpasswordTextBox
            // 
            this.userpasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userpasswordTextBox.Location = new System.Drawing.Point(90, 59);
            this.userpasswordTextBox.Name = "userpasswordTextBox";
            this.userpasswordTextBox.PasswordChar = '*';
            this.userpasswordTextBox.Size = new System.Drawing.Size(499, 20);
            this.userpasswordTextBox.TabIndex = 10;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Location = new System.Drawing.Point(90, 84);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(499, 363);
            this.outputTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Server address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "User name:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Phone number";
            // 
            // currentNameTextBox
            // 
            this.currentNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentNameTextBox.Location = new System.Drawing.Point(694, 6);
            this.currentNameTextBox.Name = "currentNameTextBox";
            this.currentNameTextBox.Size = new System.Drawing.Size(265, 20);
            this.currentNameTextBox.TabIndex = 16;
            // 
            // currentInitialsTextBox
            // 
            this.currentInitialsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentInitialsTextBox.Location = new System.Drawing.Point(694, 34);
            this.currentInitialsTextBox.Name = "currentInitialsTextBox";
            this.currentInitialsTextBox.Size = new System.Drawing.Size(265, 20);
            this.currentInitialsTextBox.TabIndex = 17;
            // 
            // currentPhoneTextBox
            // 
            this.currentPhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPhoneTextBox.Location = new System.Drawing.Point(694, 59);
            this.currentPhoneTextBox.Name = "currentPhoneTextBox";
            this.currentPhoneTextBox.Size = new System.Drawing.Size(265, 20);
            this.currentPhoneTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(607, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Initials:";
            // 
            // saveCurrentUserButton
            // 
            this.saveCurrentUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveCurrentUserButton.Enabled = false;
            this.saveCurrentUserButton.Location = new System.Drawing.Point(694, 84);
            this.saveCurrentUserButton.Name = "saveCurrentUserButton";
            this.saveCurrentUserButton.Size = new System.Drawing.Size(108, 35);
            this.saveCurrentUserButton.TabIndex = 22;
            this.saveCurrentUserButton.Text = "Save Current User";
            this.saveCurrentUserButton.UseVisualStyleBackColor = true;
            this.saveCurrentUserButton.Click += new System.EventHandler(this.saveCurrentUserButton_Click);
            // 
            // APITest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 500);
            this.Controls.Add(this.saveCurrentUserButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currentNameTextBox);
            this.Controls.Add(this.currentInitialsTextBox);
            this.Controls.Add(this.currentPhoneTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.userpasswordTextBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getCurrentUserButton);
            this.Controls.Add(this.getJobsButton);
            this.Controls.Add(this.getEmployeesButton);
            this.Controls.Add(this.connectButton);
            this.Name = "APITest";
            this.Text = "API Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button getEmployeesButton;
        private System.Windows.Forms.Button getJobsButton;
        private System.Windows.Forms.Button getCurrentUserButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox userpasswordTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currentNameTextBox;
        private System.Windows.Forms.TextBox currentInitialsTextBox;
        private System.Windows.Forms.TextBox currentPhoneTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveCurrentUserButton;
    }
}

