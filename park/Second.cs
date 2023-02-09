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
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Order order = new Order(); 
            order.Show();
        }

        private void Second_Load(object sender, EventArgs e)
        {

        }
    }
}
