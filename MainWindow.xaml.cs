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
        }

        private void InterruptButton_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @".\Sounds\01.wav";
            player.Load();
            player.Play();
        }
    }
}
