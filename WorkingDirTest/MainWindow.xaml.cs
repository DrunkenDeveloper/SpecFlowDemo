using System;
using System.Collections.Generic;
using System.IO;
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

namespace WorkingDirTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var text = File.ReadAllText("./Test.txt");
                TestLable.Content = text;
            }
            catch(Exception ex) 
            {
                TestLable.Content = "failed";

                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
        }
    }
}
