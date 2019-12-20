using System;
using System.Windows.Forms;

namespace CarService
{
    public partial class UserCreateForm : Form
    {
        private readonly User user;

        public UserCreateForm(ref User user, bool editMode = false)
        {
            InitializeComponent();

            // инициализируем необходимые переменные класса
            this.user = user;

            // если режим редактирования клиента
            if (!editMode) return;

            // читаем информацию из класса клиента в текстбоксы
            firstName.Text = this.user.FirstName;
            middleName.Text = this.user.MiddleName;
            lastName.Text = this.user.LastName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // если текстбоксы не заполнены
            if (is_textboxes_empty())
                return;

            // заполняем информацию в классе клиента из текстбоксов
            user.FirstName = firstName.Text;
            user.MiddleName = middleName.Text;
            user.LastName = lastName.Text;

            // закрываем диалог
            Close();
        }

        private bool is_textboxes_empty()
        {
            if (string.IsNullOrEmpty(firstName.Text))
            {
                MessageBox.Show("Поле \"Имя\" должно быть заполнено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (string.IsNullOrEmpty(middleName.Text))
            {
                MessageBox.Show("Поле \"Отчество\" должно быть заполнено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (string.IsNullOrEmpty(lastName.Text))
            {
                MessageBox.Show("Поле \"Фамилия\" должно быть заполнено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }
    }
}
