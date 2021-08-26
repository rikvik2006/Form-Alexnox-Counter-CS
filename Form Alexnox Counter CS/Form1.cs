using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_Alexnox_Counter_CS.Properties;


//Count


namespace Form_Alexnox_Counter_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Count.Text = counter.ToString();
        }

        
        int counter = (int)Settings.Default["Count"];

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            Count.Text = counter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter--;
            Count.Text = counter.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings.Default["Count"] = int.Parse(Count.Text);
            Settings.Default.Save();
            MessageBox.Show("Salvato");
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.F17)
            {
                counter++;
                Count.Text = counter.ToString();
            }

        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.F18)
            {
                counter--;
                Count.Text = counter.ToString();
            }
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.F19)
            {
                Settings.Default["Count"] = int.Parse(Count.Text);
                Settings.Default.Save();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+1 = Ctrl + F17 \n\n -1 = Ctrl + F18 \n\n Save = Ctrl + F19");
        }
    }
}
