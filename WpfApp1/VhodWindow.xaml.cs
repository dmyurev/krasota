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


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для VhodWindow.xaml
    /// </summary>
    public partial class VhodWindow : Window
    {
        krasotaEntities context;
        public VhodWindow()
        {
            InitializeComponent();
            context = new krasotaEntities();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            var user = context.Client.FirstOrDefault(u => ("1" == Login.Text || "1" == Password.Text));
            if (user == null)
            {
                MessageBox.Show("Неверные данные");
                return;
            }
            else
            {
                if (user.ID == 1)
                {
                    MessageBox.Show("Привет");
                    var admin = new MainWindow();
                    admin.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Привет");
                    var tables = new MainWindow();
                    tables.Show();
                    this.Close();
                }
            }
        }
    


private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
