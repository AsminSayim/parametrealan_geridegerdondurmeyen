using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parametrealan_geridegerdondürmeyen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Topla (int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            label1.Text=toplam.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1=Convert.ToInt32(textBox1.Text);
            int s2=Convert.ToInt32(textBox2.Text);

            Topla(s1, s2);
        }
    }
}
