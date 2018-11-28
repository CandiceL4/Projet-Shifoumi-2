using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace shifoumi
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int score = 0;
        int score1 = 0;
        string choixJoueur;
        string choixOrdinateur;
        Random random = new Random();
        List<string> ordi = new List<string> { "pierre", "fueille", "ciseau" };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            choixJoueur = "pierre";
            textBlock.Text = "vous avez choisi Pierre ";
            textBox.Text = ("L' ordi a choisi de " + ChoixAleatoire());
            Gagnant();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            {
                choixJoueur = "fueille";
                textBlock.Text = "vous avez choisi feuille ";
                textBox.Text = ("L' ordi a choisi de " + ChoixAleatoire());
                Gagnant();
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            {
                choixJoueur = "ciseau";
                textBlock.Text = "vous avez choisi Ciseau ";
                textBox.Text = ("L' ordi a choisi de " + ChoixAleatoire());
                Gagnant();
            }
        }

        private string ChoixAleatoire()
        {
            choixOrdinateur = ordi[random.Next(30) / 10];
            return choixOrdinateur;
        }

        private void Gagnant()
        {

            if (choixJoueur == "pierre")
            {
                if (choixOrdinateur == "pierre")
                    textBlock1.Text = "Egalité ";

                else if (choixOrdinateur == "fueille")
                {
                    textBlock1.Text = "Perdu";
                    score++;
                }
                else if (choixOrdinateur == "ciseau")
                {
                    textBlock1.Text = "Gagner";
                    score1++;
                }
            }   



            if (choixJoueur == "fueille")
            {
                if (choixOrdinateur == "pierre")
                {
                    textBlock1.Text = "Gagner ";
                    score1++;
                }
                else if (choixOrdinateur == "fueille")
                    textBlock1.Text = "Egalite";
                else if (choixOrdinateur == "ciseau")
                {
                    textBlock1.Text = "Perdu";
                    score++;
                }
            }


            if (choixJoueur == "ciseau")
            {
                if (choixOrdinateur == "pierre")
                {
                    textBlock1.Text = "Perdue ";
                    score++;
                }
                else if (choixOrdinateur == "fueille")
                {
                    textBlock1.Text = "Gagner";
                    score1++;
                }
                else if (choixOrdinateur == "ciseau")
                    textBlock1.Text = "Egalite";
            }

            textBlock2.Text = ("joueur : " + score1);
            textBlock3.Text = ("ordi :" + score);
        }

    }

}


