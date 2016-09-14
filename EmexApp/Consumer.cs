using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmexApp
{
    class Consumer
    {
        public int login;
        public string password;

        public Consumer()
        {
            login = Properties.Settings.Default.Login;
            password = Properties.Settings.Default.Password;
        }

        public void SaveCustomerInfo(int Login, string Password)
        {
            Properties.Settings.Default.Login = Login;
            Properties.Settings.Default.Password = Password;
            Properties.Settings.Default.Save();
        }
    }
}