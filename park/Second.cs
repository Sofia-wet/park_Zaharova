﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static park.First;

namespace park
{
    public partial class Second : Form
    {
        String test;
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
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["parkConnectionString"].ConnectionString);
        private void Second_Load(object sender, EventArgs e)
        {
            test = First.Login;

        }
    }
}
