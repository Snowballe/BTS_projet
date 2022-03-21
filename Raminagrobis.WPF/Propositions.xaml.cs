using Raminagrobis.API.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace Raminagrobis.WPF
{
    /// <summary>
    /// Logique d'interaction pour Paniers.xaml
    /// </summary>
    public partial class Propositions : Page
    {
        public Propositions()
        {
            InitializeComponent();
        }
        
        #region LoadPage
        private async void LoadPage(object sender, RoutedEventArgs e)
        {
            var apiclient = new Client("https://localhost:44345", new HttpClient());
            var produits = await apiclient.PropositionsGetAsync();

            lvProduits.ItemsSource = produits;
        }
        #endregion

    }
}
