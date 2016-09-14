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
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                UpbateClientsList(new Wholesaler());
            }
            catch
            {
                UpbateClientsList(new WholesalerMock());
            }
        }

        void UpbateClientsList(IWholesaler Wholesaler)
        {
            List<string> RepresentationList = Wholesaler.WholesalerRepresentationList();
            foreach(string elements in RepresentationList)
            {
                cbClients.Items.Add(elements);
            }
        }
    }
}
