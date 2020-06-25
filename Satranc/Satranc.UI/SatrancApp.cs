using Santrac.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satranc.UI
{
    public partial class SatrancApp : Form
    {
        public SatrancApp()
        {
            InitializeComponent();
        }
        static List<Label> tahtaLbl;
        private void LabelCiz()
        {
            DiziOlustur();

            tahtaLbl = new List<Label>();
            Label lbl = null;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    if ((i + j) % 2 == 0)
                    {
                        lbl = new Label();
                        lbl.Name = i + "_" + j;
                        lbl.BackColor = Color.White;
                        lbl.ForeColor = Color.Black;
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Width = 50;
                        lbl.Height = 50;
                        //lbl.Text = i + "_" + j;
                        lbl.Top += 55 * j;
                        lbl.Left += 55 * i;
                        pnlTahta.Controls.Add(lbl);
                        tahtaLbl.Add(lbl);
                    }
                    else
                    {
                        lbl = new Label();
                        lbl.Name = i + "_" + j;
                        lbl.BackColor = Color.Black;
                        lbl.ForeColor = Color.White;
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Width = 50;
                        lbl.Height = 50;
                        //lbl.Text = i + "_" + j;
                        lbl.Top += 55 * j;
                        lbl.Left += 55 * i;

                        pnlTahta.Controls.Add(lbl);

                        tahtaLbl.Add(lbl);

                    }
                }
            }
        }
        private void SatrancApp_Load(object sender, EventArgs e)
        {
            LabelCiz();
        }
        
        static int[,] tahta = new int[8, 8];
        static int konumx = 0;
        static int konumy = 0;

        public void DiziOlustur()
        {

            Random rnd = new Random();
            konumx = rnd.Next(0, 7);
            konumy = rnd.Next(0, 7);
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (konumx == x && konumy == y)
                        tahta[x, y] = 1;
                    else
                        tahta[x, y] = 0;
                }
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Interval = 450;
            timer1.Start();
            
        }
        public void Ciz()
        {


            var t = tahtaLbl.Where(x => x.Name == konumx + "_" + konumy).FirstOrDefault();
            if (t != null)
            {
                t.BackColor = Color.Blue;
            }
            lstOlasilikListesi.Items.Add("Bulundugu Konum => " + " x,y (" + konumx + "," + konumy + ")");

        }
        public static int sayac = 0;
        public static List<Possibility> durumlar = new List<Possibility>();

        public static void HareketOlasiliklari(int konumx, int konumy)
        {
            //yukarisag olasılık
            if (konumy - 2 >= 0)
            {
                if (konumx + 1 <= 7 && tahta[konumx + 1, konumy - 2] == 0)
                {                   
                    durumlar.Add(new Possibility { KonumX = konumx + 1, KonumY = konumy - 2, CountPossibility = HareketSayisi(konumx + 1, konumy - 2) });
                }
            }
            //yukarisol olasılık
            if (konumy - 2 >= 0)
            {
                if (konumx - 1 >= 0 && tahta[konumx - 1, konumy - 2] == 0)
                {                 
                    durumlar.Add(new Possibility { KonumX = konumx - 1, KonumY = konumy - 2, CountPossibility = HareketSayisi(konumx - 1, konumy - 2) });
                }
            }
            //aşagısağ olasılık
            if (konumy + 2 <= 7)
            {
                if (konumx + 1 <= 7 && tahta[konumx + 1, konumy + 2] == 0)
                {                  
                    durumlar.Add(new Possibility { KonumX = konumx + 1, KonumY = konumy + 2, CountPossibility = HareketSayisi(konumx + 1, konumy + 2) });
                }
            }
            //aşagısol olasılık
            if (konumy + 2 <= 7)
            {
                if (konumx - 1 >= 0 && tahta[konumx - 1, konumy + 2] == 0)
                {                 
                    durumlar.Add(new Possibility { KonumX = konumx - 1, KonumY = konumy + 2, CountPossibility = HareketSayisi(konumx - 1, konumy + 2) });
                }
            }
            //sağaşagı olasılık
            if (konumx + 2 <= 7)
            {
                if (konumy + 1 <= 7 && tahta[konumx + 2, konumy + 1] == 0)
                {                   
                    durumlar.Add(new Possibility { KonumX = konumx + 2, KonumY = konumy + 1, CountPossibility = HareketSayisi(konumx + 2, konumy + 1) });
                }
            }
            //sağyukarı olasılık
            if (konumx + 2 <= 7)
            {
                if (konumy - 1 >= 0 && tahta[konumx + 2, konumy - 1] == 0)
                {                    
                    durumlar.Add(new Possibility { KonumX = konumx + 2, KonumY = konumy - 1, CountPossibility  = HareketSayisi(konumx + 2, konumy - 1) });

                }
            }
            //solaşağı olasılık
            if (konumx - 2 >= 0)
            {
                if (konumy + 1 <= 7 && tahta[konumx - 2, konumy + 1] == 0)
                {                    
                    durumlar.Add(new Possibility { KonumX = konumx - 2, KonumY = konumy + 1, CountPossibility = HareketSayisi(konumx - 2, konumy + 1) });

                }
            }
            //solyukarı olasılık
            if (konumx - 2 >= 0)
            {
                if (konumy - 1 >= 0 && tahta[konumx - 2, konumy - 1] == 0)
                {                   
                    durumlar.Add(new Possibility { KonumX = konumx - 2, KonumY = konumy - 1, CountPossibility = HareketSayisi(konumx - 2, konumy - 1) });
                }
            }
        }
        public static int HareketSayisi(int konumx, int konumy)
        {
            sayac = 0;
            //yukarıhareket sayisi
            if (konumy - 2 >= 0)
            {
                if (konumx + 1 <= 7 && tahta[konumx + 1, konumy - 2] == 0)
                {
                    sayac++;
                }
                if (konumx - 1 >= 0 && tahta[konumx - 1, konumy - 2] == 0)
                {
                    sayac++;
                }
            }
            //aşagıhareketsayisi
            if (konumy + 2 <= 7)
            {
                if (konumx + 1 <= 7 && tahta[konumx + 1, konumy + 2] == 0)
                {
                    sayac++;
                }
                if (konumx - 1 >= 0 && tahta[konumx - 1, konumy + 2] == 0)
                {
                    sayac++;
                }
            }
            //sağahareketSayisi
            if (konumx + 2 <= 7)
            {
                if (konumy + 1 <= 7 && tahta[konumx + 2, konumy + 1] == 0)
                {
                    sayac++;
                }
                if (konumy - 1 >= 0 && tahta[konumx + 2, konumy - 1] == 0)
                {
                    sayac++;
                }
            }
            //solahareketsayisi
            if (konumx - 2 >= 0)
            {
                if (konumy + 1 <= 7 && tahta[konumx - 2, konumy + 1] == 0)
                {
                    sayac++;
                }
                if (konumy - 1 >= 0 && tahta[konumx - 2, konumy - 1] == 0)
                {
                    sayac++;
                }
            }
            return sayac;
        }
        DialogResult dialogResult = new DialogResult();
        private void Move()
        {
            HareketOlasiliklari(konumx, konumy);
            var doldur = (durumlar.OrderBy(a => a.CountPossibility).ToList()).FirstOrDefault();
            if (doldur == null) {
                timer1.Stop();
                dialogResult = MessageBox.Show("Devam etmek istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    pnlTahta.Controls.Clear();
                    LabelCiz();
                }
                else
                {
                    Application.Exit();
                }
                return;
            }

            konumGuncelle(doldur.KonumX, doldur.KonumY);
            durumlar.Clear();


        }
        

        private static void konumGuncelle(int x, int y)
        {
            konumx = x;
            konumy = y;
            tahta[x, y] = 1;

        }

        private void btnIlerle_Click(object sender, EventArgs e)
        {
            Ciz();
            Move();
            lstOlasilikListesi.Items.Add("Gidecegi Konum => " + " x,y (" + konumx + "," + konumy + ")");
        }

        

        private void btnDur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ciz();
            Move();
            lstOlasilikListesi.Items.Add("Gidecegi Konum => " + " x,y (" + konumx + "," + konumy + ")");
        }
    }
}
