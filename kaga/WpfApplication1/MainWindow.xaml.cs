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

namespace DeskTopmaskot
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Quit_Clicked(object sender, RoutedEventArgs e)
        {
            Close();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
        private System.Media.SoundPlayer player = null;

        //WAVEファイルを再生する
        private void PlaySound(string waveFile)
        {
            //再生されているときは止める
            if (player != null)
                StopSound();

            //読み込む
            player = new System.Media.SoundPlayer(waveFile);
            //非同期再生する
            player.Play();

            //次のようにすると、ループ再生される
            //player.PlayLooping();

            //次のようにすると、最後まで再生し終えるまで待機する
            //player.PlaySync();
        }

        //再生されている音を止める
        private void StopSound()
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }
        }
        
        //Button1のClickイベントハンドラ
        private void Button1_Click(object sender, EventArgs e)
        {

            PlaySound("C:/Users/kyota/Documents/Visual Studio 2013/Projects/kaga/WpfApplication1/ma/koko.wav");
        
        }

        //Button2のClickイベントハンドラ
        private void Button2_Click(object sender, EventArgs e)
        {
            StopSound();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PlaySound("C:/Users/kyota/Documents/Visual Studio 2013/Projects/kaga/WpfApplication1/ma/koko.wav");
        }
    }
}
