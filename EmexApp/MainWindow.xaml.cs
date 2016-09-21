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
        private IInmotion Inmotion;
        public MainWindow()
        {
            InitializeComponent();
            Consumer consumerObject = new Consumer();
            if (consumerObject.password.Length > 0)
            {
                InitializeWorkSpace();
            }
            else
            {
                Wholesaler = new WholesalerMock();
                InmConsumer = new InmConsumerMock();
                Inmotion = new InmotionMock();
            }
            UpbateClientsList();
        }

        void InitializeWorkSpace()
        {
            try
            {
                Wholesaler = new Wholesaler();
            }
            catch
            {
                Wholesaler = new WholesalerMock();
            }
            
                InmConsumer = new InmConsumer();
            
            try
            {
                Inmotion = new Inmotion();
            }
            catch
            {
                Inmotion = new InmotionMock();
            }
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

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            StaticVariables.InmotionElement inmotionElement;
            List<StaticVariables.InmotionElement> inmotionElements = new List<StaticVariables.InmotionElement>();
            if (dgInmConsumer.ItemsSource != null)
            {
                foreach (InmConsumerDefault elementData in dgInmConsumer.ItemsSource)
                {
                    if (elementData.IsChecked & elementData.AccQuantity != 0)
                    {
                        inmotionElement = new StaticVariables.InmotionElement();
                        inmotionElement.Count = elementData.AccQuantity;
                        inmotionElement.GlobalId = elementData.GlobalId;
                        inmotionElement.State = 8;
                        inmotionElements.Add(inmotionElement);
                    }
                }
            }
            if (inmotionElements.Count > 0)
            {
                Inmotion.SetInmotionState(inmotionElements);
            }
        }
    }
}
