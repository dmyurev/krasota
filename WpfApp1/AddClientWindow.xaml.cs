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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        krasotaEntities context;
        public AddClientWindow(krasotaEntities context, Client Client)
        {
            InitializeComponent();
            Cmb.ItemsSource = context.Gender.ToList();
            this.context = context;
            this.DataContext = Client;

        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
