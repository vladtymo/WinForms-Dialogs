using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label.Font = new Font("Times-New-Roman", 22);

            FontDialog dialog = new FontDialog();
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                label.Font = dialog.Font;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                label.ForeColor = dialog.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream()
            //StreamReader sr = new StreamReader()
            //File.ReadAllText();

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            //dialog.Multiselect = true;
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string text = File.ReadAllText(dialog.FileName);
                label.Text = text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.DefaultExt = ".txt";
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, label.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Folder: " + dialog.SelectedPath);
            }
        }
    }
}
