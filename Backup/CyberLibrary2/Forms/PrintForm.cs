using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace CyberLibrary2.Forms
{
    public partial class PrintForm : Form
    {
        PrintDocument Printer;
        Page myPage;
        public PrintForm(Page page)
        {
            InitializeComponent();
            myPage = page;
        }
        private void PrintForm_Load(object sender, EventArgs e)
        {

        }

        private void btView_Click(object sender, EventArgs e)
        {
            
        }

        private void Printer_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {

        }

        private void Printer_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(string.Format("{0:S} - {1}/{2} 페이지 ( {3:S} ) [ 글쓴이 {4:S} 옮김이 {5:S} ] ☆ CyberLibrary", myPage.myBook.BookName, myPage.PageIndex, myPage.myBook.PageCount, myPage.Name, myPage.myBook.WriterName, myPage.myBook.TransferName),new Font("굴림",9),Brushes.Black,new PointF(0,0));
            Printer.DocumentName = myPage.Name;
            foreach (BookData con in myPage.Controls)
            {
                con.Printer(e.Graphics);
            }
            foreach (DDraw draw in myPage.Draws)
            {
                draw.Printer(e.Graphics);
            }
            foreach (DMemo memo in myPage.Memos)
            {
                if (chkMemoBottom.Checked)
                {
                    e.Graphics.DrawString(">" + memo.Context, new Font(memo.Font.Name, (float)NumbericMemoFontSize.Value, memo.Font.Style), new SolidBrush(memo.FColor), new PointF(memo.Location.X, memo.Location.Y + memo.Size.Height));
                }
                if (chkMemoTop.Checked)
                {
                    e.Graphics.DrawString(">" + memo.Context, new Font(memo.Font.Name, (float)NumbericMemoFontSize.Value, memo.Font.Style), new SolidBrush(memo.FColor), new PointF(memo.Location.X, memo.Location.Y - ((float)NumbericMemoFontSize.Value) - 3));
                
                }
                if (chkMemoMiddle.Checked)
                {
                    e.Graphics.DrawString(">" + memo.Context, new Font(memo.Font.Name, (float)NumbericMemoFontSize.Value, memo.Font.Style), new SolidBrush(memo.FColor), new PointF(memo.Location.X, memo.Location.Y + (memo.Size.Height / 2) - (float)NumbericMemoFontSize.Value / 2));
                }
            }
        }

        private void btView_Click_1(object sender, EventArgs e)
        {
            Printer = new PrintDocument();
            Printer.PrintPage += Printer_PrintPage;
            PrintView prView = new PrintView(Printer);
            prView.ShowDialog();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            Printer = new PrintDocument();
            Printer.PrintPage += Printer_PrintPage;
            
            printDialog.Document = Printer;
            printDialog.AllowCurrentPage = printDialog.AllowPrintToFile = false;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDialog.Document.Print();
                DialogResult = DialogResult.OK;
                Close();

            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }
    }
}
