using System;
using System.Windows.Forms;

namespace park
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkDataSet._Order_". При необходимости она может быть перемещена или удалена.
            this.order_TableAdapter.Fill(this.parkDataSet._Order_);

        }
    }
}
