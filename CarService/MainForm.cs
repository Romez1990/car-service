using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text;
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
            // отключаем элементы управления
            refreshUsersButton.Enabled = addUserButton.Enabled = false;
            usersListBox.Enabled = false;

            // получаем список клиентов с сервера
            await FetchUsersAsync();

            // включаем элементы управления
            refreshUsersButton.Enabled = addUserButton.Enabled = true;
            usersListBox.Enabled = true;
        }

        private async void addUserButton_Click(object sender, EventArgs e)
        {
            // отключаем элементы управления
            addUserButton.Enabled = refreshUsersButton.Enabled = false;
            usersListBox.Enabled = false;

            // вызываем диалог для заполнения нового клиента
            User user = null;
            using (var form = new UserCreateForm(ref user))
            {
                form.ShowDialog();
            }

            // отправляем нового клиента на сервер
            await CreateUserAsync(user);

            // получаем список клиентов с сервера
            await FetchUsersAsync();

            // включаем элементы управления
            addUserButton.Enabled = refreshUsersButton.Enabled = true;
            usersListBox.Enabled = true;
        }

        private async Task CreateUserAsync(User user)
        {
            string serverUrl = ConfigurationManager.AppSettings["serverUrl"];
            string json = JsonConvert.SerializeObject(user, jsonSerializerSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await httpClient.PostAsync($"{serverUrl}/api/user/", content);
        }
    }
}
