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
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        krasotaEntities context;
        public ClientWindow()
        {
            InitializeComponent();
            context = new krasotaEntities();
            ShowTable();
        }

        private void ShowTable()
        {
            Clientbd.ItemsSource = context.Client.ToList();
        }
        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {

        }


        private void BtnDeletedata_Click(object sender, RoutedEventArgs e)
        {
            var currentRental = Clientbd.SelectedItem as Client;
            if (currentRental == null)
            {
                MessageBox.Show("Выберите строку!");
                return;

            }
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удадить эту строку?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                context.Client.Remove(currentRental);
                context.SaveChanges();
                ShowTable();
            }
        }

        private void BtnAdeteData_Click(object sender, RoutedEventArgs e)
        {
            var NewClient = new Client();
            context.Client.Add(NewClient);
            var AddClientWindow = new AddClientWindow(context, NewClient);
            AddClientWindow.ShowDialog();
        }
    }
}
