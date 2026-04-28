using System;
using System.Windows;

namespace PrecisionMotionDash
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // 當滑桿數值改變時觸發
        private void sldPosition_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
            if (txtPosition != null)
            {
                txtPosition.Text = e.NewValue.ToString("F3");
            }

           
            // 假設每移動 1μm 會產生 $0.001 的電力/磨耗成本
            if (txtCost != null)
            {
                double cost = e.NewValue * 0.001;
                txtCost.Text = "$ " + cost.ToString("F2");
            }
        }
    }
}