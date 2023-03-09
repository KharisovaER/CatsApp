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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Метод для регистрации
        /// </summary>
        /// 
        /// <returns></returns>
        public static string RegistrationMethod(string login, string password)
        {
            if (login.Length < 6)
            {
                return "Логин должен содержать больше 6 символов";
            }

            if (password.Length < 8)
            {
                return "Пароль должен содержать больше 8 символов";
            }
            using (Models.CatsDBEntities db = new Models.CatsDBEntities())
            {
                if (db.user.Any(el => el.login == login && el.password == password))
                {
                    return "Такой пользователь уже существует";
                }
                Models.user CurrentUser = new Models.user() { login = login, password = password };
                db.user.Add(CurrentUser);
                db.SaveChanges();
                
            }
            return "Успешно";
        }
        

        

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text, psw1 = Password1Tb.Text, psw2 = Password2Tb.Text;
            if (psw1 == psw2)
            {
                string res = RegistrationMethod(login, psw1);
                if (res == "Успешно")
                {
                    MessageBox.Show("Вы успешно зарегистрировались!");
                }
                else
                {

                    MessageBox.Show(res);
                }
            }
            else
            {
                MessageBox.Show("Пароли должны быть одинаковыми");
            }
        }

        private void BackToAuthBtn_Click(object sender, RoutedEventArgs e)
        {
            Window AuthWin;
            AuthWin = new Windows.Authorization();
            AuthWin.Show();
            this.Hide();
        }
    }
}
