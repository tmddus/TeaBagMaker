using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TeaBagMakers
{
    public partial class Form1 : Form
    {
        int CountNum = 0; 

        public Form1()
        {
            InitializeComponent();
        }


        // 콤보 박스 데이터
        string[] data = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        int[] timedata = new int[] { 60, 180, 300, 120 };

        string tea = "";

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CountNum < 1)
            {
                this.timer1.Enabled = false;
                this.label3.Text = "";
                MessageBox.Show("티백을 건지세요!", "타임아웃", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Focus();
            }
            else
            {
                CountNum--;
                if (CountNum > 60) {
                    this.label3.Text = CountNum / 60 + "분" + CountNum % 60 + "초";
                }
                else
                {
                    this.label3.Text = CountNum + "초";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
            this.label3.Text = timedata[this.comboBox1.SelectedIndex] / 60 + "분";
            CountNum = timedata[this.comboBox1.SelectedIndex];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < data.Length; i++)
            {
                this.comboBox1.Items.Add(data[i]);
            }
            this.label3.Text = timedata[0]/60 + "분";
            CountNum = timedata[0];
            if(comboBox1.Items.Count > 0)
            {
                this.comboBox1.SelectedIndex = 0;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
