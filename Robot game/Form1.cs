using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot_game
{
    public partial class Form1 : Form
    {
        Robot robot1 = new Robot();
        Robot robot2 = new Robot();
        Robot robot3 = new Robot();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (robot1.SetHp(textBox1.Text,"1") ==true && robot2.SetHp(textBox2.Text,"2") == true && robot3.SetHp(textBox3.Text,"3") == true)
            {
                robot1.SetHp(textBox1.Text, "1");
                robot2.SetHp(textBox2.Text, "2");
                robot3.SetHp(textBox3.Text, "3");
                label4.Text = $"Здоровье после игры = {robot1.NewHp()}";
                label5.Text = $"Здоровье после игры = {robot2.NewHp()}";
                label6.Text = $"Здоровье после игры = {robot3.NewHp()}";
            }
                
        }
    }
}
