using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment=HorizontalAlignment.Left;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            if (toolStripButton16.Checked)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, this.Font.Size, FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, this.Font.Size, FontStyle.Regular);
            }

        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            
            if (toolStripButton12.Checked)
            {
                richTextBox1.SelectionColor = Color.Red;
            }
            else
            {
                richTextBox1.SelectionColor = Color.Black;
            }
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            if (toolStripButton17.Checked)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, this.Font.Size, FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, this.Font.Size, FontStyle.Regular);
            }
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            if (toolStripButton18.Checked)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, this.Font.Size, FontStyle.Underline) ;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, this.Font.Size, FontStyle.Regular);
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
                catch
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        richTextBox1.Text = sr.ReadToEnd();
                    }
                    
                }
                
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in FileName)
            {
                using (StreamReader sr = new StreamReader(file))
                    richTextBox1.Text = sr.ReadToEnd();
            }

        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("C:\\Users\\Default\\Documents");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Йде друк");
        }
    }
}
