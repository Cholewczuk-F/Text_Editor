using System;
using System.Drawing;
using System.Windows.Forms;

namespace lista4_zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            FileDestBox.Text = "";
        }

        private void ReadFileB_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                OpenFileDialog openFile1 = new OpenFileDialog();

                // Initialize the OpenFileDialog to look for RTF files.
                openFile1.DefaultExt = "*.rtf";
                openFile1.Filter = "RTF Files|*.rtf";

                // Determine whether the user selected a file from the OpenFileDialog.
                if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                   openFile1.FileName.Length > 0)
                {
                    // Load the contents of the file into the RichTextBox.
                    richTextBox1.LoadFile(openFile1.FileName);
                }
            }
        }

        private void SaveFileB_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "RTF Files|*.rtf";
            savefile.Title = "Save an document File";
            savefile.InitialDirectory = @"C:\";
            savefile.RestoreDirectory = true;
            savefile.DefaultExt = "*.rtf";
            savefile.CheckPathExists = true;
            

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                FileDestBox.Text = savefile.FileName;

                richTextBox1.SaveFile(savefile.FileName.ToString());
            }
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                string[] words = SearchBox.Text.Split(',');

                foreach (string word in words)
                {
                    int startindex = 0;
                    while (startindex < richTextBox1.TextLength)
                    {
                        int wordstartIndex = richTextBox1.Find(word, startindex, RichTextBoxFinds.None);
                        if (wordstartIndex != -1)
                        {
                            richTextBox1.SelectionStart = wordstartIndex;
                            richTextBox1.SelectionLength = word.Length;
                            richTextBox1.SelectionBackColor = Color.Yellow;
                        }
                        else
                            break;
                        startindex += wordstartIndex + word.Length;
                    }
                }
            }
            else
            {
                richTextBox1.SelectionStart = 0;
                richTextBox1.SelectionLength = richTextBox1.Text.Length;
                richTextBox1.SelectionBackColor = Color.White;
            }

        }

        private void RepleaseB_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Replace(SearchBox.Text,RepleaseBox.Text);
        }
    }
}
