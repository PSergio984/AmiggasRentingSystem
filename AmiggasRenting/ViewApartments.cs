using System;
using System.Windows.Forms;

namespace AmiggasRenting
{
    public partial class ViewApartments : Form
    {
        private static ViewApartments? instance;
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewApartments_Load(object sender, EventArgs e)
        {

        }


       
    }
}
