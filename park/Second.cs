using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static park.First;

namespace park
{
    public partial class Second : Form
    {
        public Second()
        {
            InitializeComponent();
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.Show();
            this.Close();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Order order = new Order(); 
            order.Show();
            this.Close();
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["parkConnectionString"].ConnectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public DataRow[] row;
        string role;

        private void Second_Load(object sender, EventArgs e)
        {
            connection.Open();
            if (value2 == 0)
            {
                SqlCommand sqlCommand = new SqlCommand($"select Fio_user, id_role from User$ where Id_user='{@value}'", connection);
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(table);
                row = table.Select();
                FioLlabel.Text = "ФИО: " + row[0][0].ToString();
                role = row[0][1].ToString();
                sqlCommand = new SqlCommand($"selext Name_role from Role$ where Id_role='{@role}'", connection);
                adapter.Fill(table);
                row = table.Select();
                RoleLabel.Text = "Роль: " + row[0][0].ToString();
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand($"select Fio_client, Code_client from Client$ where Code_client='{@value}'", connection);
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(table);
                row = table.Select();
                FioLlabel.Text = "ФИО: " + row[0][0].ToString();
                RoleLabel.Text = "Код: " + row[0][1].ToString();
                ServiceButton.Enabled = false;
                OrderButton.Enabled = false;
            }
        }
    }
}
