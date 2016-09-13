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
            UpbateClientsList();
        }

        void UpbateClientsList()
        {
            EmExDictionaries.EmExDictionaries emexServices = new EmExDictionaries.EmExDictionaries();
            EmExDictionaries.ConsumerInfo[] clientsList = emexServices.GetConsumersDict(112, "341292ast", null);
            foreach  (EmExDictionaries.ConsumerInfo elements in clientsList)
            {
                cbClients.Items.Add(elements.UserLogo);
            }
        }
    }
}
