using System.Windows;
using System.Windows.Input;

namespace E
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string localPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),"e.wav");
        //private string localPath = $"../../e.wav";
        public MainWindow()
        {
            this.ShowInTaskbar = true;
            InitializeComponent();
            //MessageBox.Show(localPath);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(localPath);
            player.Play();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
            MainWindow win = new MainWindow();
            win.Show();
        }
    }
}
