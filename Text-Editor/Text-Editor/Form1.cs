using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_Editor
{
    public partial class Form1 : Form
    {
        string x;
        int i;
        public Form1()
        {
            InitializeComponent();
            txtreplace.Enabled = false;
            replaceLooptoolStripButton7.Enabled = false;
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files | *.txt";
            saveFileDialog1.DefaultExt = "txt";
        }

        #region General

        private void Form1_Load(object sender, EventArgs e)
        {
            FontSize();
            InstalledFonts();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        #endregion

        #region MainMenu

        //File

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt File (.txt)| *.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                   
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    richTextBox1.Text = fileContent;
                }
            }

            /*OpenFileDialog rishav = new OpenFileDialog();
            rishav.Title = "Open";
            rishav.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (rishav.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(rishav.FileName, RichTextBoxStreamType.PlainText);
            this.Text = rishav.FileName;*/
          
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
            /*SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            svf.Title = "Save file...";
            if (svf.ShowDialog() == DialogResult.OK);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
            sw.Write(richTextBox1.Text);
            sw.Close();*/
        }
        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Edit

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        //Format

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fnt.Font;
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionBackColor = fnt.Color;
        }

        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = fnt.Color;
            
        }
       
        //About

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        #endregion

        #region Toolbar

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt File (.txt)| *.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    richTextBox1.Text = fileContent;
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
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

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Font rfont = new Font(richTextBox1.Font, FontStyle.Regular);

            richTextBox1.SelectionFont = rfont;

        }

        private void boldToolStripButton_Click(object sender, EventArgs e) //Bold
        {
            Font bfont = new Font(richTextBox1.Font, FontStyle.Bold);
            Font rfont = new Font(richTextBox1.Font, FontStyle.Regular);

            if (richTextBox1.SelectedText.Length == 0)
                return;

            if (richTextBox1.Font.Bold)
            {
                richTextBox1.SelectionFont = rfont;
            }
            else
            {
                richTextBox1.SelectionFont = bfont;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //italic
        {
            Font ifont = new Font(richTextBox1.Font, FontStyle.Italic);
            Font rfont = new Font(richTextBox1.Font, FontStyle.Regular);

            if (richTextBox1.SelectedText.Length == 0)
                return;
            if (richTextBox1.SelectionFont.Italic)
            {
                richTextBox1.SelectionFont = rfont;
            }
            else
            {
                richTextBox1.SelectionFont = ifont;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e) //underline
        {
            Font ufont = new Font(richTextBox1.Font, FontStyle.Underline);
            Font rfont = new Font(richTextBox1.Font, FontStyle.Regular);

            if (richTextBox1.SelectedText.Length == 0)
                return;
            if (richTextBox1.SelectionFont.Underline)
            {
                richTextBox1.SelectionFont = rfont;
            }
            else
            {
                richTextBox1.SelectionFont = ufont;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e) //Strikethrough
        {
            Font sfont = new Font(richTextBox1.Font, FontStyle.Strikeout);
            Font rfont = new Font(richTextBox1.Font, FontStyle.Regular);

            if (richTextBox1.SelectedText.Length == 0)
                return;
            if (richTextBox1.SelectionFont.Strikeout)
            {
                richTextBox1.SelectionFont = rfont;
            }
            else
            {
                richTextBox1.SelectionFont = sfont;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e) //left
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton5_Click(object sender, EventArgs e) //center
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightToolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void upperToolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();
        }

        private void lowerToolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();
        }

        private void plusToolStripButton9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor == 63)
            {
                return;
            }
            else
                richTextBox1.ZoomFactor = richTextBox1.ZoomFactor + 1;
        }

        private void minusToolStripButton10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor == 1)
            {
                return;
            }
            else
                richTextBox1.ZoomFactor = richTextBox1.ZoomFactor - 1;
        }

        private void btn_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectionFont = new Font(btn_Font.Text, richTextBox1.Font.Size, richTextBox1.Font.Style);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btn_FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectionFont = new Font(btn_FontSize.SelectedItem.ToString(), int.Parse(btn_FontSize.SelectedItem.ToString()), richTextBox1.Font.Style);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void findLooptoolStripButton_Click(object sender, EventArgs e)
        {
            find();
            if (i >= 0)
            {
                MessageBox.Show("Index of " + x + " is " + i, "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtreplace.Enabled = true;
                replaceLooptoolStripButton7.Enabled = true;
            }
            else
            {
                MessageBox.Show("Word not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfind.Text = "";
            }
        }
        
        private void replaceLooptoolStripButton7_Click(object sender, EventArgs e)
        {
            find();
            if (i < 0)
            {
                MessageBox.Show("Word not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtreplace.Text = "";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text.Replace(x, txtreplace.Text);
                MessageBox.Show("Word Successful Replaced", "Replaced", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtreplace.Enabled = false;
                replaceLooptoolStripButton7.Enabled = false;
                txtreplace.Text = "";
            }
        }

        #endregion

        void FontSize()
        {
            for (int fntSize = 8; fntSize <= 75; fntSize++)
            {
                btn_FontSize.Items.Add(fntSize.ToString());
            }
        }

        void InstalledFonts()
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            foreach (FontFamily font in FontFamily.Families)
            {
                btn_Font.Items.Add(font.Name.ToString());
            }

        }
        public void find()
        {
            x = txtfind.Text;
            i = richTextBox1.Find(x, RichTextBoxFinds.None);
        }

        
    }
}
