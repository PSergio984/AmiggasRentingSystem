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
    public partial class Payments : Form
    {

        private static Payments instance;
        public static Payments Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Payments();
                }
                return instance;
            }
        }
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {

        }

        private void navigationControl1_Load(object sender, EventArgs e)
        {

        }


        private void Payments_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Payments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
