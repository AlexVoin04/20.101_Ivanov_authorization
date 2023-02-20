using _20._101_Ivanov_authorization.Classes;
using _20._101_Ivanov_authorization.Model;
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

namespace _20._101_Ivanov_authorization
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

        private void bt_compare_Click(object sender, RoutedEventArgs e)
        {
            Model.Entities db = Helper.GetContext();
            Helper db2 = new Helper();
            var authorization = db.User;

            string login = tb_login.Text;
            string password = tb_password.Text;

            var user = authorization.Where(x => x.UserLogin == login && x.UserPassword == password).FirstOrDefault();

            try
            {
                if (user != null)
                {
                    string role = user.Role.RoleName.ToString();
                    MessageBox.Show($"Добро пожаловать! Ваша роль:{role}");
                }
                else
                {
                    MessageBox.Show("Неверно введены логин или пароль!");
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}"); }
        }
    }
}
