using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Helper;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2
{
    public partial class MTR : Form
    {
        private readonly string BASEURL;

        public MTR()
        {
            InitializeComponent();
            this.BASEURL = ConfigurationManager.AppSettings["WebApiURL"];
            if(this.BASEURL == "")
            {
                MessageBox.Show("Invalid WEB URL provided in AppConfig.");
            }
            else
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Btn_login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(BASEURL))
            {
                MessageBox.Show("Sorry, cannot access API");
                return;
            }

            if (txt_username.Text != "" && txt_password.Text !="")
            {
                //block btn
                Btn_login.Text = "Processing request";
                Btn_login.Enabled = false;

                WebApiConnection apiConnection = new WebApiConnection();
                try
                {
                    // Make an API call and receive HttpResponseMessage
                    var response = await apiConnection._client.GetAsync(string.Format("Token/Authenticate?username={0}&password={1}", txt_username.Text, txt_password.Text));

                    // Convert the HttpResponseMessage to string
                    var resultArray = await response.Content.ReadAsStringAsync();

                    // Deserialize the Json string into type using JsonConvert
                    GenericResponseObject<string> genericResponseObject = JsonConvert.DeserializeObject<GenericResponseObject<string>>(resultArray);

                    if(genericResponseObject.IsSuccess)
                    {
                        Program.webToken = genericResponseObject.Data;
                        Dashboard dt = new Dashboard();
                        this.Hide();
                        dt.Show();
                    }
                    else
                    {
                        MessageBox.Show(genericResponseObject.Message);
                        txt_username.Clear();
                        txt_password.Clear();
                        txt_username.Focus();
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Error in HTTP Request");
                    this.Dispose();
                    this.Close();
                }
                finally
                {
                    Btn_login.Text = "Login";
                    Btn_login.Enabled = true;
                }


                //var loginInfo = responseMessage.Content.ReadAsAsync<IE<Employee>>().Result;
                //JsonConvert.DeserializeObject < List < Class >>> (json);
                // dataGridView.Datasource = emp

            }
            else
            {
                MessageBox.Show("The username and password cannot be empty");
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
