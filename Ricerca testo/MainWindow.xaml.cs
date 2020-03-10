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
            string testodacercare = txttestocercare.Text;
            bool esiste = testoiniziale.Contains(testodacercare);
            if (esiste == true)
            {
                
            }
            else
                lblfine.Content = (false);
        }
    }
}
