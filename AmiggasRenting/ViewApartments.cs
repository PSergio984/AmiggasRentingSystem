using System;
using System.Data;
using System.Windows.Forms;

namespace AmiggasRenting
{
    public partial class ViewApartments : Form
    {
        private static ViewApartments? instance;
        private DatabaseManager dbManager;

        public static ViewApartments Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new ViewApartments();
                }
                return instance;
            }
        }

        public ViewApartments()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            this.Activated += new EventHandler(ViewApartments_Activated);
        }

        private void ViewApartments_Load(object sender, EventArgs e)
        {
            LoadApartments();//load apartments 
        }

        private void ViewApartments_Activated(object sender, EventArgs e)
        {
            LoadApartments();
        }

        private void LoadApartments()
        {
            string query = @"
            SELECT 
                Units.UnitID AS ApartmentNo, 
                COALESCE(Tenants.Name, 'NULL') AS TenantName, 
                COALESCE(Tenants.ContactNumber, 'NULL') AS ContactNumber,
                Units.Size AS Size,
                CASE WHEN Units.TenantID IS NULL THEN 'Available' ELSE 'Occupied' END AS Availability,
                Units.MonthlyRent AS MonthlyRent
            FROM Units
            LEFT JOIN Tenants ON Units.TenantID = Tenants.TenantID";

            try
            {
                using (DataTable apartmentsTable = dbManager.ExecuteQuery(query))
                {
                    dataApartments.DataSource = apartmentsTable;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading apartments data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataApartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewApartments_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingHelper.HandleFormClosing(e);
        }
    }
}
