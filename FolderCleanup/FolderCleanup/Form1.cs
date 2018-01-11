using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderCleanup
{
    public partial class Form1 : Form
    {
        Thread t;
        int Counter;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int x_location, int y_location, string ButtonState,string path)
        {
            Location = new Point(x_location, y_location);
            InitializeComponent();
            button2.Text = ButtonState;
            textBox1.Text = path;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Start")
            {
                Counter = decimal.ToInt32(numericUpDown1.Value);
                time_label.Text = Counter.ToString();
                button2.Text = "Stop";
                if (Time_radioButton.Checked) timer1.Enabled = true;
                else timer2.Enabled = true;
            }
            else
            {
                button2.Text = "Start";
                timer1.Enabled = false;
                timer2.Enabled = false;
                if (t != null)
                    if (t.IsAlive) t.Suspend();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_label.Text = Counter.ToString();
            if (textBox1.Text != "")
            {
                if (Directory.Exists(textBox1.Text))
                {
                    FileToDelete_label.Text = Directory.GetFiles(textBox1.Text, "*.*", SearchOption.AllDirectories).Length.ToString();
                    Counter--;
                    if (Counter == 0)
                    {
                        try
                        {
                            DeleteFilesAndFolders instance = new DeleteFilesAndFolders(textBox1.Text);
                            t = new Thread(() => instance.Delete());
                            t.Start();
                        }
                        catch
                        {

                        }
                        Counter = decimal.ToInt32(numericUpDown1.Value);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK) textBox1.Text = fbd.SelectedPath;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Directory.Exists(textBox1.Text))
                {
                    FileToDelete_label.Text = Directory.GetFiles(textBox1.Text, "*.*", SearchOption.AllDirectories).Length.ToString();
                    
                    if (int.Parse(FileToDelete_label.Text) >= int.Parse(FileToDelete_textBox.Text))
                    {
                        try
                        {
                            DeleteFilesAndFolders instance = new DeleteFilesAndFolders(textBox1.Text);
                            t = new Thread(() => instance.Delete());
                            t.Start();
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }

        private void Time_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (button2.Text == "Start")
            {

            }
            else
            {   
                    timer1.Enabled = true;
                    timer2.Enabled = false;
            }
        }

        private void MountradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (button2.Text == "Start")
            {

            }
            else
            {
                timer2.Enabled = true;
                timer1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Minimum GUI")
            {
                groupBox1.Visible = false;
                label1.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
                groupBox3.Location = new Point(111, 6);
                button2.Location = new Point(15, 44);
                Size = new Size(325, 116);
                button3.Text = "Maximum GUI";
            }
            else
            {
                groupBox1.Visible = true;
                label1.Visible = true;
                textBox1.Visible = true;
                button1.Visible = true;
                groupBox3.Location = new Point(358, 33);
                button2.Location = new Point(455, 128);
                Size = new Size(577, 201);
                button3.Text = "Minimum GUI";
            }
        }
    }
}
