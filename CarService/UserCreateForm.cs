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

            // инициализируем класс клиента
            user = new User();

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
            // инициализируем массив из текстбоксов на форме и обозначения текстбоксов
            object[] textboxes = new object[] {lastName, firstName, middleName};
            string[] messages = {"\"Фамилия\"", "\"Имя\"", "\"Отчество\""};

            for (var i = 0; i < textboxes.Length; ++i)
            {
                var tbox = textboxes[i] as TextBox;
                if (!string.IsNullOrEmpty(tbox.Text))
                    continue;

                // выводим сообщение
                MessageBox.Show("Поле " + messages[i] + " должно быть заполнено!", "Внимание!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                // фокусируемся на пустом текстбоксе
                tbox.Focus();

                return true;
            }

            return false;
        }
    }
}
