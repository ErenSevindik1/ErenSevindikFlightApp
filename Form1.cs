using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ErenSevindikFlightApp.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace ErenSevindikFlightApp
{

    public partial class Form1 : Form
    {
        private static string connectionString = "Data Source=..\\..\\Data\\UcakBiletiRezervasyonDb.db;Version=3;";
        DbServis _dbServis = new DbServis();
        string SecilenUlke;
        string SecilenSehir;
        string SecilenHavaalani;
        List<string> secilenKoltuk = new List<string>();
        List<string> doluKoltuklar = new List<string>();
        int secilen_ucus;

        public Form1()
        {
            InitializeComponent();
            GetUlke();
            UcakListele();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cb_ulke_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenUlke = cb_ulke.SelectedItem.ToString();
            GetSehir();

        }

        private async void GetUlke()
        {
            var Ulke = await _dbServis.GetAll<Lokasyon>();
            cb_ulke.DataSource = Ulke.Select(f => f.Ulke).Distinct().ToList();
        }

        private async void GetSehir()
        {
            if (string.IsNullOrEmpty(SecilenUlke))
                return;

            var sehir = await _dbServis.GetSehirbyUlke(SecilenUlke);
            cb_sehir.DataSource = sehir;

        }

        private async void GetHavaalani()
        {
            if (string.IsNullOrEmpty(SecilenSehir))
                return;

            var havaalani = await _dbServis.GetHavaalanibySehir(SecilenSehir);
            cb_havaalani.DataSource = havaalani;
        }

        private void cb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenSehir = cb_sehir.SelectedItem.ToString();
            GetHavaalani();
        }

        private void btn_ucakekle_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(tb_model.Text) &&
                !string.IsNullOrEmpty(tb_marka.Text) &&
                !string.IsNullOrEmpty(tb_seri.Text) &&
                !string.IsNullOrEmpty(tb_kapasite.Text))
            {

                string connectionString = "Data Source=..\\..\\Data\\UcakBiletiRezervasyonDb.db;Version=3;";

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string insertUcakQuery = @"
            INSERT INTO Ucak (Model, Marka, SeriNo, KoltukKapasite)
            VALUES (@Model, @Marka, @SeriNo, @KoltukKapasite);";

                    using (var command = new SQLiteCommand(insertUcakQuery, connection))
                    {

                        command.Parameters.AddWithValue("@Model", tb_model.Text.Trim());
                        command.Parameters.AddWithValue("@Marka", tb_marka.Text.Trim());
                        command.Parameters.AddWithValue("@SeriNo", tb_seri.Text.Trim());
                        command.Parameters.AddWithValue("@KoltukKapasite", tb_kapasite.Text.Trim());


                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Uçuş Bilgileriniz Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tab.SelectedTab = tabPage2;
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UcakListele()
        {
            dgv_ucakgoruntu.Rows.Clear();
            var Ucaklar = await _dbServis.GetAll<Ucak>();
            foreach (var Ucak in Ucaklar)
            {

                dgv_ucakgoruntu.Rows.Add(Ucak.id, Ucak.Model, Ucak.Marka, Ucak.SeriNo, Ucak.KoltukKapasite);
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabPage3;
        }

        private void dgv_lokasyon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idColumnIndex = 0;
            int ClickedRowIndex = e.RowIndex;
            DataGridViewRow selectedRow = dgv_lokasyon.Rows[ClickedRowIndex];

            if (selectedRow.Cells[idColumnIndex].Value != null)
            {
                 secilen_ucus = Convert.ToInt32(selectedRow.Cells[idColumnIndex].Value);
                MessageBox.Show($"{secilen_ucus}");
                tab.SelectedTab = tabPage3;
                doluKoltuklar = _dbServis.GetdoluKoltukNobylokasyonId(secilen_ucus);
                KoltukOluştur(6, 6, doluKoltuklar);
            }
        }

        private async void UcusListele()
        {
            dgv_lokasyon.Rows.Clear();
            var Ucuslar = await _dbServis.GetUcak(SecilenUlke, SecilenSehir, SecilenHavaalani);
            foreach (var Ucak in Ucuslar)
            {
                dgv_lokasyon.Rows.Add(Ucak.id, Ucak.Ulke, Ucak.Sehir, Ucak.Havaalani, Ucak.Tarih, Ucak.Saat);
            }
        }

        private void cb_havaalani_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenHavaalani = cb_havaalani.SelectedItem.ToString();
            UcusListele();
        }

        private void btn_KoltukOnayla_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabPage4;
        }

        private void KoltukOluştur(int rowCount, int columnCount, List<string> doluKoltuklar)
        {
            const int seatGap = 5;
            const int seatWidth = 30;
            const int seatHeight = 30;
            const int aisleGap = 20;

            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int totalWidth = columnCount * (seatWidth + seatGap) + aisleGap;
            int totalHeight = rowCount * (seatHeight + seatGap);
            int startX = 10;
            int startY = ((ClientSize.Height - totalHeight) / 2) - 30;

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    System.Windows.Forms.Button btnSeat = new System.Windows.Forms.Button
                    {
                        Cursor = Cursors.Hand,
                        Name = $"btnSeat_{letters[row]}{col + 1}",
                        Text = $"{letters[row]}{col + 1}"
                    };

                    if (doluKoltuklar.Contains(btnSeat.Text))
                    {
                        btnSeat.BackColor = Color.Red;
                        btnSeat.ForeColor = Color.Black;
                    }
                    else if (secilenKoltuk.Contains(btnSeat.Text))
                    {
                        btnSeat.BackColor = Color.Green;
                        btnSeat.ForeColor = Color.Black;
                    }

                    btnSeat.Width = seatWidth;
                    btnSeat.Height = seatHeight;

                    if (col >= columnCount / 2)
                    {
                        btnSeat.Left = startX + col * (seatWidth + seatGap) + aisleGap;
                    }
                    else
                    {
                        btnSeat.Left = startX + col * (seatWidth + seatGap);
                    }

                    btnSeat.Top = startY + row * (seatHeight + seatGap);

                    btnSeat.Click += BtnSeat_Click;
                   tabPage3.Controls.Add(btnSeat);
                }
            }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            string seatName = ((System.Windows.Forms.Button)sender).Name;
            string seatNumber = seatName.Substring(seatName.IndexOf('_') + 1);

            if (secilenKoltuk.Contains(seatNumber))
            {
                secilenKoltuk.Remove(seatNumber);
            }
            else if (doluKoltuklar.Contains(seatNumber))
            {
                MessageBox.Show("This seat already taken!");
                return;
            }
            else
            {
                secilenKoltuk.Add(seatNumber);
            }

            if (secilenKoltuk.Contains(seatNumber))
            {
                ((System.Windows.Forms.Button)sender).BackColor = Color.Green;
            }
            else
            {
                ((System.Windows.Forms.Button)sender).BackColor = Color.White;
            }

            secilenKoltuk.Sort();

            lb_secilenKoltuk.Text = "Seçilen Koltuk : ";

            foreach (string secilenKoltuk in secilenKoltuk)
            {
                lb_secilenKoltuk.Text += secilenKoltuk + ", ";
            }
        }

        private void btn_koltukOnayla_Click_1(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                Rezervasyon rezervasyon = _dbServis.GetRezerveKoltukbylokasyonId((secilen_ucus));


                foreach (var KoltukNo in secilenKoltuk)
                {
                    string insertRezervasyonQuery = $@"
                    INSERT INTO Rezervasyon (KoltukNo, LokasyonId) VALUES ('{KoltukNo}', '{secilen_ucus}');";

                    using (var command = new SQLiteCommand(insertRezervasyonQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Başarıyla Koltuk Seçildi");
            tab.SelectedTab = tabPage4;
        }
    }
}




