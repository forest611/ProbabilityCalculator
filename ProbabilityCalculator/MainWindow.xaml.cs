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

namespace ProbabilityCalculator
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        CalculateDual calc;
        SomeCalculate some;
        public MainWindow()
        {
            InitializeComponent();
            calc = new CalculateDual();
            some = new SomeCalculate();
            calc.init(this);
            some.init(this);
        }

        private void Changed_CountA(object sender, TextChangedEventArgs e)
        {
            calc.update(sender);
        }

        private void Changed_CountB(object sender, TextChangedEventArgs e)
        {
            calc.update(sender);
        }

        private void Clicked(object sender, RoutedEventArgs e)
        {
            calc.counter(sender);
        }

        private void Clicked_Add(object sender, RoutedEventArgs e)
        {
            some.addPhenomenon();
        }
    }
}
