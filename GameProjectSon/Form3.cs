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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        bool solaGit, sagaGit, zipla, anahtarial;

        int zıplamaHizi = 10;
        int force = 8;
        int score = 0;
        int karakterHizi = 10;
        int arkaplanHizi = 8;


        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) // sol için
            {
                solaGit = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) // sağ için
            {
                sagaGit = true;
            }
            if (e.KeyCode == Keys.Up && zipla == false || e.KeyCode == Keys.W && zipla == false || e.KeyCode == Keys.Space && zipla == false) // zıplama için
            {
                zipla = true;
            }
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                solaGit = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                sagaGit = false;
            }
            if (zipla == true) // zıplama için
            {
                zipla = false;
            }
        }

     

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            if (karakter.Top + karakter.Height > this.ClientSize.Height)
            {
                GameTimer.Stop();
                BitisEkraniForm f = new BitisEkraniForm();
                f.Message("Bolum 1 İyi Denemeydi");
                f.Score(score);
                f.Show();
                this.Hide();
            }
        }

   

        private void OyunuDurdur(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            karakter.Top += zıplamaHizi;

            if (solaGit == true && karakter.Left > 60)
            {
                karakter.Left -= karakterHizi;
            }
            if (sagaGit == true && karakter.Left + (karakter.Width + 60) < this.ClientSize.Width)
            {
                karakter.Left += karakterHizi;

            }
            if (solaGit == true && arkaplan.Left < 0)
            {
                arkaplan.Left += arkaplanHizi;
                oyunHareketElements("forward");
            }
            if (sagaGit == true && arkaplan.Left > -935)
            {
                arkaplan.Left -= arkaplanHizi;
                oyunHareketElements("back");

            }
            if (zipla == true)
            {
                zıplamaHizi = -12;
                force -= 1;
            }
            else
            {
                zıplamaHizi = 12;
            }
            if (zipla == true && force < 0)
            {
                zipla = false;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (karakter.Bounds.IntersectsWith(x.Bounds) && zipla == false)
                    {
                        force = 8;
                        karakter.Top = x.Top - karakter.Height;
                        zıplamaHizi = 0;
                    }
                    x.BringToFront();
                }
                if (x is PictureBox && (string)x.Tag == "kilic")
                {
                    if (karakter.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();
                        BitisEkraniForm f = new BitisEkraniForm();
                        f.Message("Bolum 3 İyi Denemeydi");
                        f.Score(score);
                        f.Show();
                        this.Hide();
                    }
                    x.BringToFront();
                }
                if (x is PictureBox && (string)x.Tag == "altın")
                {
                    if (karakter.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score += 1;
                    }
                }
            }
            if (karakter.Bounds.IntersectsWith(anahtar.Bounds))
            {
                anahtar.Visible = false;
                anahtarial = true;
            }
            if (karakter.Bounds.IntersectsWith(kapı.Bounds) && anahtarial == true && score >= 45)
            {
                kapı.Image = GameProjectSon.Properties.Resources.door_open;
                GameTimer.Stop();
                BitisEkraniForm f = new BitisEkraniForm();
                f.Message("3. Bölüm Bitti");
                f.Score(score);
                f.Show();
                this.Hide();
            }
            if (karakter.Top + karakter.Height > this.ClientSize.Height)
            {
                GameTimer.Stop();
                BitisEkraniForm f = new BitisEkraniForm();
                f.Message("Bolum 3 İyi Denemeydi");
                f.Score(score);
                f.Show();
                this.Hide();
            }
        }

        private void OyunuDurdur(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void oyunHareketElements(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "altın" || x is PictureBox && (string)x.Tag == "anahtar" || x is PictureBox && (string)x.Tag == "kapı" || x is PictureBox && (string)x.Tag == "kilic")
                {
                    if (direction == "back")
                    {
                        x.Left -= arkaplanHizi;
                    }
                    if (direction == "forward")
                    {
                        x.Left += arkaplanHizi;
                    }
                }
            }
        }
    }
}
