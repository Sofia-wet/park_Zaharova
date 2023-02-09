using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml;


namespace park
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void VisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (VisibleCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }
        static public string Login;
        static public string Password;
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["parkConnectionString"].ConnectionString);

        private void AutharizationButton_Click(object sender, EventArgs e)
        {
            Login = LoginTextBox.Text;
            Password = PasswordTextBox.Text;
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            if (ClientCheckBox.Checked)
            {
                SqlCommand sqlCommand = new SqlCommand($"select Email, Password from Auth_client$ where Email='{@Login}' and Password='{Password}'", connection);
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(table);

            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand($"select Login, Password from Auth_user$ where Login='{@Login}' and Password='{Password}'", connection);
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(table);

            }

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Пользователь успешно авторизован!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Second s = new Second();
                s.Show();
            }
            else
            {
                MessageBox.Show("Пользователь не авторизован!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void First_Load(object sender, EventArgs e)
        {

        }

        

        private void ClientCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
