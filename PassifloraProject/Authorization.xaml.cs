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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        private Window FormToOpen;
        private bool IsCorrect = false;
        private string UserRole;
        private string GetLoginData = "select Пользователи.Логин, Пользователи.Пароль, Роли_Пользователей.Наименование from Пользователи inner join Роли_Пользователей on Пользователи.Роль = Роли_Пользователей.ID_Роли";

        public Authorization(Products prod)
        {
            InitializeComponent();
            FormToOpen = prod;

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BackControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Hide();
            FormToOpen.Show();
        }

        private void RegisterLink_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Registration reg = new Registration(this);
            Hide();
            reg.Show();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.SearchValuesQuery(GetLoginData);

                for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
                {
                    if (LoginInput.Text == DB.ds.Tables[0].Rows[i][0].ToString() && PasswordInput.Text == DB.ds.Tables[0].Rows[i][1].ToString())
                    {
                        UserRole = DB.ds.Tables[0].Rows[i][2].ToString();
                        DB.SetAuthorizedUser(DB.ds.Tables[0].Rows[i][0].ToString());
                        IsCorrect = true;

                        switch (UserRole)
                        {
                            case "Пользователь":
                                Hide();
                                FormToOpen.Show();
                                break;
                            case "Кассир":
                                Hide();
                                Cashier cash = new Cashier(this);
                                cash.Show();
                                break;
                            case "Администратор":
                                Hide();
                                Administrator admin = new Administrator(this);
                                admin.Show();
                                break;
                        }
                    } 
                }
                if (!IsCorrect)
                {
                    throw new Exception("Неправильный логин или пароль");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
