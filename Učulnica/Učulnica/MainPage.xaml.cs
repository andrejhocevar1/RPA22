using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Učulnica
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Poglavja> VsaPoglavja { get; set; }
        public ObservableCollection<Module> Vsebina { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            VsaPoglavja = new ObservableCollection<Poglavja>();
            Vsebina = new ObservableCollection<Module>();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            mojP.IsActive = true;
            mojP.Visibility = Visibility.Visible;
            await KlicServisa.PopulatePoglavjaAsync(VsaPoglavja);
            mojP.IsActive = false;
            mojP.Visibility = Visibility.Collapsed;
            masterListView.SelectedIndex = 0;

            var selectedPoglavje = VsaPoglavja.FirstOrDefault();
            Vsebina = selectedPoglavje.modules;
            //ne pozabi spremeniti ItemsSource(od novega)
            detailListView.ItemsSource = null;
            detailListView.ItemsSource = Vsebina;
        }

        private void masterListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedPoglavje = (Poglavja)e.ClickedItem;
            Vsebina = selectedPoglavje.modules;
            //ne pozabi spremeniti ItemsSource(od novega)
            detailListView.ItemsSource = null;
            detailListView.ItemsSource = Vsebina;
        }

        private async void detailListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedModule = (Module)e.ClickedItem;
            if (selectedModule.modname == "resource")
            {
                var vesContent = selectedModule.contents;
                Content a = vesContent.FirstOrDefault();
                string[] izbrana = a.fileurl.Split('?');
                int dolžina = a.filesize;
                var y = await KlicServisa.PoberiDatoteko(izbrana[0], dolžina, a.filename);
                if (y != null)
                {
                    var uspeh = await Windows.System.Launcher.LaunchFileAsync(y);
                }
            }
        }
    }
}
