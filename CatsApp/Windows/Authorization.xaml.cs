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
using System.Windows.Shapes;

namespace CatsApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        public static string AuthorizationMethod(string login, string password)
        {
            using (Models.CatsDBEntities db = new Models.CatsDBEntities())
            {
                Models.user user = db.user.FirstOrDefault(el => el.login == login && el.password == password);

                if (user != null)
                {
                    return "Успешно";
                }
            }

            return "Пользователь не найден";

        }

       

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text, password = PasswordTb.Text;
            string res = AuthorizationMethod(login, password);
            if (res == "Успешно")
            {
                Windows.MainWindow u1 = new Windows.MainWindow();
                u1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(res);
            }
        }

        private void ToRegBtn_Click(object sender, RoutedEventArgs e)
        {
            Window RegWin;
            RegWin = new Windows.Registration();
            RegWin.Show();
            this.Hide();
        }
    }
}
