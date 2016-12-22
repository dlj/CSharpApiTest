using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REST_API_Test
{
    public partial class APITest : Form
    {
        public CSharpAPICalls.Logic sharp;
        public APITest()
        {
            InitializeComponent();
            sharp = new CSharpAPICalls.Logic();
        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            sharp.ServerUrl = this.serverTextBox.Text;
            sharp.User = this.userTextBox.Text;
            sharp.Password = this.userpasswordTextBox.Text;

            try
            {
                var result = await sharp.TryLogin();
                // Only success is handles as a return. Invalid is an exception
                if (result)
                {
                    this.outputTextBox.Text = "Login Successful";
                    this.getJobsButton.Enabled = true;
                    this.getEmployeesButton.Enabled = true;
                    this.getCurrentUserButton.Enabled = true;
                }
            }
            catch (Exception exp)
            {
                this.outputTextBox.Text = exp.Message;
            }            
        }

        private async void getJobsButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await sharp.JobsRequest();
                
                if (!string.IsNullOrEmpty(result)) {

                    // Just limit the output. WinForms aint that happy about writing 100000 lines of text
                    var length = 2000;
                        if (result.Length < 2000)
                            length = result.Length;
                        this.outputTextBox.Text = result.Substring(0, length);
                    }
            }
            catch (Exception exp)
            {
                this.outputTextBox.Text = exp.Message;
            }
        }

        private async void getCurrentUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await sharp.CurrentUserRequest();

                if (!string.IsNullOrEmpty(result))
                {
                    this.outputTextBox.Text = result;
                }
            }
            catch (Exception exp)
            {
                this.outputTextBox.Text = exp.Message;
            }
        }

        private async void getEmployeesButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await sharp.EmployeeRequest();

                if (!string.IsNullOrEmpty(result))
                {

                    // Just limit the output. WinForms aint that happy about writing 100000 lines of text
                    var length = 2000;
                    if (result.Length < 2000)
                        length = result.Length;
                    this.outputTextBox.Text = result.Substring(0, length);
                }
            }
            catch (Exception exp)
            {
                this.outputTextBox.Text = exp.Message;
            }
        }
    }
}
