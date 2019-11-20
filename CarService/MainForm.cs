using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CarService
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _ = FetchUsersAsync();
        }

        private readonly HttpClient httpClient = new HttpClient();

        private readonly JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            }
        };

        private async Task FetchUsersAsync()
        {
            string serverUrl = ConfigurationManager.AppSettings["serverUrl"];
            string json = await httpClient.GetStringAsync($"{serverUrl}/api/users/");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json, jsonSerializerSettings);
            usersListBox.DataSource = users;
        }

        private async void refreshUsersButton_Click(object sender, EventArgs e)
        {
            refreshUsersButton.Enabled = false;
            usersListBox.Enabled = false;
            await FetchUsersAsync();
            refreshUsersButton.Enabled = true;
            usersListBox.Enabled = true;
        }
    }
}
