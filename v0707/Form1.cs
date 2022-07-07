using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0707
{
    public partial class Form1 : Form
    {
        int[] data = new int[3];
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            data[0] = rand.Next(11);
            data[1] = rand.Next(11);
            data[2] = rand.Next(11);
            MessageBox.Show($"{data[0]},{data[1]},{data[2]}");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int sum = data[0] + data[1] + data[2];
            MessageBox.Show($"合計{sum}");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int avr = (data[0] + data[1] + data[2]) / 3;
            MessageBox.Show($"平均{avr}");
        }
    }
}
