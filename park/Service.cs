using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
