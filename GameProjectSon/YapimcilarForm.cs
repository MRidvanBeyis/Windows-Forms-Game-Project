using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProjectSon
{
    public partial class YapimcilarForm : Form
    {
        public YapimcilarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfaForm f = new AnaSayfaForm();
            f.Show();
            this.Hide();
        }

        private void OyunuDurdur(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
