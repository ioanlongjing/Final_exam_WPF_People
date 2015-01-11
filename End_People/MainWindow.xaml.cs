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

 

namespace End_People
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Class1[] Teacher = 
                                { 
                                    new Class1("鄭林合", "lgn@mail.com","0911-111-111","gn.sju.com","Blue"),
                                    new Class1("陳瑞希", "crx@mail.com","0922-222-222","crx.sju.com","Red"),
                                    new Class1("陳日昌", "jct@mail.com","0933-333-333","jct.sju.com","Green"),
                                    new Class1("高堅志", "jjk@mail.com","0944-444-444","jjk.sju.com","Pink")
                                };


            Teacher_Name.ItemsSource = Teacher;
            //DataContext = Teacher;
        }
    }
}
