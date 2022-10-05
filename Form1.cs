using Microsoft.VisualBasic.Devices;
using System;

namespace SSP_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int Spieler = 0;
        static int Computer = 0;

        public static string Dice()
        {
            Random rnd = new Random();
            int Dice = rnd.Next(3);
            string[] Auswahl = { "Schere", "Stein", "Papier" };
            string CompDes = Auswahl[Dice];
            return CompDes;
        }
        public static int StandSp()
        {
            Spieler += 1;
            return Spieler;
        }
        public static int StandCp()
        {
            Computer += 1;
            return Computer;
        }

        public void Zaehler()
        {
            if (Spieler == 5)
            {
                textBox4.Text= "Spieler hat gewonnen.";
                Thread.Sleep(2000);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
            else if (Computer == 5)
            {
                textBox4.Text = "Computer hat gewonnen.";
                Thread.Sleep(2000);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string CompWurf = Dice();
            string SpWurf = "Schere";

            if (CompWurf==SpWurf)
            {
                Zero(SpWurf,CompWurf);
            }
            else if (CompWurf=="Stein")
            {
                StandCp();
                textBox3.Text = $"Spieler: {SpWurf} - Computer: {CompWurf}";
                textBox3.Lines.Append("1000+");
                textBox1.Text = Convert.ToString(Spieler);
                textBox2.Text = Convert.ToString(Computer);
                Zaehler();
            }
            else
            {
                StandSp();
                textBox3.Text = $"Spieler: {SpWurf} - Computer: {CompWurf}";
                textBox3.Lines.Append("1000+");
                textBox1.Text = Convert.ToString(Spieler);
                textBox2.Text = Convert.ToString(Computer);
                Zaehler();
            }
        }
        public void Zero(string SpWurf, string CompWurf)
        {
            textBox3.Text = $"Spieler: {SpWurf} - Computer: {CompWurf}";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string CompWurf = Dice();
            string SpWurf = "Stein";

            if (CompWurf == SpWurf)
            {
                Zero(SpWurf, CompWurf);
            }
            else if (CompWurf == "Papier")
            {
                StandCp();
                textBox3.Text = $"Spieler: {SpWurf} - Computer: {CompWurf}";
                textBox3.Lines.Append("1000+");
                textBox1.Text = Convert.ToString(Spieler);
                textBox2.Text = Convert.ToString(Computer);
                Zaehler();
            }
            else
            {
                StandSp();
                textBox3.Text = $"Spieler: {SpWurf} - Computer: {CompWurf}";
                textBox3.Lines.Append("1000+");
                textBox1.Text = Convert.ToString(Spieler);
                textBox2.Text = Convert.ToString(Computer);
                Zaehler();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string CompWurf = Dice();
            string SpWurf = "Papier";

            if (CompWurf == SpWurf)
            {
                Zero(SpWurf, CompWurf);
            }
            else if (CompWurf == "Schere")
            {
                StandCp();
                textBox3.Text = $"Spieler: {SpWurf} - Computer: {CompWurf}";
                textBox3.Lines.Append("1000+");
                textBox1.Text = Convert.ToString(Spieler);
                textBox2.Text = Convert.ToString(Computer);
                Zaehler();
            }
            else
            {
                StandSp();
                textBox3.Text = $"Spieler: {SpWurf} - Computer: {CompWurf}";
                textBox3.Lines.Append("1000+");
                textBox1.Text = Convert.ToString(Spieler);
                textBox2.Text = Convert.ToString(Computer);
                Zaehler();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            Spieler = 0;
            Computer = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }
    }
}