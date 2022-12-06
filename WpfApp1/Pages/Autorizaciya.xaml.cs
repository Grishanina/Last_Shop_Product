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
using System.Windows.Media.Animation;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autorizaciya.xaml
    /// </summary>
    public partial class Autorizaciya : Page
    {
        public Autorizaciya()
        {
            InitializeComponent();
            DoubleAnimation WA = new DoubleAnimation(); 
            WA.From = 140; 
            WA.To = 200; 
            WA.Duration = TimeSpan.FromSeconds(1); 
            WA.RepeatBehavior = RepeatBehavior.Forever; 
            WA.AutoReverse = true; 
            Btn4.BeginAnimation(WidthProperty, WA); 

            DoubleAnimation WH = new DoubleAnimation(); 
            WH.From = 24; 
            WH.To = 40;
            WH.Duration = TimeSpan.FromSeconds(2); 
            WH.RepeatBehavior = RepeatBehavior.Forever; 
            WH.AutoReverse = true; 
            Btn4.BeginAnimation(HeightProperty, WH);

            DoubleAnimation FS = new DoubleAnimation();
            FS.From = 16;
            FS.To = 28;
            FS.Duration = TimeSpan.FromSeconds(2);
            FS.RepeatBehavior = RepeatBehavior.Forever;
            FS.AutoReverse = true;
            Btn4.BeginAnimation(FontSizeProperty, FS);

            ThicknessAnimation MA = new ThicknessAnimation();
            MA.From = new Thickness(0, 25, 0, 25);
            MA.To = new Thickness(0, 15, 0, 15);
            MA.Duration = TimeSpan.FromSeconds(2);
            MA.RepeatBehavior = RepeatBehavior.Forever;
            MA.AutoReverse = true;
            Btn4.BeginAnimation(MarginProperty, MA);

            ColorAnimation BA = new ColorAnimation(); 
            ColorConverter CC = new ColorConverter(); 
            Color Cstart = (Color)CC.ConvertFrom("#ffd000"); 
            Btn4.Background = new SolidColorBrush(Cstart); 
            BA.From = Cstart; 
            BA.To = (Color)CC.ConvertFrom("#ff0077"); 
            BA.Duration = TimeSpan.FromSeconds(0.5);
            BA.RepeatBehavior = RepeatBehavior.Forever;
            BA.AutoReverse = true;
            Btn4.Background.BeginAnimation(SolidColorBrush.ColorProperty, BA);

            ColorAnimation BB = new ColorAnimation();
            ColorConverter CB = new ColorConverter();
            Color Bstart = (Color)CB.ConvertFrom("#7700ff");
            Btn4.Foreground = new SolidColorBrush(Cstart);
            BB.From = Bstart;
            BB.To = (Color)CB.ConvertFrom("#66ff00");
            BB.Duration = TimeSpan.FromSeconds(0.5);
            BB.RepeatBehavior = RepeatBehavior.Forever;
            BB.AutoReverse = true;
            Btn4.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, BB);

        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
			int p = pbpas.Password.GetHashCode();
			
            T_Users UsersObject = ClassBase.BD.T_Users.FirstOrDefault(z => z.Login == tblogin.Text && z.Password == p);
            if (UsersObject == null)
            {
                MessageBox.Show("Не верно введены логин или пароль!");
            }
            else
            {
				switch (UsersObject.id_role)  
				{
					case 2:  // Администратор                    Логин: Admin      Пароль: 99M@skin
						Class1.Mfrm.Navigate(new MainAdmin(UsersObject)); 
						break;
					case 1:  // Пользователь                     Логин: Marina2     Пароль: 58@Hkimi
                        Class1.Mfrm.Navigate(new MainUser(UsersObject));
						break;
					default:
						break;
				}
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            Class1.Mfrm.Navigate(new Registr());
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            WindowPage windowPage = new WindowPage();
            windowPage.ShowDialog();
            Class1.Mfrm.Navigate(new Autorizaciya());
        }
    }

}
