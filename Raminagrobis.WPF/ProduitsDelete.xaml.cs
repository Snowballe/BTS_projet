﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Raminagrobis.API.Client;
using Raminagrobis.DTO.DTO;

namespace Raminagrobis.WPF
{
    /// <summary>
    /// Logique d'interaction pour FournisseurDelete.xaml
    /// </summary>
    public partial class ProduitsDelete : Page
    {
        public ProduitsDelete()
        {
            InitializeComponent();
        }

        #region LoadPage
        private async void LoadPage(object sender, RoutedEventArgs e)
        {
            var apiclient = new Client("https://localhost:/44345", new HttpClient());
            var produits = await apiclient.ProduitsGetAsync();

            lvProduits.ItemsSource = produits;
        }
        #endregion

        #region BtnProduitsDelete
        public void BtnProduitsDelete(object sender, RoutedEventArgs e)
        {
            var apiclient = new Client("https://localhost:/44345", new HttpClient());
            int ID = Int32.Parse(DeleteID.Text);
            apiclient.ProduitsDeleteAsync(ID);
        }
        #endregion
    }
}
