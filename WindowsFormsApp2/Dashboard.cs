using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Helper;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2
{
    public partial class Dashboard : Form
    {
        private Station _tempstation;
        private StationLinkViewModel _stationLinkViewModel;
        //private StationLink _tempstationLink;
        private WebApiConnection apiConnection;
        private List<StationLink> _list_StationLinks;
        private int pageSize = 0;

        public Dashboard()
        {
            InitializeComponent();
            _tempstation = new Station();
            _stationLinkViewModel = new StationLinkViewModel();
            //_tempstationLink = new StationLink();
            apiConnection = new WebApiConnection();
            lbl_loading.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            // panel_searchHistory.Visible = false;

            datePicker_duration.Format = DateTimePickerFormat.Custom;
            datePicker_duration.CustomFormat = "HH:mm"; // Only use hours and minutes
            datePicker_duration.ShowUpDown = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //station
        private async void fetch_stationData()
        {
            menuStrip1.Enabled = false;
            lbl_loading.Visible = true;

            try
            {
                //apiConnection._client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                apiConnection._client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Program.webToken);

                // Make an API call and receive HttpResponseMessage
                var response = await apiConnection._client.GetAsync("station");

                // Convert the HttpResponseMessage to string
                var resultArray = await response.Content.ReadAsStringAsync();

                // Deserialize the Json string into type using JsonConvert
                List<Station> genericResponseObject = JsonConvert.DeserializeObject<List<Station>>(resultArray);
                dataGridView1.DataSource = genericResponseObject;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Update();
                dataGridView1.Refresh();
                panel1.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error while fetching data");
            }
            finally
            {
                menuStrip1.Enabled = true;
                lbl_loading.Visible = false;
            }
        }

        private void stationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;

            btn_update.Enabled = false;
            fetch_stationData();

            panel1.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_update.Enabled = true;

            if (e.RowIndex >= 0)
            {
                try
                {
                    var selectedStation = dataGridView1.SelectedRows[0].DataBoundItem as Station;
                    lbl_stationName.Text = selectedStation.Name;
                    txt_description.Text = selectedStation.Description;

                    _tempstation.Id = selectedStation.Id;
                    _tempstation.Name = selectedStation.Name;

                    //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    //lbl_stationName.Text = row.Cells["Name"].Value.ToString();
                    //txt_description.Text = row.Cells["Description"].Value.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while fetching data from data grid");
                    btn_update.Enabled = false;
                }
                _tempstation.Name = lbl_stationName.Text;
            }

        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            string tempDescription = txt_description.Text;
            if (string.IsNullOrEmpty(tempDescription))
            {
                MessageBox.Show("Description cannot be empty");
                txt_description.Focus();
                return;
            }

            btn_update.Text = "Please wait...";
            btn_update.Enabled = false;
            try
            {
                _tempstation.Description = tempDescription;
                var json = JsonConvert.SerializeObject(_tempstation, Formatting.Indented);
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                apiConnection._client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Program.webToken);

                // Make an API call and receive HttpResponseMessage
                var response = await apiConnection._client.PostAsync("station/update", stringContent);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Update Successfull");
                    fetch_stationData();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error while fetching data");
            }
            finally
            {
                btn_update.Text = "Update";

                menuStrip1.Enabled = true;
                lbl_loading.Visible = false;
            }
        }

        //station link
        private async void fetch_stationlink()
        {
            menuStrip1.Enabled = false;
            lbl_loading.Visible = true;

            try
            {
                // Make an API call and receive HttpResponseMessage
                var response = await apiConnection._client.GetAsync("routesearch/GetAllRoute");

                if (response.IsSuccessStatusCode)
                {
                    // Convert the HttpResponseMessage to string
                    var resultArray = await response.Content.ReadAsStringAsync();

                    // Deserialize the Json string into type using JsonConvert
                    var list_Stationlinks = JsonConvert.DeserializeObject<GenericResponseObject<List<StationLink>>>(resultArray);
                    _list_StationLinks = new List<StationLink>();
                    _list_StationLinks = list_Stationlinks.Data;
                    var dataSource = list_Stationlinks.Data
                        .Select(o => new StationLinkViewModel()
                        {
                            From = o.FromStation.Name,
                            FromId = o.FromStationId,
                            To = o.ToStation.Name,
                            ToId = o.ToStationId,
                            Fare = o.Fare,
                            Duration = o.Duration
                        }).ToList();

                    dataGridView_StationLink.DataSource = dataSource;
                    dataGridView_StationLink.Columns["FromId"].Visible = false;
                    dataGridView_StationLink.Columns["ToId"].Visible = false;
                    dataGridView_StationLink.Update();
                    dataGridView_StationLink.Refresh();
                }
                else
                    MessageBox.Show("Error in HTTP GET");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching data");
            }
            finally
            {
                menuStrip1.Enabled = true;
                lbl_loading.Visible = false;
            }
        }

        private void stationLinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;

            btn_update_stationlink.Enabled = false;
            fetch_stationlink();

            panel2.Visible = true;
            reset_panel2Form();
        }

        private void dataGridView_StationLink_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    var selectedStation = dataGridView_StationLink.SelectedRows[0].DataBoundItem as StationLinkViewModel;
                    lbl_fromStation.Text = selectedStation.From;
                    lbl_toStation.Text = selectedStation.To;
                    textBox_fare.Text = string.Format(CultureInfo.CreateSpecificCulture("en-CA"), "{0:C2}", selectedStation.Fare);
                    datePicker_duration.Value = DateTime.Now.Date.AddMilliseconds(selectedStation.Duration.TotalMilliseconds);
                    _stationLinkViewModel = selectedStation;
                    btn_update_stationlink.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while fetching data from data grid");
                }
            }
        }

        private void reset_panel2Form()
        {
            textBox_fare.Text = "";
            lbl_fromStation.Text = "";
            lbl_toStation.Text = "";
            btn_update_stationlink.Enabled = false;

        }

        private async void btn_update_stationlink_Click(object sender, EventArgs e)
        {
            var valueFromFare = textBox_fare.Text;
            //var Timevalue = datePicker_duration.Value.ToString("HH:mm");
            DateTime dt = datePicker_duration.Value;
            //TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
            // OR
            TimeSpan sts = dt.TimeOfDay;
            if (string.IsNullOrEmpty(valueFromFare))
            {
                MessageBox.Show("Please check the form");
                textBox_fare.Focus();
                return;
            }

            btn_update_stationlink.Text = "Please wait...";
            btn_update_stationlink.Enabled = false;
            try
            {
                StationLink stationObj = _list_StationLinks.Find(x => x.FromStationId == _stationLinkViewModel.FromId && x.ToStationId == _stationLinkViewModel.ToId);
                stationObj.Duration = sts;
                stationObj.Fare = float.Parse(valueFromFare.Replace("$", ""), CultureInfo.InvariantCulture.NumberFormat);

                var json = JsonConvert.SerializeObject(stationObj, Formatting.Indented);
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                apiConnection._client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Program.webToken);

                // Make an API call and receive HttpResponseMessage
                var response = await apiConnection._client.PostAsync("stationlink/update", stringContent);

                if (response.IsSuccessStatusCode)
                {
                    reset_panel2Form();
                    MessageBox.Show("Update Successfull");
                    fetch_stationlink();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error while fetching data");
            }
            finally
            {
                btn_update_stationlink.Text = "Update";

                menuStrip1.Enabled = true;
                lbl_loading.Visible = false;
            }
        }

        private void textBox_fare_TextChanged(object sender, EventArgs e)
        {
            //Remove previous formatting, or the decimal check will fail including leading zeros
            string value = textBox_fare.Text.Replace(",", "")
                .Replace("$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                textBox_fare.TextChanged -= textBox_fare_TextChanged;
                //Format the text as currency
                textBox_fare.Text = string.Format(CultureInfo.CreateSpecificCulture("en-CA"), "{0:C2}", ul);
                textBox_fare.TextChanged += textBox_fare_TextChanged;
                textBox_fare.Select(textBox_fare.Text.Length, 0);
            }
            bool goodToGo = TextisValid(textBox_fare.Text);
            btn_update_stationlink.Enabled = goodToGo;
            if (!goodToGo)
            {
                textBox_fare.Text = "$0.00";
                textBox_fare.Select(textBox_fare.Text.Length, 0);
            }
        }

        private bool TextisValid(string text)
        {
            Regex money = new Regex(@"^\$(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
            return money.IsMatch(text);
        }

        //search History
        private async void fetch_stationHistory()
        {
            menuStrip1.Enabled = false;
            lbl_loading.Visible = true;
            lbl_page.Text = "Loading...";

            btn_next.Enabled = false;
            btn_preview.Enabled = false;
            try
            {
                apiConnection._client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Program.webToken);

                // Make an API call and receive HttpResponseMessage
                var response = await apiConnection._client.GetAsync(string.Format("routesearch/Get-Route-History?pageSize={0}", pageSize));

                if (response.IsSuccessStatusCode)
                {
                    // Convert the HttpResponseMessage to string
                    var resultArray = await response.Content.ReadAsStringAsync();

                    // Deserialize the Json string into type using JsonConvert
                    var list_Stationlinks = JsonConvert.DeserializeObject<GenericResponseObject<List<RouteSearch>>>(resultArray);

                    var newDataModel = list_Stationlinks.Data.Select(x => new
                    {
                        FromStation = x.FromStation.Name,
                        ToStation = x.ToStation.Name,
                        Date = x.DateSearched
                    }).ToList();

                    dataGridView2.DataSource = newDataModel;
                    dataGridView2.Update();
                    dataGridView2.Refresh();
                    lbl_page.Text = list_Stationlinks.Message;
                    if (list_Stationlinks.PageSize > 0)
                        btn_next.Enabled = true;
                    if (pageSize > 0)
                        btn_preview.Enabled = true;
                }
                else
                    MessageBox.Show("Error in HTTP GET");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching data");
            }
            finally
            {
                menuStrip1.Enabled = true;
                lbl_loading.Visible = false;
            }
        }

        private void searchHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            pageSize = 0;
            panel3.Show();
            fetch_stationHistory();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.pageSize++;
            fetch_stationHistory();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            this.pageSize--;
            fetch_stationHistory();

        }
    }
}

