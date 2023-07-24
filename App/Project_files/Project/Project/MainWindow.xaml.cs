using Project.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Project
{

    public partial class MainWindow : Window
    {
        ControlMain control;

       


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            control = new ControlMain();
            ListViewMenu.ItemsSource = control.GetMenuList();



        }


        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var index = ListViewMenu.SelectedIndex;

            switch (index)
            {
                case 0:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new UserControlDashboard());

                    break;
                case 1:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new UserAcc());
                    break;
                case 2:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new UserIncome());
                    break;
                case 3:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new UserControlExpense());
                    break;

                default:
                    break;
            }

            ListViewMenu.SelectedIndex = -1;
        }

        private void ButtonShutdown_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

    }
}
