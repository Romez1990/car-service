using System;
using System.Windows.Forms;

namespace CarService
{
    public partial class UserCreateForm : Form
    {
        private User m_user = null;
        private bool m_edit_mode = false;

        public UserCreateForm(ref User user, bool edit_mode = false)
        {
            InitializeComponent();

            // инициализируем необходимые переменные класса
            m_user = user;
            m_edit_mode = edit_mode;

            // если режим редактирования клиента
            if (m_edit_mode)
            {
                // читаем информацию из класса клиента в текстбоксы
                firstName.Text = m_user.FirstName;
                middleName.Text = m_user.MiddleName;
                lastName.Text = m_user.LastName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // если текстбоксы не заполнены
            if (is_textboxes_empty())
                return;

            // заполняем информацию в классе клиента из текстбоксов
            m_user.FirstName = firstName.Text;
            m_user.MiddleName = middleName.Text;
            m_user.LastName = lastName.Text;

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
