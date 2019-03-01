using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ProbabilityCalculator
{
    class SomeCalculate
    {
        MainWindow main;

        public void init(MainWindow mainWindow)
        {
            main = mainWindow;
        }
        public void addPhenomenon()
        {
            Grid grid = new Grid();
            TextBlock title = new TextBlock();
            title.FontSize = 24;
            title.Text = main.Phenomenon.Text;
            TextBox tBox = new TextBox();
            tBox.FontSize = 24;
            tBox.Text = "0";
            tBox.Margin = new Thickness(100,0, 516,0);
            tBox.TextAlignment = TextAlignment.Right;
            TextBlock tBlock = new TextBlock();
            tBlock.FontSize = 24;
            tBlock.Margin = new Thickness(500, 0, 100, 0);
            tBlock.TextAlignment = TextAlignment.Right;
            tBlock.Text = "0.0%";


            grid.Children.Add(title);
            grid.Children.Add(tBox);
            grid.Children.Add(tBlock);
            main.PhenomenonPanel.Children.Add(grid);
        }
    }
}
