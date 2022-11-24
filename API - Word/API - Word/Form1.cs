using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Reflection.Emit;
using System.Drawing.Printing;
using System.IO;
using Spire.Doc;
using Spire.Doc.Documents;

namespace API___Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(richTextBox1.Width, richTextBox1.Height);
            richTextBox1.DrawToBitmap(imagebmp, new System.Drawing.Rectangle(0, 0, richTextBox1.Width, richTextBox1.Height));
            e.Graphics.DrawImage(imagebmp, 0, 120);
            //e.Graphics.DrawString(label2.Text, new Font("Microsoft YaHei", 18, FontStyle.Bold), Brushes.Black, new Point(120));
            }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                word.Visible = true;
                word.WindowState = Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateNormal;
                Microsoft.Office.Interop.Word.Document doc = word.Documents.Add();
                Microsoft.Office.Interop.Word.Paragraph paragraph;
                paragraph = doc.Paragraphs.Add();
                paragraph.Range.Text = richTextBox1.Text;
                doc.SaveAs2(@"D:\Documents\API_doc.doc");
                //doc.Close();
                //word.Quit();
            }
            catch
            {

            }
            
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "Word 97-2003|*.doc|Word Document|*.docx" })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    object readOnly = false;
                    object visible = true;
                    object save = false;
                    object fileName = ofd.FileName;
                    object newTemplate = false;
                    object docType = 0;
                    object missing = Type.Missing;
                    Microsoft.Office.Interop.Word.Document document;
                    Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                    document = application.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
                    document.ActiveWindow.Selection.WholeStory();
                    document.ActiveWindow.Selection.Copy();
                    IDataObject dataObject = Clipboard.GetDataObject();
                    richTextBox1.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                    application.Quit(ref missing, ref missing, ref missing);
                }
            }

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fnt.Font;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Create form = new Create();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
             
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Spire.Doc.Document document = new Spire.Doc.Document();
            Spire.Doc.Section section = document.AddSection();
            section.AddParagraph().AppendText("That's the image you want to see");
            section.AddParagraph().AppendText("");

            Spire.Doc.Documents.Paragraph paragraph = new Spire.Doc.Documents.Paragraph(document);
            paragraph.AppendText("");

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            string filePath = fileDialog.FileName.ToString();

            paragraph.AppendPicture(Image.FromFile(filePath));
            section.Paragraphs.Insert(1, paragraph);

            document.SaveToFile(@"D:\\Documents\\img.doc", FileFormat.Doc);
            
            WordDocViewer(@"D:\\Documents\\img.doc");
            //document.Close();
        }
        private void WordDocViewer(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch { }
        }
    }
}
