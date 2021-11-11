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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly string BASEURL;
        public Form1()
        {
            InitializeComponent();
            this.BASEURL = ConfigurationManager.AppSettings["WebApiURL"];
            if(this.BASEURL == "")
            {
                MessageBox.Show("Invalid WEB URL provided in AppConfig.");
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text != "" && txt_password.Text !="")
            {
                Dashboard dt = new Dashboard();
                this.Hide();

                dt.Show();

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
    }
}
