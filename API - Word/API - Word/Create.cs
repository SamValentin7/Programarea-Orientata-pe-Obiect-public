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
using Microsoft.Office.Core;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using Spire.Doc;
using Spire.Doc.Documents;




namespace API___Word
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
            submit.Enabled = false;
        }

        string filePath;
        private void submit_Click(object sender, EventArgs e)
        {
            //string template = Path.GetDirectoryName("template.docx");
            try
            {
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = true;

                Word.Document document = wordApp.Documents.OpenNoRepairDialog(filePath);
                document.Activate();

                Word.Table table = document.Tables[1];

                table.Cell(1, 1).Range.Text = tb1.Text;
                table.Cell(1, 2).Range.Text = tb2.Text;
                table.Cell(2, 1).Range.Text = tb3.Text;
                table.Cell(2, 2).Range.Text = tb4.Text;
            }
            catch { }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            filePath = fileDialog.FileName.ToString();
            submit.Enabled = true;
        }
    }
}
