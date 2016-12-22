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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.userpasswordTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.getEmployeesButton = new System.Windows.Forms.Button();
            this.getJobsButton = new System.Windows.Forms.Button();
            this.getCurrentUserButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.serverTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.userTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.userpasswordTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.outputTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "User password:";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverTextBox.Location = new System.Drawing.Point(90, 3);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(642, 20);
            this.serverTextBox.TabIndex = 0;
            // 
            // userTextBox
            // 
            this.userTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTextBox.Location = new System.Drawing.Point(90, 28);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(642, 20);
            this.userTextBox.TabIndex = 1;
            // 
            // userpasswordTextBox
            // 
            this.userpasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userpasswordTextBox.Location = new System.Drawing.Point(90, 53);
            this.userpasswordTextBox.Name = "userpasswordTextBox";
            this.userpasswordTextBox.PasswordChar = '*';
            this.userpasswordTextBox.Size = new System.Drawing.Size(642, 20);
            this.userpasswordTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Location = new System.Drawing.Point(90, 78);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(642, 369);
            this.outputTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User name:";
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(641, 468);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(103, 35);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // getEmployeesButton
            // 
            this.getEmployeesButton.Enabled = false;
            this.getEmployeesButton.Location = new System.Drawing.Point(12, 468);
            this.getEmployeesButton.Name = "getEmployeesButton";
            this.getEmployeesButton.Size = new System.Drawing.Size(108, 35);
            this.getEmployeesButton.TabIndex = 2;
            this.getEmployeesButton.Text = "Get Employees";
            this.getEmployeesButton.UseVisualStyleBackColor = true;
            this.getEmployeesButton.Click += new System.EventHandler(this.getEmployeesButton_Click);
            // 
            // getJobsButton
            // 
            this.getJobsButton.Enabled = false;
            this.getJobsButton.Location = new System.Drawing.Point(126, 468);
            this.getJobsButton.Name = "getJobsButton";
            this.getJobsButton.Size = new System.Drawing.Size(108, 35);
            this.getJobsButton.TabIndex = 3;
            this.getJobsButton.Text = "Get Open Jobs";
            this.getJobsButton.UseVisualStyleBackColor = true;
            this.getJobsButton.Click += new System.EventHandler(this.getJobsButton_Click);
            // 
            // getCurrentUserButton
            // 
            this.getCurrentUserButton.Enabled = false;
            this.getCurrentUserButton.Location = new System.Drawing.Point(240, 468);
            this.getCurrentUserButton.Name = "getCurrentUserButton";
            this.getCurrentUserButton.Size = new System.Drawing.Size(108, 35);
            this.getCurrentUserButton.TabIndex = 4;
            this.getCurrentUserButton.Text = "Get Current User";
            this.getCurrentUserButton.UseVisualStyleBackColor = true;
            this.getCurrentUserButton.Click += new System.EventHandler(this.getCurrentUserButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 515);
            this.Controls.Add(this.getCurrentUserButton);
            this.Controls.Add(this.getJobsButton);
            this.Controls.Add(this.getEmployeesButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "API Test";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox userpasswordTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button getEmployeesButton;
        private System.Windows.Forms.Button getJobsButton;
        private System.Windows.Forms.Button getCurrentUserButton;
    }
}

