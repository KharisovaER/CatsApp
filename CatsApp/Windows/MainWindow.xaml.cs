﻿using System;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Если вы видите это сообщение, значит разработчик фокин дэд. Разработано Харисовой Эльвирой, группа 4438" );
        }

        private void PersonalCabBtn_Click(object sender, RoutedEventArgs e)
        {
            Window PersCab;
            PersCab = new Windows.PersonalCabinetWindow();
            PersCab.Show();
            this.Hide();
        }

        private void CatsListBtn_Click(object sender, RoutedEventArgs e)
        {
            Window CatsWindow;
            CatsWindow = new Windows.CatsWindow();
            CatsWindow.Show();
            this.Hide();
        }
    }
}
