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

namespace cal
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnone_Click(object sender, RoutedEventArgs e)
        {
            if(txtshow.Text=="0")
            txtshow.Text = "";
            txtshow.Text = txtshow.Text + "1";
        }

        private void btnzero_Click(object sender, RoutedEventArgs e)
        {
            if (txtshow.Text == "0")
            txtshow.Text = "";
            txtshow.Text = txtshow.Text + "0";
        }

        private void btntwo_Click(object sender, RoutedEventArgs e)
        {
            if (txtshow.Text == "0")
            txtshow.Text = "";
            txtshow.Text = txtshow.Text + "2";
        }

        private void btnthree_Click(object sender, RoutedEventArgs e)
        {
            if (txtshow.Text == "0")
            txtshow.Text = "";
            txtshow.Text = txtshow.Text + "3";
        }

        private void btnfour_Click(object sender, RoutedEventArgs e)
        {
            if (txtshow.Text == "0")
            txtshow.Text = "";
            txtshow.Text = txtshow.Text + "4";
        }

        private void btnfive_Click(object sender, RoutedEventArgs e)
        {
            if (txtshow.Text == "0")
            txtshow.Text = "";
            txtshow.Text = txtshow.Text + "5";
        }

        private void btnsix_Click(object sender, RoutedEventArgs e)
        {
            if (txtshow.Text == "0")
                txtshow.Text = "";
            txtshow.Text = txtshow.Text + "6";
        }

        private void btnseven_Click(object sender, RoutedEventArgs e)
        {
            if (txtshow.Text == "0")
                txtshow.Text = "";
            txtshow.Text = txtshow.Text + "7";
        }

        private void btneight_Click(object sender, RoutedEventArgs e)
        {
            if (txtshow.Text == "0")
                txtshow.Text = "";
            txtshow.Text = txtshow.Text + "8";
        }

        private void btnnine_Click(object sender, RoutedEventArgs e)
        {
            if (txtshow.Text == "0")
                txtshow.Text = "";
            txtshow.Text = txtshow.Text + "9";
        }
    }
}
