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
    }
}
