using System;
using System.Windows.Forms;

namespace CarService
{
    public partial class ServiceCreateForm : Form
    {
        private Service m_service   = null;
        private bool    m_edit_mode = false;

        public ServiceCreateForm(ref Service service, User user, bool edit_mode = false)
        {
            InitializeComponent();

            // инициализируем класс услуги
            service = new Service();
            service.User = user.Id;

            // инициализируем необходимые переменные класса
            m_service   = service;
            m_edit_mode = edit_mode;

            // если режим редактирования услуги
            if (m_edit_mode)
            {
                // читаем информацию из класса услуги в текстбоксы
                costInfo.Text = Convert.ToString(m_service.Cost);
                descriptionInfo.Text = m_service.Description;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // если текстбоксы не заполнены
            if (is_textboxes_empty())
                return;

            // заполняем информацию в классе услуги из текстбоксов
            m_service.Cost        = Convert.ToSingle(costInfo.Text);
            m_service.Description = descriptionInfo.Text;

            // закрываем диалог
            Close();
        }

        private bool is_textboxes_empty()
        {
            if (string.IsNullOrEmpty(costInfo.Text))
            {
                MessageBox.Show("Поле \"Цена\" должно быть заполнено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (string.IsNullOrEmpty(descriptionInfo.Text))
            {
                MessageBox.Show("Поле \"Услуга\" должно быть заполнено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void costInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // если введенный символ является символом управления и введен символ не числовой и введенный символ не является запятой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                // пропускаем
                e.Handled = true;
            }

            // если введенный символ запятая и запятая уже есть среди введенных данных
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                // пропускаем
                e.Handled = true;
            }
        }
    }
}
