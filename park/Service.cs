using System;
using System.Windows.Forms;

namespace park
{
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkDataSet._Service_". При необходимости она может быть перемещена или удалена.
            this.service_TableAdapter.Fill(this.parkDataSet._Service_);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Service_Add s = new Service_Add();
            s.Show();
            this.Close();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            serviceBindingSource.RemoveCurrent();
            this.service_TableAdapter.Update(this.parkDataSet._Service_);
        }
    }
}
