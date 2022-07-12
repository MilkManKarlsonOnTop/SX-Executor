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
using EasyExploits;

namespace XpXz_Executor
{
    public partial class Form1 : Form
    {
        EasyExploits.Module module = new EasyExploits.Module();
        public Form1()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void button1_Click(object sender, EventArgs e)
        {
            module.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            const string M = "Are you sure you wanna close my executor? :(";
            const string Cap = "Close Executor";

            var messagebox = MessageBox.Show(M, Cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (messagebox == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string m = "W.I.P";
            const string cap = "W.I.P";

            var messagebox1 = MessageBox.Show(m, cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
