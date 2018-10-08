using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //загрузка файлов и папок
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach(DirectoryInfo dirinf in dirs)
            {
                listBox1.Items.Add(dirinf);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo currFile in files)
            {
                listBox1.Items.Add(currFile);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = Path.Combine(textBox1.Text,listBox1.SelectedItem.ToString());
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (DirectoryInfo dirinf in dirs)
            {
                listBox1.Items.Add(dirinf);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo currFile in files)
            {
                listBox1.Items.Add(currFile);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text[textBox1.Text.Length - 1]=='\\')
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1,1);
                while(textBox1.Text[textBox1.Text.Length - 1]!='\\')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
            }
            else if  (textBox1.Text[textBox1.Text.Length - 1] != '\\')
            {
                while (textBox1.Text[textBox1.Text.Length - 1] != '\\')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
            }
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (DirectoryInfo dirinf in dirs)
            {
                listBox1.Items.Add(dirinf);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo currFile in files)
            {
                listBox1.Items.Add(currFile);
            }
        }
    }
}
