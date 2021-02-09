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

namespace PassifloraProject
{
    /// <summary>
    /// Логика взаимодействия для Products.xaml
    /// </summary>
    public partial class Products : Window
    {
        public Products()
        {
            InitializeComponent();
            CheckAuthorizedUser();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        //Добавить возможность вернуться обратно
        private void LoginRegisterLink_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (LoginRegisterLink.Text == "Вход / Регистрация")
            {
                Authorization auth = new Authorization(this);
                Hide();
                auth.Show();
            }
        }


        /// <summary>
        /// Метод, проверяющий есть ли авторизованные пользователи
        /// </summary>
        private void CheckAuthorizedUser()
        {
            if (DB.AuthorizedUser == null)
            {
                LoginRegisterLink.Text = "Вход / Регистрация";
                LoginRegisterIcon.Visibility = Visibility.Visible;
            }
            else
            {
                DB.SearchValuesQuery("select Имя from Клиенты inner join Пользователи on Клиенты.Данные_для_входа = Пользователи.ID_Пользователя where Пользователи.Логин =" + "\'" + DB.AuthorizedUser + "\'");
                LoginRegisterContainer.Width = 250;
                LoginRegisterContainer.Margin = new Thickness(130, 29, 30, 0);
                LoginRegisterLink.Width = 250;
                LoginRegisterIcon.Visibility = Visibility.Hidden;
                LoginRegisterLink.Text = "Здравствуйте, " + DB.ds.Tables[0].Rows[0][0].ToString();
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            CheckAuthorizedUser();
        }
    }
}
