using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


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
        public string Login;
        public string Password;
        public DataRow[] row;
        static public string value;
        static public int value2;
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
                SqlCommand sqlCommand = new SqlCommand($"select Code_client, Email, Password from Auth_client$ where Email='{@Login}' and Password='{Password}'", connection);
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(table);
                value2 = 1;
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand($"select Id_user, Login, Password from Auth_user$ where Login='{@Login}' and Password='{Password}'", connection);
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(table);
                value2 = 0;

            }

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Пользователь успешно авторизован!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                row = table.Select();
                value = row[0][0].ToString();
                Second s = new Second();
                s.Show();
            }
            else
            {
                MessageBox.Show("Пользователь не авторизован!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
    }
}
