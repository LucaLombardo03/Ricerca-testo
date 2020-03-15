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

namespace Ricerca_testo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncerca_Click(object sender, RoutedEventArgs e)
        {
            string testoiniziale = txttestoiniziale.Text;
            string testodacercare = txttestocercare.Text + ' ';
            if (testoiniziale.Contains(testodacercare))
            {
                int index = testoiniziale.IndexOf(testodacercare);
                int lunghezza = testoiniziale.Length;
                int indexstringa = index + testodacercare.Length;
                int i = index - 1;
                int a = indexstringa;

                if (testoiniziale[index - 1] == ' ')
                {
                    while (i > 0)
                    {
                        i--;
                        if (testoiniziale[i] == ' ')
                        {
                            break;

                        }
                    }

                    while (a < testoiniziale.Length)
                    {

                        a++;
                        if (testoiniziale[a] == ' ')
                        {
                            break;
                        }

                    }


                    string risultato = testoiniziale.Substring(i, a - i);
                    lblfine.Content = $"...{risultato}...";

                }
                else if (testoiniziale[index - 1] != ' ')
                {
                    while (i > 0 || i > testoiniziale.IndexOf(' '))
                    {
                        i--;

                    }

                    while (a < testoiniziale.Length || a < testoiniziale.IndexOf(' '))
                    {
                        a++;

                    }
                }
                string risultato2 = testoiniziale.Substring(i, a - i);
                lblfine.Content = $"...{risultato2}...";

            }
            else
            {
                lblfine.Content = "Impossibile trovare la stringa nel testo";
            }
        }
    }
}
