using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSiparisForm
{
    public partial class LoginForm : Form
    {
        static int sayac = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text.Length == 0 && txtSifre.Text.Length == 0)
            {
                txtKullanici.BackColor = Color.Pink;
                txtSifre.BackColor = Color.Purple;
                lblSonuc.Text = "Lütfen tüm alanları doldurunuz";
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            }
            else if (txtKullanici.Text.Length == 0)
            {
                MessageBox.Show("Lütfen kullanıcı adını giriniz !");
            }
            else if (txtSifre.Text.Length == 0)
            {
                MessageBox.Show("Lütfen şifrenizi giriniz !");
            }
            else if (txtKullanici.Text == "rozerin" && txtSifre.Text == "123")
            {
                Form1 frm1 = new Form1();
                frm1.Show();
            }
            else
            {
                sayac++;
                MessageBox.Show("Lütfen bilgilerinizi giriniz");
                if (sayac == 3)
                {
                    btnLogin.Enabled = false;
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
