﻿using System;
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
    public partial class Service_Red : Form
    {
        public Service_Red()
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

        }

        private void id_serviceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
