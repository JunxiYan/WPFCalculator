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

namespace WpfCalculator
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text  += "1";
        }

        private void Solution_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += "2";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += "3";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += "6";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += "9";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += "0";
        }

        private void ButtonPoint_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += ".";
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += "+";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += "-";
        }

        private void ButtonMulti_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += "*";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += "/";
        }

        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            if (textblock.Text != "")
                textblock.Text = textblock.Text.Remove(textblock.Text.Length - 1);
        }

        private void ButtonChangeMark_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text = textblock.Text.Insert(0, "-");
        }

        private void ButtonLeftParen_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += "(";
        }

        private void ButtonRightParen_Click(object sender, RoutedEventArgs e)
        {
            textblock.Text += ")";
        }
    }
}