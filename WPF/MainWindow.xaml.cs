using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddEmail_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !names.Items.Contains(txtName.Text))
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                bool isEmail = Regex.IsMatch(txtName.Text, emailPattern);

                if(isEmail)
                {
                    names.Items.Add(txtName.Text);
                    errorText.Text = "Valid E-Mail";
                    txtName.Clear();
                }
                else
                {
                    errorText.Text = "Invalid E-Mail";
                }
            }
        }
    }
}