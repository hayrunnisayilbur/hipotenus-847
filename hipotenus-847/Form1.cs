using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hipotenus_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double kenar1 = Convert.ToDouble(txtKenar1.Text);
            double kenar2 = Convert.ToDouble(txtKenar2.Text);

            double kenarHipotenus = Math.Sqrt(Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2));

            lblHipotenus.Text = $"1.kenarı {kenar1} \n2.kenar {kenar2} \nhipotenüsü {kenarHipotenus}";
        }
    }
}
