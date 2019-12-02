﻿using System;
using System.Windows.Forms;

namespace PuzzleQuest
{
    public partial class PuzzleQuest : Form
    {
        Button[,] karty = new Button[8, 8];
        public PuzzleQuest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void otworzInterfaceStworzPostac()

        {

            Application.Run(new Stworz_Postac());

        }
        private void otworzMape()

        {

            Application.Run(new Mapa());

        }

        private void Nowa_Gra_Click(object sender, EventArgs e)
        {
            System.Threading.Thread mapa =
                new System.Threading.Thread(new System.Threading.ThreadStart(otworzMape));
            //uruchomienie nowego wątku

            mapa.Start();

            //zamknięcie starego wątku

            Application.ExitThread();
            
            

        }

        private void Najlepsi_Gracze_Click(object sender, EventArgs e)
        {

        }

        private void O_Grze_Click(object sender, EventArgs e)
        {

        }

        private void Wyjscie_Click(object sender, EventArgs e)
        {
            string wiadomosc = "Czy na pewno chcesz wyjsc?";
            string tytul = "Wyjscie";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult rezultat = MessageBox.Show(wiadomosc,tytul,button);
            if(rezultat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Stworz_Postac_Click(object sender, EventArgs e)
        {
            System.Threading.Thread zaloguj =
                new System.Threading.Thread(new System.Threading.ThreadStart(otworzInterfaceStworzPostac));


            //uruchomienie nowego wątku


            zaloguj.Start();


            //zamknięcie starego wątku


            Application.ExitThread();
        }

        private void Zaloguj_Sie_Click(object sender, EventArgs e)
        {

            this.Hide();
            Logowanie aa = new Logowanie();
            aa.Show();

        }

        private void Nowa_Gra_MouseUp(object sender, MouseEventArgs e)
        {
            Gif1.Load("C:\\Users\\kaczy\\OneDrive\\Pulpit\\Git\\PuzzleQuest\\PuzzleQuest\\Resources\\ogien.gif");
            Gif11.Load("C:\\Users\\kaczy\\OneDrive\\Pulpit\\Git\\PuzzleQuest\\PuzzleQuest\\Resources\\ogien.gif");
        }

        private void Nowa_Gra_MouseLeave(object sender, EventArgs e)
        {
            Gif1.Image = null;
            Gif11.Image = null;
        }

        private void Stworz_Postac_MouseMove(object sender, MouseEventArgs e)
        {
            Gif2.Load("C:\\Users\\kaczy\\OneDrive\\Pulpit\\Git\\PuzzleQuest\\PuzzleQuest\\Resources\\ogien.gif");
            Gif22.Load("C:\\Users\\kaczy\\OneDrive\\Pulpit\\Git\\PuzzleQuest\\PuzzleQuest\\Resources\\ogien.gif");
        }

        private void Stworz_Postac_MouseLeave(object sender, EventArgs e)
        {
            Gif2.Image = null;
            Gif22.Image = null;
        }

        private void Gif3_MouseMove(object sender, MouseEventArgs e)
        {
            Gif3.Load("C:\\Users\\kaczy\\OneDrive\\Pulpit\\Git\\PuzzleQuest\\PuzzleQuest\\Resources\\ogien.gif");
            Gif33.Load("C:\\Users\\kaczy\\OneDrive\\Pulpit\\Git\\PuzzleQuest\\PuzzleQuest\\Resources\\ogien.gif");
        }

        private void Gif3_MouseLeave(object sender, EventArgs e)
        {
            Gif3.Image = null;
            Gif33.Image = null;
        }

        private void Najlepsi_Gracze_MouseMove(object sender, MouseEventArgs e)
        {
            Gif4.Load("C:\\Users\\kaczy\\OneDrive\\Pulpit\\Git\\PuzzleQuest\\PuzzleQuest\\Resources\\ogien.gif");
            Gif44.Load("C:\\Users\\kaczy\\OneDrive\\Pulpit\\Git\\PuzzleQuest\\PuzzleQuest\\Resources\\ogien.gif");
        }

        private void Najlepsi_Gracze_MouseLeave(object sender, EventArgs e)
        {
            Gif4.Image = null;
            Gif44.Image = null;
        }

        private void O_Grze_MouseMove(object sender, MouseEventArgs e)
        {
            Gif5.Load("C:\\Users\\kaczy\\OneDrive\\Pulpit\\Git\\PuzzleQuest\\PuzzleQuest\\Resources\\ogien.gif");
            Gif55.Load("C:\\Users\\kaczy\\OneDrive\\Pulpit\\Git\\PuzzleQuest\\PuzzleQuest\\Resources\\ogien.gif");
        }

        private void O_Grze_MouseLeave(object sender, EventArgs e)
        {
            Gif5.Image = null;
            Gif55.Image = null;
        }

        private void Wyjscie_MouseMove(object sender, MouseEventArgs e)
        {
            Gif6.Load("C:\\Users\\kaczy\\OneDrive\\Pulpit\\Git\\PuzzleQuest\\PuzzleQuest\\Resources\\ogien.gif");
            Gif66.Load("C:\\Users\\kaczy\\OneDrive\\Pulpit\\Git\\PuzzleQuest\\PuzzleQuest\\Resources\\ogien.gif");
        }

        private void Wyjscie_MouseLeave(object sender, EventArgs e)
        {
            Gif6.Image = null;
            Gif66.Image = null;
        }
    }
}