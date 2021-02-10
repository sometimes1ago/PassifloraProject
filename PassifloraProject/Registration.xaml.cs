using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        private Window AuthWindow;

        public Registration(Authorization authorization)
        {
            InitializeComponent();
            AuthWindow = authorization;
        }

        private void Registration1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BackLink_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Hide();
            AuthWindow.Show(); 
        }

        /// <summary>
        /// Метод, очищающий текстовые поля после успешной регистарции
        /// </summary>
        private void CleanRegisterInputs()
        {
            SurnameInput.Text = "";
            NameInput.Text = "";
            PhoneInput.Text = "";
            LoginInput.Text = "";
            PasswordInput.Text = "";
            PasswordConfirmInput.Text = "";
        }

        /// <summary>
        /// Обработка события регистрации пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Запрос на добавление нового пользователя
            string RegisterQuery =
                "insert into Пользователи(Логин, Пароль, Роль) values(" + "\'" + LoginInput.Text + "\'" + "," +
                "\'" + PasswordInput.Text + "\'" + "," + "'1')";
            //Получение максимального ID среди пользователей
            string GetMaxUserID = "select max(ID_Пользователя) from Пользователи inner join Роли_Пользователей on Пользователи.Роль = Роли_Пользователей.ID_Роли  where Роли_Пользователей.Наименование = 'Пользователь'";

            try
            {
                if (SurnameInput.Text != "" && NameInput.Text != "" && PhoneInput.Text != "" && LoginInput.Text != "" &&
                    PasswordInput.Text != "" && PasswordConfirmInput.Text != "")
                {
                    if (PasswordInput.Text == PasswordConfirmInput.Text)
                    {
                        DB.Execute(RegisterQuery);
                        DB.SearchValuesQuery(GetMaxUserID);
                        string MaxUserID = DB.ds.Tables[0].Rows[0][0].ToString();

                        //Запрос связывающий данные нового клиента с данными для его авторизации
                        string GiveClientAuthData = "insert into Клиенты(Фамилия, Имя, Телефон, Данные_для_входа) values(" + "\'" +
                            SurnameInput.Text + "\'" + "," + "\'" + NameInput.Text + "\'" + "," + "\'" + PhoneInput.Text + "\'" +
                            "," + "\'" + MaxUserID + "\'" + ")";
                        DB.Execute(GiveClientAuthData);
                        MessageBox.Show("Вы успешно зарегистрировались!");
                        Hide();
                        CleanRegisterInputs();
                        AuthWindow.Show();
                    }
                    else
                    {
                        throw new Exception("Пароли не совпадают!");
                    }

                }
                else
                {
                    throw new Exception("Все поля обязательны для заполнения! Проверьте правильность ввода данных!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
