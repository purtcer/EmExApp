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
using EmexApp.EmExDictionaries;

namespace EmexApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IWholesaler Wholesaler;
        private IInmConsumer InmConsumer;
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                Wholesaler = new Wholesaler();
            }
            catch
            {
                Wholesaler = new WholesalerMock();
            }
            try
            {
                InmConsumer = new InmConsumer();
            }
            catch
            {
                InmConsumer = new InmConsumerMock();
            }
            UpbateClientsList();
        }

        void UpbateClientsList()
        {
            List<string> RepresentationList = Wholesaler.WholesalerRepresentationList();
            foreach(string elements in RepresentationList)
            {
                cbClients.Items.Add(elements);
            }
        }

        private void cbClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StaticVariables.WholesalerElement WholesalerElement = Wholesaler.WholesalerElement(cbClients.SelectedIndex);
            dgInmConsumer.ItemsSource = InmConsumer.InmConsumerList(WholesalerElement);
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            StaticVariables.WholesalerElement WholesalerElement = Wholesaler.WholesalerElement(cbClients.SelectedIndex);
            List<InmConsumerDefault> MainInmConsumerList = InmConsumer.InmConsumerList(WholesalerElement);
            PrintDetailList printDetailsList = new PrintDetailList(MainInmConsumerList);
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsForm frmSettings = new SettingsForm();
            frmSettings.Show();
        }
    }
}
