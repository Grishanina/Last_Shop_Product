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
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для WindowPage.xaml
    /// </summary>
    public partial class WindowPage : Window
    {
        public WindowPage()
        {
            InitializeComponent();
            DoubleAnimation WA = new DoubleAnimation();
            WA.From = 100;
            WA.To = 160;
            WA.Duration = TimeSpan.FromSeconds(2);
            WA.RepeatBehavior = RepeatBehavior.Forever;
            WA.AutoReverse = true;
            Klubnika.BeginAnimation(WidthProperty, WA);

            DoubleAnimation WH = new DoubleAnimation();
            WH.From = 100;
            WH.To = 160;
            WH.Duration = TimeSpan.FromSeconds(2);
            WH.RepeatBehavior = RepeatBehavior.Forever;
            WH.AutoReverse = true;
            Klubnika.BeginAnimation(HeightProperty, WH);

			DoubleAnimation WA1 = new DoubleAnimation();
			WA1.From = 50;
			WA1.To = 100;
			WA1.Duration = TimeSpan.FromSeconds(2);
			WA1.RepeatBehavior = RepeatBehavior.Forever;
			WA1.AutoReverse = true;
			Moni.BeginAnimation(WidthProperty, WA1);

			DoubleAnimation WH1 = new DoubleAnimation();
			WH1.From = 50;
			WH1.To = 100;
			WH1.Duration = TimeSpan.FromSeconds(2);
			WH1.RepeatBehavior = RepeatBehavior.Forever;
			WH1.AutoReverse = true;
			Moni.BeginAnimation(HeightProperty, WH1);

			DoubleAnimation WA2 = new DoubleAnimation();
			WA2.From = 50;
			WA2.To = 100;
			WA2.Duration = TimeSpan.FromSeconds(2);
			WA2.RepeatBehavior = RepeatBehavior.Forever;
			WA2.AutoReverse = true;
			Moni1.BeginAnimation(WidthProperty, WA2);

			DoubleAnimation WH2 = new DoubleAnimation();
			WH2.From = 50;
			WH2.To = 100;
			WH2.Duration = TimeSpan.FromSeconds(2);
			WH2.RepeatBehavior = RepeatBehavior.Forever;
			WH2.AutoReverse = true;
			Moni1.BeginAnimation(HeightProperty, WH2);

			DoubleAnimation FS = new DoubleAnimation();
            FS.From = 16;
            FS.To = 22;
            FS.Duration = TimeSpan.FromSeconds(2);
            FS.RepeatBehavior = RepeatBehavior.Forever;
            FS.AutoReverse = true;
            tb1.BeginAnimation(FontSizeProperty, FS);

            DoubleAnimation FSS = new DoubleAnimation();
            FSS.From = 16;
            FSS.To = 28;
            FSS.Duration = TimeSpan.FromSeconds(2);
            FSS.RepeatBehavior = RepeatBehavior.Forever;
            FSS.AutoReverse = true;
            tb2.BeginAnimation(FontSizeProperty, FSS);

            DoubleAnimation FSFS = new DoubleAnimation();
            FSFS.From = 16;
            FSFS.To = 22;
            FSFS.Duration = TimeSpan.FromSeconds(2);
            FSFS.RepeatBehavior = RepeatBehavior.Forever;
            FSFS.AutoReverse = true;
            tb3.BeginAnimation(FontSizeProperty, FSFS);

            ThicknessAnimation MA = new ThicknessAnimation();
            MA.From = new Thickness(0, 40, 0, 0);
            MA.To = new Thickness(0, 10, 0, 0);
            MA.Duration = TimeSpan.FromSeconds(2);
            MA.RepeatBehavior = RepeatBehavior.Forever;
            MA.AutoReverse = true;
            tb1.BeginAnimation(MarginProperty, MA);

			ColorAnimation BAA = new ColorAnimation();
			ColorConverter CCA = new ColorConverter();
			Color CstartA = (Color)CCA.ConvertFrom("#fc49a0");
			bor1.BorderBrush = new SolidColorBrush(CstartA);
			BAA.From = CstartA;
			BAA.To = (Color)CCA.ConvertFrom("#962eff");
			BAA.Duration = TimeSpan.FromSeconds(0.5);
			BAA.RepeatBehavior = RepeatBehavior.Forever;
			BAA.AutoReverse = true;

			bor1.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, BAA);
			ColorAnimation BAB = new ColorAnimation();
			ColorConverter CCB = new ColorConverter();
			Color CstartB = (Color)CCB.ConvertFrom("#962eff");
			bor2.BorderBrush = new SolidColorBrush(CstartB);
			BAB.From = CstartB;
			BAB.To = (Color)CCB.ConvertFrom("#fc49a0");
			BAB.Duration = TimeSpan.FromSeconds(0.5);
			BAB.RepeatBehavior = RepeatBehavior.Forever;
			BAB.AutoReverse = true;
			bor2.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, BAB);

			ColorAnimation BB = new ColorAnimation();
            ColorConverter CB = new ColorConverter();
            Color Bstart = (Color)CB.ConvertFrom("#2eff35");
			tb1.Foreground = new SolidColorBrush(Bstart);
            BB.From = Bstart;
            BB.To = (Color)CB.ConvertFrom("#fc1212");
            BB.Duration = TimeSpan.FromSeconds(2);
			BB.RepeatBehavior = RepeatBehavior.Forever;
			BB.AutoReverse = true;
			tb1.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, BB);

			ColorAnimation BB1 = new ColorAnimation();
			ColorConverter CB1 = new ColorConverter();
			Color Bstart1 = (Color)CB1.ConvertFrom("#0f86fc");
			tb2.Foreground = new SolidColorBrush(Bstart1);
			BB1.From = Bstart1;
			BB1.To = (Color)CB1.ConvertFrom("#fc0f46");
			BB1.Duration = TimeSpan.FromSeconds(0.5);
			BB1.RepeatBehavior = RepeatBehavior.Forever;
			BB1.AutoReverse = true;
			tb2.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, BB1);

			ColorAnimation BB2 = new ColorAnimation();
			ColorConverter CB2 = new ColorConverter();
			Color Bstart2 = (Color)CB2.ConvertFrom("#b10ffc");
			tb3.Foreground = new SolidColorBrush(Bstart2);
			BB2.From = Bstart2;
			BB2.To = (Color)CB1.ConvertFrom("#fc1273");
			BB2.Duration = TimeSpan.FromSeconds(2);
			BB2.RepeatBehavior = RepeatBehavior.Forever;
			BB2.AutoReverse = true;
			tb3.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, BB2);
		}
    }
}
