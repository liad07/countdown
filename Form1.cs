using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coundown
{
    public partial class Form1 : Form
    {
        private int totalsec;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 60; i++)
            {
                this.comboBox1.Items.Add(i.ToString());
                this.comboBox2.Items.Add(i.ToString());
            }
            this.comboBox1.SelectedIndex = 59;
            this.comboBox2.SelectedIndex = 59;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = true;

            int minute = int.Parse(this.comboBox1.SelectedItem.ToString());
            int sec = int.Parse(this.comboBox2.SelectedItem.ToString());
            totalsec = (minute * 60)+sec;
            this.timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.button2.Enabled = false;
            this.timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalsec > 0)
            {
                totalsec--;
                int minute = totalsec / 60;
                int sec = totalsec - (minute * 60);
                this.label3.Text = minute.ToString() + ":" + sec.ToString();
            }
            else
            {
                this.timer1.Stop();
                MessageBox.Show("נגמר הזמן");
            }
        }
    }
}
