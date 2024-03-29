using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarService.Attributes;
using CarService.Structures;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CarService.Forms
{
    public partial class MainForm : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        private readonly JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            }
        };

        public MainForm()
        {
            InitializeComponent();
            _ = FetchUsersAsync();
            _ = FetchServicesAsync();
        }

        private async void refreshUsersButton_Click(object sender, EventArgs e)
        {
            // отключаем элементы управления
            refreshUsersButton.Enabled = addUserButton.Enabled = deleteUserButton.Enabled = usersListBox.Enabled = false;

            // получаем список клиентов с сервера
            await FetchUsersAsync();

            // включаем элементы управления
            refreshUsersButton.Enabled = addUserButton.Enabled = deleteUserButton.Enabled = usersListBox.Enabled = true;
        }

        private async void refreshServicesButton_Click(object sender, EventArgs e)
        {
            // отключаем элементы управления
            refreshServicesButton.Enabled = addServiceButton.Enabled = deleteServiceButton.Enabled = dataGridView1.Enabled = false;

            // получаем список клиентов с сервера
            await FetchServicesAsync();

            // включаем элементы управления
            refreshServicesButton.Enabled = addServiceButton.Enabled = deleteServiceButton.Enabled = dataGridView1.Enabled = true;
        }

        private async void addUserButton_Click(object sender, EventArgs e)
        {
            // отключаем элементы управления
            addUserButton.Enabled = refreshUsersButton.Enabled = deleteUserButton.Enabled = usersListBox.Enabled = false;

            // вызываем диалог для заполнения нового клиента
            User user = new User();
            using (var form = new UserCreateForm(ref user))
            {
                form.ShowDialog();
            }

            // отправляем нового клиента на сервер
            await CreateUserAsync(user);

            // получаем список клиентов с сервера
            await FetchUsersAsync();

            // включаем элементы управления
            addUserButton.Enabled = refreshUsersButton.Enabled = deleteUserButton.Enabled = usersListBox.Enabled = true;
        }

        private async void addServiceButton_Click(object sender, EventArgs e)
        {
            User selected = (User)usersListBox.SelectedItem;

            Service service = null;
            using (var form = new ServiceCreateForm(ref service, selected))
            {
                form.ShowDialog();
            }

            await CreateServicesAsync(service);
            await FetchServicesAsync();
        }

        private async void usersListBox_DoubleClick(object sender, EventArgs e)
        {
            User user = (User)usersListBox.SelectedItem;

            using (var form = new UserCreateForm(ref user, true))
            {
                form.ShowDialog();
            }

            // отправляем нового клиента на сервер
            await UpdateUserAsync(user);

            // получаем список клиентов с сервера
            await FetchUsersAsync();
        }

        private async void deleteUserButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Вы дейсвительно хотите удалить клиента?",
                "Подтверждение удаления клиента", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes) return;

            User user = (User)usersListBox.SelectedItem;
            await DeleteUserAsync(user);
            await FetchUsersAsync();
            await FetchServicesAsync();
        }

        private async void deleteServiceButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строку для удаления");
                return;
            }

            DialogResult confirmResult = MessageBox.Show("Вы дейсвительно хотите удалить услугу?",
                "Подтверждение удаления услуги", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;

            foreach (DataGridViewRow dataGridViewRow in dataGridView1.SelectedRows)
            {
                ServiceDetail serviceDetail = (ServiceDetail)dataGridViewRow.DataBoundItem;
                await DeleteServiceAsync(serviceDetail);
            }

            await FetchServicesAsync();
        }

        private async Task FetchUsersAsync()
        {
            string serverUrl = ConfigurationManager.AppSettings["serverUrl"];
            string json = await httpClient.GetStringAsync($"{serverUrl}/api/users/");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json, jsonSerializerSettings);
            usersListBox.DataSource = users;
        }

        protected async Task FetchServicesAsync()
        {
            string serverUrl = ConfigurationManager.AppSettings["serverUrl"];
            string json = await httpClient.GetStringAsync($"{serverUrl}/api/services/");
            List<ServiceDetail> services = JsonConvert.DeserializeObject<List<ServiceDetail>>(json, jsonSerializerSettings);
            dataGridView1.DataSource = services;
            SetColumnsHeaderText();
        }

        private void SetColumnsHeaderText()
        {
            PropertyInfo[] propertiesInfo = typeof(ServiceDetail).GetProperties();
            for (var i = 0; i < propertiesInfo.Length; i++)
            {
                SetColumnHeaderText(propertiesInfo[i], i);
            }
        }

        private void SetColumnHeaderText(PropertyInfo propertyInfo, int i)
        {
            object[] attributes = propertyInfo.GetCustomAttributes(true);
            foreach (object attribute in attributes)
            {
                if (!(attribute is VerboseNameAttribute verboseName)) continue;
                dataGridView1.Columns[i].HeaderText = verboseName.Text;
            }
        }

        private async Task CreateUserAsync(User user)
        {
            string serverUrl = ConfigurationManager.AppSettings["serverUrl"];
            string json = JsonConvert.SerializeObject(user, jsonSerializerSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await httpClient.PostAsync($"{serverUrl}/api/user/", content);
        }

        protected async Task CreateServicesAsync(Service service)
        {
            string serverUrl = ConfigurationManager.AppSettings["serverUrl"];
            string content = await Task.Run(() => JsonConvert.SerializeObject(service, jsonSerializerSettings));
            var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
            await httpClient.PostAsync($"{serverUrl}/api/service/", httpContent);
        }

        private async Task UpdateUserAsync(User user)
        {
            string serverUrl = ConfigurationManager.AppSettings["serverUrl"];
            string json = JsonConvert.SerializeObject(user, jsonSerializerSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await httpClient.PutAsync($"{serverUrl}/api/user/{user.Id}", content);
        }

        private async Task DeleteUserAsync(User user)
        {
            string serverUrl = ConfigurationManager.AppSettings["serverUrl"];
            await httpClient.DeleteAsync($"{serverUrl}/api/user/{user.Id}");
        }

        private async Task DeleteServiceAsync(ServiceDetail service)
        {
            string serverUrl = ConfigurationManager.AppSettings["serverUrl"];
            await httpClient.DeleteAsync($"{serverUrl}/api/service/{service.Id}");
        }
    }
}
