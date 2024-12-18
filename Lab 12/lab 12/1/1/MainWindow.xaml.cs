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

namespace _233597_Activity
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

        public static readonly DependencyProperty CurrentTimeProperty = DependencyProperty.Register(
            "CurrentTime",
            typeof(DateTime),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(
                DateTime.Now,
                FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                OnCurrentTimePropertyChanged,
                OnValidateCurrentTimeProperty)
        );

        public DateTime CurrentTime
        {
            get { return (DateTime)GetValue(CurrentTimeProperty); }
            set { SetValue(CurrentTimeProperty, value); }
        }

        private static void OnCurrentTimePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MainWindow window)
            {
                Console.WriteLine($"CurrentTime changed to: {e.NewValue}");
            }
        }

        private static object OnValidateCurrentTimeProperty(DependencyObject d, object baseValue)
        {
            if (baseValue is DateTime newValue)
            {
                if (newValue > DateTime.Now)
                {
                    return DateTime.Now;
                }
            }
            return baseValue;
        }

        // Add the missing event handler
        private void UpdateTimeButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentTime = DateTime.Now; // Update the CurrentTime property
        }

    }
}
