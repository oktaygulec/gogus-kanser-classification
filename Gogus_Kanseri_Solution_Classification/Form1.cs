using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FutbolOyna_Agac_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHayattaKalmaDurumu.Text = "?";
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int node = int.Parse(txtNode.Text);
            int age = int.Parse(txtAge.Text);
            if(node <= 4)
                lblHayattaKalmaDurumu.Text = "5 Yıl veya Daha Fazla";
            else
            {
                if(age > 42)
                    lblHayattaKalmaDurumu.Text = "5 Yıldan Daha Az";
                else
                    lblHayattaKalmaDurumu.Text = "5 Yıl veya Daha Fazla";
            }
        }
    }
}
