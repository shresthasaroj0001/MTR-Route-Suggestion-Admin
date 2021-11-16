using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Helper;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        private WebApiConnection apiConnection;
        public Login()
        {
            InitializeComponent();
            btn_register.Enabled = false;
            this.apiConnection = new WebApiConnection();
        }

        private async void btn_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_username.Text) || string.IsNullOrEmpty(textBox_username.Text) || string.IsNullOrEmpty(textBox_username.Text))
            {
                MessageBox.Show("Username and password is required");
            }
            if (textBox_password.Text != textBox_confirm_password.Text)
                MessageBox.Show("Please confirm password");

            //block btn
            btn_register.Text = "Processing request";
            btn_register.Enabled = false;

            try
            {
                // Make an API call and receive HttpResponseMessage
                var response = await apiConnection._client.GetAsync(string.Format("user/register?Username={0}&Password={1}", textBox_username.Text, textBox_password.Text));

                if (response.IsSuccessStatusCode)
                {
                    // Convert the HttpResponseMessage to string
                    var resultArray = await response.Content.ReadAsStringAsync();

                    // Deserialize the Json string into type using JsonConvert
                    GenericResponseObject<string> genericResponseObject = JsonConvert.DeserializeObject<GenericResponseObject<string>>(resultArray);

                    if (genericResponseObject.IsSuccess)
                    {
                        MTR frm = new MTR();
                        this.Hide();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show(genericResponseObject.Message);
                        textBox_password.Clear();
                        textBox_confirm_password.Clear();
                        textBox_password.Focus();
                    }
                }
                else
                    MessageBox.Show("Error making request");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching data");
            }
            finally
            {
                btn_register.Text = "Register";
                btn_register.Enabled = true;
            }

        }

        private void textBox_confirm_password_TextChanged(object sender, EventArgs e)
        {
            label_message.Text = "";
            btn_register.Enabled = false;
            if (textBox_confirm_password.Text != textBox_password.Text)
            {
                label_message.Text = "Please verify password";
            }
            else
                btn_register.Enabled = true;
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            label_message.Text = "";
            btn_register.Enabled = false;
            if (textBox_confirm_password.Text != textBox_password.Text)
            {
                label_message.Text = "Please verify password";
            }
            else
                btn_register.Enabled = true;
        }
    }
}
