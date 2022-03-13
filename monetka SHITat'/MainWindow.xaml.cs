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

namespace monetka_SHITat_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Summa summa;
        private Euro euro;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            summa = new Summa(double.Parse(NominalKypyr.Text),
                              double.Parse(KolvoKypyr.Text));
            Result.Text = summa.Print();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            euro = new Euro(double.Parse(NominalKypyr.Text),
                            double.Parse(KolvoKypyr.Text));
            Result2.Text = euro.Print();
        }
    }



    //double x = double.Parse(NominalKypyr.Text);
    //double y = double.Parse(KolvoKypyr.Text);
    //double a = x * y;
    //Result.Text = $"Сумма купюр равна: {a}";
}
