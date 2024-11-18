using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmiggasRenting
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnAddTenants_Click(object sender, EventArgs e)
        {
            AddTenants addTenants = new AddTenants();
            addTenants.Show();
            this.Hide();
        }

        private void btnViewApartments_Click(object sender, EventArgs e)
        {
            ViewApartments viewApartments = new ViewApartments();
            viewApartments.Show();
            this.Hide();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.Show();
            this.Hide();
        }
    }
}
