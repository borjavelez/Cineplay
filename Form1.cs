using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Vlc.DotNet.Core;
using Vlc.DotNet.Core.Interops.Signatures;
using Vlc.DotNet.Forms;
using Cineplay.Extensions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Cineplay
{
    public partial class Form1 : Form
    {
        bool isPlaying = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void OnButtonPlayClicked(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo("C:\\test2.mkv");
            Task.Run(() => myVlcControl.Play(fileInfo));
            
        }

        private void OnButtonStopClicked(object sender, EventArgs e)
        {
            myVlcControl.Stop();
        }

        private void OnButtonPauseClicked(object sender, EventArgs e)
        {
            myVlcControl.Pause();
        }

        private void OnVlcMediaLengthChanged(object sender, VlcMediaPlayerLengthChangedEventArgs e)
        {
            this.myLblMediaLength.InvokeIfRequired(l => l.Text = new DateTime(new TimeSpan((long)e.NewLength).Ticks).ToString("T"));

        }

        private async void OnVlcPositionChanged(object sender, VlcMediaPlayerPositionChangedEventArgs e)
        {
            var position = myVlcControl.GetCurrentMedia().Duration.Ticks * e.NewPosition;
            myLblVlcPosition.InvokeIfRequired(l => l.Text = new DateTime((long)position).ToString("T"));
        }


        private void OnVlcPaused(object sender, VlcMediaPlayerPausedEventArgs e)
        {
            myLblState.InvokeIfRequired(l => l.Text = "Paused");
        }

        private void OnVlcStopped(object sender, VlcMediaPlayerStoppedEventArgs e)
        {
            myLblState.InvokeIfRequired(l => l.Text = "Stopped");

            myCbxAspectRatio.InvokeIfRequired(c =>
           {
               c.Text = string.Empty;
               c.Enabled = false;
           });
            ControlExtensions.InvokeIfRequired(myLblAudioCodec, c => c.Text = "Codec: ");
            ControlExtensions.InvokeIfRequired(myLblAudioChannels, c => c.Text = "Channels: ");
            ControlExtensions.InvokeIfRequired(myLblAudioRate, c => c.Text = "Rate: ");
            ControlExtensions.InvokeIfRequired(myLblVideoCodec, c => c.Text = "Codec: ");
            ControlExtensions.InvokeIfRequired(myLblVideoHeight, c => c.Text = "Height: ");
            ControlExtensions.InvokeIfRequired(myLblVideoWidth, c => c.Text = "Width: ");
        }

        private void OnVlcPlaying(object sender, VlcMediaPlayerPlayingEventArgs e)
        {
            myLblState.InvokeIfRequired(l => l.Text = "Playing");

            myLblAudioCodec.InvokeIfRequired(l => l.Text = "Codec: ");
            myLblAudioChannels.InvokeIfRequired(l => l.Text = "Channels: ");
            myLblAudioRate.InvokeIfRequired(l => l.Text = "Rate: ");
            myLblVideoCodec.InvokeIfRequired(l => l.Text = "Codec: ");
            myLblVideoHeight.InvokeIfRequired(l => l.Text = "Height: ");
            myLblVideoWidth.InvokeIfRequired(l => l.Text = "Width: ");

            var mediaInformations = myVlcControl.GetCurrentMedia().TracksInformations;
            foreach (var mediaInformation in mediaInformations)
            {
                if (mediaInformation.Type == MediaTrackTypes.Audio)
                {
                    myLblAudioCodec.InvokeIfRequired(l => l.Text += mediaInformation.CodecName);
                    myLblAudioChannels.InvokeIfRequired(l => l.Text += mediaInformation.Audio.Channels);
                    myLblAudioRate.InvokeIfRequired(l => l.Text += mediaInformation.Audio.Rate);
                }
                else if (mediaInformation.Type == MediaTrackTypes.Video)
                {
                    myLblVideoCodec.InvokeIfRequired(l => l.Text += mediaInformation.CodecName);
                    myLblVideoHeight.InvokeIfRequired(l => l.Text += mediaInformation.Video.Height);
                    myLblVideoWidth.InvokeIfRequired(l => l.Text += mediaInformation.Video.Width);
                }
            }

            myCbxAspectRatio.InvokeIfRequired(c =>
            {
                c.Text = myVlcControl.Video.AspectRatio;
                c.Enabled = true;
            });
        }

        private void myCbxAspectRatio_TextChanged(object sender, EventArgs e)
        {
            myVlcControl.Video.AspectRatio = myCbxAspectRatio.Text;
            ResizeVlcControl();
        }

        private void Sample_SizeChanged(object sender, EventArgs e)
        {
            ResizeVlcControl();
        }

        void ResizeVlcControl()
        {
            if (!string.IsNullOrEmpty(myCbxAspectRatio.Text))
            {
                var ratio = myCbxAspectRatio.Text.Split(':');
                int width, height;
                if (ratio.Length == 2 && int.TryParse(ratio[0], out width) && int.TryParse(ratio[1], out height))
                    myVlcControl.Width = myVlcControl.Height * width / height;
            }
        }

        private void OnVlcMediaPlayerLog(object sender, VlcMediaPlayerLogEventArgs e)
        {
            string message = string.Format("libVlc : {0} {1} @ {2}", e.Level, e.Message, e.Module);
            System.Diagnostics.Debug.WriteLine(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Environment.CurrentDirectory.ToString());
        }

        private void fullScreen(object sender, EventArgs e)
        {
            myVlcControl.Height = 1080;
            myVlcControl.Width = 1920;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(myVlcControl.VlcMediaPlayer.Time.ToString());
        }

        private void myVlcControl_VlcLibDirectoryNeeded(object sender, VlcLibDirectoryNeededEventArgs e)
        {
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            e.VlcLibDirectory = new DirectoryInfo(Path.Combine(projectFolder, @"libvlc\\x86"));
        }
    }
}
