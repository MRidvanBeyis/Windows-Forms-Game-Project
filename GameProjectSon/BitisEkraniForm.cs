using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using BBP201Project1;

namespace GameProjectSon
{
    public partial class BitisEkraniForm : Form
    {
        public BitisEkraniForm()
        {
            InitializeComponent();
        }

        //string a = "";

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        }

        public void Score(int a)
        {
            lblScore.Text = a.ToString();
        }

        public void Message(string b)
        {
            lblText.Text = b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YapimcilarForm f = new YapimcilarForm();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfaForm f = new AnaSayfaForm();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AnaSayfaForm f = new AnaSayfaForm();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblText.Text == "1. Bölüm Bitti" || lblText.Text == "Bolum 1 İyi Denemeydi")
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            if (lblText.Text == "2. Bölüm Bitti" || lblText.Text == "Bolum 2 İyi Denemeydi")
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            if (lblText.Text == "3. Bölüm Bitti" || lblText.Text == "Bolum 3 İyi Denemeydi")
            {
                Form3 f = new Form3();
                f.Show();
                this.Hide();
            }
            if (lblText.Text == "4. Bölüm Bitti" || lblText.Text == "Bolum 4 İyi Denemeydi")
            {
                Form4 f = new Form4();
                f.Show();
                this.Hide();
            }
            if (lblText.Text == "5. Bölüm Bitti" || lblText.Text == "Bolum 5 İyi Denemeydi")
            {
                Form5 f = new Form5();
                f.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lblText.Text == "1. Bölüm Bitti")
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            if (lblText.Text == "2. Bölüm Bitti")
            {
                Form3 f = new Form3();
                f.Show();
                this.Hide();
            }
            if (lblText.Text == "3. Bölüm Bitti")
            {
                Form4 f = new Form4();
                f.Show();
                this.Hide();
            }
            if (lblText.Text == "4. Bölüm Bitti")
            {
                Form5 f = new Form5();
                f.Show();
                this.Hide();
            }
            if (lblText.Text == "5. Bölüm Bitti")
            {
                Form5 f = new Form5();
                f.Show();
                this.Hide();
            }
        }

        private void BitisEkraniForm_Load(object sender, EventArgs e)
        {
            if (lblText.Text == "Bolum 1 İyi Denemeydi"|| lblText.Text == "Bolum 2 İyi Denemeydi"|| lblText.Text == "Bolum 3 İyi Denemeydi"|| lblText.Text == "Bolum 4 İyi Denemeydi"|| lblText.Text == "Bolum 5 İyi Denemeydi")
            {
                button4.Visible = false;
            }
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void OyunuDurdur(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
