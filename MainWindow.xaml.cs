using System;
using System.Windows;
using System.Windows.Shapes;
using System.IO;

namespace Darwin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Set the window startup location to manual
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.Manual;

            // Subscribe to the Loaded event
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Get the working area of the screen
            var workingArea = System.Windows.SystemParameters.WorkArea;

            // Set the window position to the bottom right corner
            this.Left = workingArea.Right - this.Width;
            this.Top = workingArea.Bottom - this.Height;
        }

        private void InterruptButton_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @".\Sounds\03.wav";
            player.Load();
            player.Play();
        }
    }
}
