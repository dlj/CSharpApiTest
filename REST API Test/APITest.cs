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
        // This could be made more clear, by making interfaces for the Logic. But for the sake of simplicity, keep it this way.
        //public CSharpAPICalls.Logic ApiLogic;
        private VBAPICalls.Logic ApiLogic;        
        private object currentResource = null;
        public APITest()
        {
            InitializeComponent();
            //ApiLogic = new CSharpAPICalls.Logic();
            ApiLogic = new VBAPICalls.Logic();
        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            ApiLogic.ServerUrl = this.serverTextBox.Text;
            ApiLogic.User = this.userTextBox.Text;
            ApiLogic.Password = this.userpasswordTextBox.Text;

            try
            {
                var result = await ApiLogic.TryLogin();
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
                var result = await ApiLogic.Jobs();
                
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
            var result = await ApiLogic.CurrentUser();

            if (result != null)
            {
                this.currentNameTextBox.Text = result.Name;
                this.currentPhoneTextBox.Text = result.Phone1;
                this.currentInitialsTextBox.Text = result.Initials;
                this.saveCurrentUserButton.Enabled = true;
                this.currentResource = result;
            }
            else
                this.outputTextBox.Text = "Error : Current user not found";
        }

        private async void saveCurrentUserButton_Click(object sender, EventArgs e)
        {
            // Casting like this is not nice. But to keep the examples C# and VB, no shared classes
            // For VB
            ((VBAPICalls.Logic.Resource)currentResource).Initials = this.currentInitialsTextBox.Text;
            ((VBAPICalls.Logic.Resource)currentResource).Phone1 = this.currentPhoneTextBox.Text;
            ((VBAPICalls.Logic.Resource)currentResource).Name = this.currentNameTextBox.Text;
            var result = await ApiLogic.SaveUser((VBAPICalls.Logic.Resource)currentResource);
            /*
            // For C#
            ((CSharpAPICalls.Logic.Resource)currentResource).Initials = this.currentInitialsTextBox.Text;
            ((CSharpAPICalls.Logic.Resource)currentResource).Phone = this.currentPhoneTextBox.Text;
            ((CSharpAPICalls.Logic.Resource)currentResource).Name = this.currentNameTextBox.Text;
            var result = await ApiLogic.SaveUserRequest((CSharpAPICalls.Logic.Resource)currentResource);
            */


        }

        private async void getEmployeesButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await ApiLogic.Employee();

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
