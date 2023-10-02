using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alan_ve_çevre_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            int Alan, Cevre;
            int kenar1 = Convert.ToInt32(txtKenar1.Text);
            int kenar2 = Convert.ToInt32(txtKenar2.Text);

            Alan = kenar1 * kenar2;
            Cevre = kenar1 * 2 + kenar2 * 2;

            lblAlan.Text = "Alan: " + Alan.ToString();
            lblCevre.Text = "Çevre: " + Cevre.ToString();
        }
    }
}
