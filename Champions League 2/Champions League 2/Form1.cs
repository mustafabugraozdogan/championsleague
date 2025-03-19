using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Champions_League_2
{
    public partial class Form1 : Form
    {
        List<Takim> takimlar;

        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox>gruplar = new List<ListBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Takim yenitakim = null;

            takimlar = new List<Takim>();

            yenitakim = new Takim("Manchester City","(ENG)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("FC Barcelona", "(ESP)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Real Madrid", "(ESP)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Liverpool", "(ENG)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("İnter", "(ITA)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Borussia Dortmund", "(GER)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Leipzig", "(GER)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Brest", "(FRA)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Bayer Leverkusen", "(GER)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Atletico Madrid", "(ESP)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Atalanta", "(ITA)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Juventus", "(ITA)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Benfica", "(POR)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Arsenal", "(ENG)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Club Brugge", "(BEL)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Shaktar Donetsk", "(UKR)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Milan", "(ITA)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Feyenoord", "(NED)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Sporting Lizbon", "(POR)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("PSV", "(NED)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Dinamo Zagreb", "(CRO)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Salzburg", "(AUT)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Lille", "(FRA)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Kızılyıldız", "(SRB)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Young Boys", "(SUI)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Monaco", "(FRA)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Sparta Prag", "(GER)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Aston Villa", "(ENG)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Bologna", "(ITA)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Girona", "(ESP)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Stuttgart", "(GER)");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Fenerbahçe", "(TUR)");
            takimlar.Add(yenitakim);




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();
            for(int j=0; j<4; j++)
            {
                secilentakimlar.Clear();
                for (int i = 0; i < 8; i++)
                {
                    int secilentakim = rastgele.Next(0,takimlar.Count/4);

                    if (secilentakimlar.Contains(secilentakim))
                    {
                        i--;
                    }
                    else
                    {
                        secilentakimlar.Add(secilentakim);
                    }
                }
                bool ayniulkedentakimvar = false;
                for (int k=0; k<8; k++)
                {
                    ayniulkedentakimvar = Ayniulkedentakimvarmi(gruplar[k], torbalar[j].Items[secilentakimlar[k]] as Takim);
                    if (ayniulkedentakimvar)
                        break;
                }
                if(!ayniulkedentakimvar)
                {
                    listBox1.Items.Add(torbalar[j].Items[secilentakimlar[0]] as Takim);
                    listBox2.Items.Add(torbalar[j].Items[secilentakimlar[1]] as Takim);
                    listBox3.Items.Add(torbalar[j].Items[secilentakimlar[2]] as Takim);
                    listBox4.Items.Add(torbalar[j].Items[secilentakimlar[3]] as Takim);
                    listBox5.Items.Add(torbalar[j].Items[secilentakimlar[4]] as Takim);
                    listBox6.Items.Add(torbalar[j].Items[secilentakimlar[5]] as Takim);
                    listBox7.Items.Add(torbalar[j].Items[secilentakimlar[6]] as Takim);
                    listBox8.Items.Add(torbalar[j].Items[secilentakimlar[7]] as Takim);
                }
                else
                {
                    j--;
                }
            }
        }
        private bool Ayniulkedentakimvarmi(ListBox grup,Takim takim )
        {
            bool durum = false;
            for(int i = 0; i < grup.Items.Count; i++)
            {
                Takim gruptakim = grup.Items[i] as Takim;
                if(gruptakim.TeamCountry == takim.TeamCountry)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();
            for(int i = 0; i<takimlar.Count; i++)
            {
                int secilentakim = rastgele.Next(0,takimlar.Count);
                if(secilentakimlar.Contains(secilentakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilentakim);
                }
            }
            for (int i = 0; i < secilentakimlar.Count; i++)
            {
                if (i < 8)
                {
                    Lsttorba1.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if (i < 16)
                {
                    Listtorba2.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if (i < 24)
                {
                    Listtorba3.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else
                {
                    Listtorba4.Items.Add(takimlar[secilentakimlar[i]]);
                }
            }
            torbalar.Add(Lsttorba1);
            torbalar.Add(Listtorba2);
            torbalar.Add(Listtorba3);
            torbalar.Add(Listtorba4);

            gruplar.Add(listBox1);
            gruplar.Add(listBox2);
            gruplar.Add(listBox3);
            gruplar.Add(listBox4);
            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
            gruplar.Add(listBox8);
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lsttorba1.Items.Clear();
            Listtorba2.Items.Clear();
            Listtorba3.Items.Clear();
            Listtorba4.Items.Clear();

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
        }
    }
}
