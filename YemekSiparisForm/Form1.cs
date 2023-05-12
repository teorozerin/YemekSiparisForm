using System.Drawing.Text;
using System.Data.SqlClient;

//using System.Data.SqlClient; bu bir ado net kütüphanesinin kullanýmý için gerekli usingidir.

namespace YemekSiparisForm
{
    public partial class Form1 : Form
    {
        string secilenRestoran = "";
        string secilenYemekCesitleri = "";
        string secilenMalzemeler = "";
        string connectionString = "Data Source=DESKTOP-F23C5M8;Initial Catalog=YemekSiparisDB;Trusted_Connection=True;MultipleActiveResultSets=true";

        List<YemekSiparis> yemeklistesi = new List<YemekSiparis>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRestoran.Items.Add("Seçiniz");
            cmbRestoran.Items.Add("Burger King");
            cmbRestoran.Items.Add("Dominos");
            cmbRestoran.Items.Add("Usta Döner");
        }

        private void cmbRestoran_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenRestoran = cmbRestoran.SelectedItem.ToString();
            cmbYemekCesit.Items.Clear();
            if (cmbRestoran.SelectedItem.ToString() == "Burger King")
            {
                cmbYemekCesit.Items.Add("Yemek Seçiniz");
                cmbYemekCesit.Items.Add("Chicken Burger");
                cmbYemekCesit.Items.Add("Köfte Burger");
            }
            else if (cmbRestoran.SelectedItem.ToString() == "Dominos")
            {
                cmbYemekCesit.Items.Add("Yemek Seçiniz");
                cmbYemekCesit.Items.Add("Bol Malzemos");
                cmbYemekCesit.Items.Add("Vegan Pizza");
            }
            else if (cmbRestoran.SelectedItem.ToString() == "Usta Döner")
            {
                cmbYemekCesit.Items.Add("Yemek Seçiniz");
                cmbYemekCesit.Items.Add("Tavuk Dürüm");
                cmbYemekCesit.Items.Add("Et Dürüm");
            }


        }

        private void cmbYemekCesit_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenYemekCesitleri = cmbYemekCesit.SelectedItem.ToString();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            //Yemek yemek = new Yemek(secilenRestoran, secilenYemekCesitleri, secilenMalzemeler, Convert.ToString(txtIcecek), Convert.ToDouble(txtFiyat));
            //yemeklistesi.Add(yemek);
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                SqlCommand command = new SqlCommand("insert into YemekSiparis(restoranadi,yemekcesitleri,malzeme,icecek,fiyat)" +
                         " values('" + secilenRestoran + "','" + secilenYemekCesitleri + "','" + secilenMalzemeler + "'," +
                         "'" + Convert.ToString(txtIcecek.Text) + "','" + Convert.ToDouble(txtFiyat.Text) + "')", sqlConnection);

                int etkilenenKayitSayisi = command.ExecuteNonQuery();

                if (etkilenenKayitSayisi > 0)
                {
                    MessageBox.Show("kayit eklendi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbMalzemeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenMalzemeler = cmbMalzemeler.SelectedItem.ToString();
        }

        public void ListeyeEkle()
        {
            double toplamFiyat = 0.0;
            listBox1.Items.Clear();
            foreach (YemekSiparis yemek in yemeklistesi)
            {
                listBox1.Items.Add("Restoran : " + yemek.restoran + "Yemek Çeþitleri : " + yemek.yemekCesitleri + "Fiyatý : " + yemek.fiyat);
                toplamFiyat += yemek.fiyat;
            }

            label6.Text = "Sipariþ verilen yemeðin toplam fiyatý : " + toplamFiyat;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}