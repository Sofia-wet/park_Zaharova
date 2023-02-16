using System;
using System.Windows.Forms;

namespace park
{
    public partial class Service_Add : Form
    {
        public Service_Add()
        {
            InitializeComponent();
        }

        private void service_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.service_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parkDataSet);

        }

        private void Service_Red_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkDataSet._Service_". При необходимости она может быть перемещена или удалена.
            this.service_TableAdapter.Fill(this.parkDataSet._Service_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkDataSet._Service_". При необходимости она может быть перемещена или удалена.
            this.service_TableAdapter.Fill(this.parkDataSet._Service_);
            service_BindingSource.AddNew();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.service_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parkDataSet);
            MessageBox.Show("Запись сохранена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Service s = new Service();
            s.Show();
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
