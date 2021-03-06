﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reczna_Myjnia_Samochodowa
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_cars_Click(object sender, EventArgs e)
        {
            Form_Cars c = new Form_Cars();
            c.Show();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            Form_Customer cust = new Form_Customer();
            cust.Show();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            Form_Orders ord = new Form_Orders();
            ord.Show();
        }

        private void btn_Employers_Click(object sender, EventArgs e)
        {
            Form_Employers emp = new Form_Employers();
            emp.Show();
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
            Form_Services serv = new Form_Services();
            serv.Show();
        }

        private void btn_faults_Click(object sender, EventArgs e)
        {
            Form_Faults fau = new Form_Faults();
            fau.Show();
        }
    }
}
