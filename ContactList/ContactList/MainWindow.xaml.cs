using System;
using System.Collections.Generic;
using System.IO;
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

namespace ContactList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<ContactInfo> contacts = new List<ContactInfo>();
            var lines = File.ReadAllLines("contacts.txt");
            foreach (var item in lines)
            {
                contacts.Add(new ContactInfo(item));
            }

            for (int i = 1; i < contacts.Count; i++)
            {
                listBoxContact.Items.Add(contacts[i]);
            }
        }

        private void buttonDetail_Click(object sender, RoutedEventArgs e)
        {
            ContactInfo cInfo = (ContactInfo)listBoxContact.SelectedItem;
            txtFirst.Text = cInfo.FirstName;
            txtLast.Text = cInfo.LastName;
            txtEmail.Text = cInfo.Email;
            var uri = new Uri(cInfo.Photo);
            var img = new BitmapImage(uri);
            imgBox.Source = img;
        }
    }
}
