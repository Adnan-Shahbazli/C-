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
using System.Data;

namespace First_Ui_Project_From_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement el in MainRoot.Children)
            {
                if (el is Button)
                {
                    ((Button) el).Click += ButtomClick;
                }
            }
        }

        private void ButtomClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            string str = btn.Content.ToString();

            if (str == "AC")
            {
                Result.Text = "";
            }
            else if (str == "=")
            {
                try
                {
                    string value = new DataTable().Compute(Result.Text, null).ToString();
                    Result.Text = value;
                }
                catch (DivideByZeroException)
                {
                    Result.Text = "Error";
                }
                catch
                {
                    Result.Text = "Error";
                }

            }
            else
            {
                Result.Text += str;
            }
        }
    }
}
