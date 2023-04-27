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
        float firstNumber, secondNumber; // firstNumber 儲存第一個數字，secondNumber 儲存第二個數字
        int operators = -1; // 記錄選擇哪一種運算符號？0:加、1:減、2:乘、3:除、-1:重新設定
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

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtshow.Text); //將輸入文字框轉換成浮點數，存入第一個數字的全域變數
            txtshow.Text = "0"; //重新將輸入文字框重新設定為0
            operators = 0; //選擇「加」號
        }

        private void btnminus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtshow.Text);
            txtshow.Text = "0";
            operators = 1; //選擇「減」號
        }

        private void btnmul_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtshow.Text);
            txtshow.Text = "0";
            operators = 2; //選擇「乘」號
        }

        private void btndiv_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtshow.Text);
            txtshow.Text = "0";
            operators = 3; //選擇「除」號
        }

        private void btnequal_Click(object sender, RoutedEventArgs e)
        {
            float finalResults = 0f; //宣告最後計算結果變數
            secondNumber = Convert.ToSingle(txtshow.Text); //將輸入文字框轉換成浮點數，存入第二個數字的全域變數

            //依照四則運算符號的選擇，進行加減乘除
            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }

            txtshow.Text = string.Format("{0:0.##########}", finalResults); //在輸入文字框中，顯示最後計算結果，並且轉換成格式化的字串內容

            //重置所有全域變數
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }
    }

        
    }

