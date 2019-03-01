using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ProbabilityCalculator
{
    class CalculateDual
    {
        MainWindow main;

        public void init(MainWindow mainWindow)
        {
            main = mainWindow;
            main.Count_A.Text = "0";
            main.Count_B.Text = "0";
        }

        public void update(object sender)
        {
            try
            {
                var total = double.Parse(main.Count_A.Text) + double.Parse(main.Count_B.Text);
                main.TotalCount.Text = total.ToString();
                if (total != 0)
                {
                    main.Probability_A.Text = string.Format("{0:P}", (double.Parse(main.Count_A.Text) / total));
                    main.Probability_B.Text = string.Format("{0:P}", (double.Parse(main.Count_B.Text) / total));
                }
            }
            catch(FormatException e)
            {
                ((TextBox)sender).Text = "0";
            }
        }
        public void  counter(object sender)
        {
            var btn = ((Button)sender);
            switch (btn.Name)
            {
                case "Plus_A": main.Count_A.Text = (int.Parse(main.Count_A.Text) + 1).ToString();break;
                case "Plus_B": main.Count_B.Text = (int.Parse(main.Count_B.Text) + 1).ToString();break;
                case "Minus_A": main.Count_A.Text = (int.Parse(main.Count_A.Text) - 1).ToString();break;
                case "Minus_B": main.Count_B.Text = (int.Parse(main.Count_B.Text) - 1).ToString();break;
            }
            update(sender);
            
        }
    }
}
