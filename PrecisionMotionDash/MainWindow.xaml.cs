using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace PrecisionMotionDash
{
    public partial class MainWindow : Window
    {
        // 自動升溫計時器
        DispatcherTimer tempTimer = new DispatcherTimer();
        double currentTemp = 25.0;
        double lastPosition = 0;

        public MainWindow()
        {
            InitializeComponent();

            // 設定計時器，每 0.5 秒偵測一次馬達狀態
            tempTimer.Interval = TimeSpan.FromMilliseconds(500);
            tempTimer.Tick += TempTimer_Tick;
            tempTimer.Start();
        }

        // 馬達熱損耗監控邏輯
        private void TempTimer_Tick(object sender, EventArgs e)
        {
            double currentPos = sldPosition.Value;

            if (Math.Abs(currentPos - lastPosition) > 0.001)
            {
                // 馬達在動 -> 升溫 (模擬線性馬達高頻作動發熱)
                currentTemp += 0.8;
                txtStatus.Text = "馬達運轉中 - 精密位移校準中";
            }
            else
            {
                // 馬達靜止 -> 降溫 (最低降至室溫 25 度)
                if (currentTemp > 25.0) currentTemp -= 0.3;
                txtStatus.Text = "馬達靜止 - 保持待機狀態";
            }

            lastPosition = currentPos;
            txtTemp.Text = currentTemp.ToString("F1") + " °C";

            // 過熱預警邏輯 
            if (currentTemp > 60)
            {
                txtTemp.Foreground = Brushes.OrangeRed;
                txtWarning.Text = " [過熱預警]";
                txtWarning.Foreground = Brushes.OrangeRed;
            }
            else
            {
                txtTemp.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4ADE80"));
                txtWarning.Text = " [正常]";
                txtWarning.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4ADE80"));
            }
        }

        private void sldPosition_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (txtPosition != null)
            {
                txtPosition.Text = e.NewValue.ToString("F3");
            }

            
            if (txtCost != null)
            {
               
                double cost = e.NewValue * 0.0005;
                txtCost.Text = "$ " + cost.ToString("F2");
            }
        }

        // 報價工具按鈕
        private void btnQuote_Click(object sender, RoutedEventArgs e)
        {
            
            double length = sldPosition.Value;
            double basePrice = 500; 
            double totalPrice = basePrice + (length * 0.1); // 長度加成
            double margin = 0.35; 

            string report = $"【精密零件即時報價】\n" +
                            $"當前滑軌設定長度: {length:F2} mm\n" +
                            $"估算生產成本: ${totalPrice:F2}\n" +
                            $"建議銷售價格 (含 {margin:P0} 毛利): ${(totalPrice / (1 - margin)):F2}";

            MessageBox.Show(report, "財務決策支援系統");
        }
    }
}