using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie3_Zgadywanka
{
    public partial class Form1 : Form
    {
        int próby = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int wymyslonaLiczba = 430;
            
            if(int.Parse(textBox1.Text) > wymyslonaLiczba)
            {
                MessageBox.Show("Twoja liczba jest zbyt duża");
                próby++;
            }
            else if(int.Parse(textBox1.Text) < wymyslonaLiczba)
            {
                MessageBox.Show("Twoja liczba jest zbyt mała");
                próby++;
            }
            else
            {
                MessageBox.Show("Gratulacje Trafiłeś!!!");
            }
            textBox2.Text = próby.ToString();
        }
    }
}
