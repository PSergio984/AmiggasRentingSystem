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
        public ModalReceipt()
        {
            InitializeComponent();
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
            this.Close();
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
                    pdfDoc.Add(new Paragraph("Receipt"));
                    pdfDoc.Add(new Paragraph($"Date: {lblDate.Text}"));
                    pdfDoc.Add(new Paragraph($"Tenant Name: {lblTenantName.Text}"));
                    pdfDoc.Add(new Paragraph($"Apartment No: {lblApartmentNo.Text}"));
                    pdfDoc.Add(new Paragraph($"Contact: {lblContact.Text}"));
                    pdfDoc.Add(new Paragraph($"Registration Date: {lblRegistrationDate.Text}"));
                    pdfDoc.Add(new Paragraph($"Date Paid: {lblDatePaid.Text}"));
                    pdfDoc.Add(new Paragraph($"Monthly Rate: {lblMonthly.Text}"));
                    pdfDoc.Add(new Paragraph($"Outstanding Balance: {lblOutstanding.Text}"));
                    pdfDoc.Add(new Paragraph($"Total Paid: {lblTotal.Text}"));

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
    }
}
