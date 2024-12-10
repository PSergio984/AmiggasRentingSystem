using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AmiggasRenting
{
    public partial class ModalReceipt : Form
    {
        private int i = 0;
        public ModalReceipt()
        {
            InitializeComponent();
            // Initialize the timer
            ModalEffect_Timer.Interval = 10; // Set the interval to 20 milliseconds
            ModalEffect_Timer.Tick += new EventHandler(ModalEffect_Timer_Tick);

            // Initialize the cancel animation timer
            ModalCancel_Timer = new System.Windows.Forms.Timer();
            ModalCancel_Timer.Interval = 10; // 10ms interval for smooth animation
            ModalCancel_Timer.Tick += new EventHandler(ModalCancel_Timer_Tick);
        }

        private void lblTenantName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ModalReceipt_Load(object sender, EventArgs e)
        {
            dataReceipt.GridColor = Color.Yellow;
            dataReceipt.HeaderBackColor = Color.Gold;
            dataReceipt.HeaderForeColor = Color.Black;

            dataReceipt.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dataReceipt.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dataReceipt.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Gold;
            dataReceipt.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            dataReceipt.RowsDefaultCellStyle.SelectionBackColor = Color.Gold;
            dataReceipt.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            i = Payments.parentY + 50;

            // Set the initial location of the form
            this.Location = new Point(Payments.parentX + 220, Payments.parentY + 160);
            Opacity = 0; // Set initial opacity to 0 for fade-in effect

            // Start the timer for the animation effect
            ModalEffect_Timer.Start();
        }
        private void ModalEffect_Timer_Tick(object sender, EventArgs e)
        {
            // Incrementally increase opacity
            if (Opacity < 1)
            {
                Opacity += 0.03;
            }

            // Incrementally move the form upwards
            if (this.Location.Y > Payments.parentY)
            {
                this.Location = new Point(this.Location.X, this.Location.Y - 3);
            }

            // Stop the timer when the animation is complete
            if (Opacity >= 1 && this.Location.Y <= Payments.parentY)
            {
                ModalEffect_Timer.Stop();
            }
        }

        private void dataReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Start the cancel animation timer
            ModalCancel_Timer.Start();
        }

        private void ModalCancel_Timer_Tick(object sender, EventArgs e)
        {
            // Decrease opacity for fade-out effect
            if (Opacity > 0)
            {
                Opacity -= 0.03;
            }

            // Incrementally move the form downwards
            if (this.Location.Y < Payments.parentY + 160)
            {
                this.Location = new Point(this.Location.X, this.Location.Y + 3);
            }

            // Close the form when the animation completes
            if (Opacity <= 0)
            {
                ModalCancel_Timer.Stop();
                this.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Generate PDF receipt
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save Receipt";
            saveFileDialog.FileName = "Receipt.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Add receipt content
                    pdfDoc.Add(new Paragraph("\t\tRECEIPT"));
                    pdfDoc.Add(new Paragraph("Amiggas Renting System"));
                    pdfDoc.Add(new Paragraph($"Date: {lblDate.Text}"));
                    pdfDoc.Add(new Paragraph($"Tenant Name: {lblTenantName.Text}"));
                    pdfDoc.Add(new Paragraph($"Apartment No: {lblApartmentNo.Text}"));
                    pdfDoc.Add(new Paragraph($"Contact: {lblContact.Text}"));
                    pdfDoc.Add(new Paragraph($"Registration Date: {lblRegistrationDate.Text}"));
                    pdfDoc.Add(new Paragraph($"Date Paid: {lblDatePaid.Text}\n\n"));
                    pdfDoc.Add(new Paragraph($"Monthly Rate: {lblMonthly.Text}"));
                    pdfDoc.Add(new Paragraph($"Outstanding Balance: {lblOutstanding.Text}"));
                    pdfDoc.Add(new Paragraph($"Total Paid: {lblTotal.Text}\n\n"));

                    // Add receipt table
                    PdfPTable table = new PdfPTable(dataReceipt.Columns.Count);
                    for (int i = 0; i < dataReceipt.Columns.Count; i++)
                    {
                        table.AddCell(new Phrase(dataReceipt.Columns[i].HeaderText));
                    }
                    table.HeaderRows = 1;

                    for (int i = 0; i < dataReceipt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataReceipt.Columns.Count; j++)
                        {
                            if (dataReceipt.Rows[i].Cells[j].Value != null)
                            {
                                table.AddCell(new Phrase(dataReceipt.Rows[i].Cells[j].Value.ToString()));
                            }
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                    writer.Close();
                }

                MessageBox.Show("Receipt saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataReceipt_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
