using System;
using System.Windows.Forms;

namespace AmiggasRenting
{

    public partial class HomePage : Form
    {
        DatabaseManager dbManager = new DatabaseManager();
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

        private void HomePage_Activated(object sender, EventArgs e)
        {
            UpdateStatistics();// Load payment data when the form is activated.
        }
        private void UpdateStatistics()
        {
            lblAvlApartment.Text = GetAvailableApartments().ToString();
            lblTenantCount.Text = GetTenantCount().ToString();
            lblOccApartments.Text = GetOccupiedApartments().ToString();
        }

        private int GetAvailableApartments()
        {
            string query = "SELECT COUNT(*) FROM Units WHERE availability = 1";
            return Convert.ToInt32(dbManager.ExecuteScalar(query));
        }

        private int GetTenantCount()
        {
            string query = "SELECT COUNT(*) FROM Tenants";
            return Convert.ToInt32(dbManager.ExecuteScalar(query));
        }

        private int GetOccupiedApartments()
        {
            string query = "SELECT COUNT(*) FROM Units WHERE availability = 0";
            return Convert.ToInt32(dbManager.ExecuteScalar(query));
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Handle dashboard button click
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            UpdateStatistics();
        }



        private void navigationControl1_Load(object sender, EventArgs e)
        {
            // Handle navigation control load event
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingHelper.HandleFormClosing(e);
        }

        private void lblOccApartments_Click(object sender, EventArgs e)
        {

        }

        private void lblOccupied_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
