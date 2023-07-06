using Data;
using System;
using System.Collections.Generic;
using System.Data;
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


namespace Names
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool addNameButtonToggle;
        public MainWindow()
        {
            InitializeComponent();
            addNameButtonToggle = false;
            Addresses addresses = new Addresses();
            addressGrid.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = addresses.addresses });
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                Button sendingButton = (Button)sender;
                AddName(txtName.Text);
                if (!addNameButtonToggle)
                {
                    sendingButton.Style = (Style)Resources["toggledButton"];
                    addNameButtonToggle = true;
                }
                else
                {
                    sendingButton.Style = (Style)Resources["genericButton"];
                    addNameButtonToggle = false;
                }
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                AddName(txtName.Text);
            }
        }

        private void AddName(string name)
        {
            name = name.Trim();
            if (!lstNames.Items.Contains(name))
            {
                lstNames.Items.Add(name);
                txtName.Clear();
                txtName.Focus();
            }
            else
            {
                txtName.SelectAll();
            }
        }

    }
}
