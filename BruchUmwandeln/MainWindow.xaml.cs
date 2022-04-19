using System.Windows;

namespace BruchUmwandeln
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Input;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Zähler berechnen 
            // Nenner berechnen
            // ergebniss ausgeben als Zäler und Nenner getrennt;
           
            decimal userInput = decimal.Parse(dezimalZahl.Text);


            decimal resultNenner = (userInput * 100);
            decimal resultZaehler = (1 * 100);



            /// 1. Bruch kürzen so weit es geht
            decimal temp = 0;
            decimal ggt = 0;
            decimal tempZaeler = resultZaehler;
            decimal temNenner = resultNenner;
            do
            {

                temp = tempZaeler % temNenner;
                tempZaeler = temNenner;
                temNenner = temp;
            } while (temNenner != 0);
            ggt = tempZaeler;

            resultZaehler = resultZaehler / ggt;
            resultNenner = resultNenner / ggt;
            zaehler.Text = resultZaehler.ToString("G29");
            nenner.Text = resultNenner.ToString();

            // 2. Ganzteil aus dem Bruch extrahieren und separat anzeigen
            if (resultZaehler <= resultNenner)
            {
                int  ganzteil = ((int)(resultNenner / resultZaehler));
                resultNenner = resultNenner - ganzteil * resultZaehler;
                GanzZahl.Text = ganzteil.ToString();
                zaehler.Text = resultZaehler.ToString("G29");
                nenner.Text = resultNenner.ToString();
            }
            else
            {
                GanzZahl.Text = " ";
            }


            
        }
    }
}
