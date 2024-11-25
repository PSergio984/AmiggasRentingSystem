using System;
using System.Windows.Forms;

namespace AmiggasRenting
{
    public partial class HomePage : Form
    {
        private static HomePage instance;
        public static HomePage Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new HomePage();
                }
                return instance;
            }
        }

        public HomePage()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Handle dashboard button click
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // Initialize any data or settings needed when the form loads
        }

     
        private void navigationControl1_Load(object sender, EventArgs e)
        {
            // Handle navigation control load event
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
