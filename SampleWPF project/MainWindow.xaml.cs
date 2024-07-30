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

namespace SampleWPF_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : UserControl
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Ancillary window2 = new Ancillary();
            window2.ShowDialog();
        }
        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            Facility_Info window2 = new Facility_Info();
            window2.ShowDialog();
        }
        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            Physicians window2 = new Physicians();
            window2.ShowDialog();
        }

        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            ParentAccount window2 = new ParentAccount();
            window2.ShowDialog();
        }

        private void ButtonBase_OnClick4(object sender, RoutedEventArgs e)
        {
            Ancillary_1 window2 = new Ancillary_1();
            window2.ShowDialog();
        }
        private void ButtonBase_OnClick5(object sender, RoutedEventArgs e)
        {
            Facility_1 window2 = new Facility_1();
            window2.ShowDialog();
        }
        private void ButtonBase_OnClick6(object sender, RoutedEventArgs e)
        {
            Physicians_1 window2 = new Physicians_1();
            window2.ShowDialog();
        }
        private void Provider_Click(object sender, RoutedEventArgs e)
        {
            Provider_reuirement_Query window2 = new Provider_reuirement_Query();
            window2.ShowDialog();
        }

        private void Provider_Query_Click(object sender, RoutedEventArgs e)
        {
            Provider_reuirement_Query window2 = new Provider_reuirement_Query();
            window2.ShowDialog();
        }
        private void ButtonBase_OnClick9(object sender, RoutedEventArgs e)
        {
            C_Star_Valuelists  window2 = new C_Star_Valuelists();
            window2.ShowDialog();
        }
        private void ButtonBase_OnClick10(object sender, RoutedEventArgs e)
        {
            Export_Functions window2 = new Export_Functions();
            window2.ShowDialog();
        }
        private void CloseForm_Click(object sender, RoutedEventArgs e)
        {
           
        }

    }
}
