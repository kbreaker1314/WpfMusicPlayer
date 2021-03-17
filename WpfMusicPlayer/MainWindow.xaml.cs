using Microsoft.Win32;
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

namespace WpfMusicPlayer
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
        //instantiate media player object for play, pause, stop methods
        MediaPlayer musicPlayer = new MediaPlayer();
        OpenFileDialog openFile = new OpenFileDialog()
        {
            Multiselect = false,
            //DefaultExt = ".mp3"
        };
        private void Open_file_button(object sender, RoutedEventArgs e)
        {
            //bool? accept null value
            bool? dialogOkay = openFile.ShowDialog();
            if (dialogOkay == true)
            {
                musicPlayer.Open(new Uri(openFile.FileName));
            }
        }
        
        private void Play_button(object sender, RoutedEventArgs e)
        {
            musicPlayer.Play();
        }

        private void Pause_button(object sender, RoutedEventArgs e)
        {
            musicPlayer.Pause();
        }

        private void Stop_button(object sender, RoutedEventArgs e)
        {
            musicPlayer.Stop();
        }

    }
}
