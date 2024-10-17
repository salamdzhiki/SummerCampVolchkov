using SummerStudentCamp.ClassPr;
using SummerStudentCamp.Model;
using SummerStudentCamp.PageMain;
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

namespace SummerStudentCamp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClassConnect.Ent = new Entities();
            MainFrame.Navigate(new MainBody());
        }

        public void TextBlock_MouseLEftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new AddGroup());
        }

        public void TextBlock_MouseLEftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new AddSorev());
        }

        public void TextBlock_MouseLEftButtonUp_2(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new Uchet());
        }
    }
}
