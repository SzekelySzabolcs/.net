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

namespace DrillApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Drill kimo = new Drill
            (
                "Screw-In",
                "2.84 pounds",
                "KIMO.",
                Material.Titanium,
                new List<Material>()
                {
                    Material.Metal,
                    Material.Plastic,
                    Material.Titanium
                },
                "Average Battery Life 1000 Hours",
                "13.7 x 10.6 x 3 inches",
                "K13811",
                "Battery Powered",
                "Medium",
                Speed.Medium,
                new List<Speed>()
                {
                    Speed.Fast,
                    Speed.Medium,
                    Speed.Slow
                },
                "350 Inch Pounds",
                 new Usage(true, true, false, true, true, true)
            );
        public MainWindow()
        {
            InitializeComponent();
        }
        private void applyButtonClick(object sender, RoutedEventArgs e)
        {
            DataContext = kimo;
            materialComboBox.ItemsSource = kimo.Materials;
            speedComboBox.ItemsSource = kimo.Speeds;
        }

        private void resetButtonClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Drill();
        }

    }
}
