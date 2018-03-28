using System.IO;

namespace Cineplay
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.myVlcControl = new Vlc.DotNet.Forms.VlcControl();
            this.myBtnPlay = new System.Windows.Forms.Button();
            this.myBtnStop = new System.Windows.Forms.Button();
            this.myLblMediaLength = new System.Windows.Forms.Label();
            this.myLblVlcPosition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.myLblState = new System.Windows.Forms.Label();
            this.myBtnPause = new System.Windows.Forms.Button();
            this.myGrpAudioInformations = new System.Windows.Forms.GroupBox();
            this.myLblAudioRate = new System.Windows.Forms.Label();
            this.myLblAudioChannels = new System.Windows.Forms.Label();
            this.myLblAudioCodec = new System.Windows.Forms.Label();
            this.myGrpVideoInformations = new System.Windows.Forms.GroupBox();
            this.myLblVideoWidth = new System.Windows.Forms.Label();
            this.myLblVideoCodec = new System.Windows.Forms.Label();
            this.myLblVideoHeight = new System.Windows.Forms.Label();
            this.myCbxAspectRatio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myVlcControl)).BeginInit();
            this.myGrpAudioInformations.SuspendLayout();
            this.myGrpVideoInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // myVlcControl
            // 
            this.myVlcControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myVlcControl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.myVlcControl.Location = new System.Drawing.Point(18, 18);
            this.myVlcControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myVlcControl.Name = "myVlcControl";
            this.myVlcControl.Size = new System.Drawing.Size(846, 520);
            this.myVlcControl.Spu = -1;
            this.myVlcControl.TabIndex = 0;
            this.myVlcControl.Text = "vlcRincewindControl1";
            this.myVlcControl.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("myVlcControl.VlcLibDirectory")));
            this.myVlcControl.VlcMediaplayerOptions = null;
            this.myVlcControl.LengthChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerLengthChangedEventArgs>(this.OnVlcMediaLengthChanged);
            this.myVlcControl.Log += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerLogEventArgs>(this.OnVlcMediaPlayerLog);
            this.myVlcControl.Paused += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPausedEventArgs>(this.OnVlcPaused);
            this.myVlcControl.Playing += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPlayingEventArgs>(this.OnVlcPlaying);
            this.myVlcControl.PositionChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs>(this.OnVlcPositionChanged);
            this.myVlcControl.Stopped += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs>(this.OnVlcStopped);
            this.myVlcControl.DoubleClick += new System.EventHandler(this.fullScreen);
            // 
            // myBtnPlay
            // 
            this.myBtnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.myBtnPlay.Location = new System.Drawing.Point(18, 548);
            this.myBtnPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myBtnPlay.Name = "myBtnPlay";
            this.myBtnPlay.Size = new System.Drawing.Size(112, 35);
            this.myBtnPlay.TabIndex = 1;
            this.myBtnPlay.Text = "Play";
            this.myBtnPlay.UseVisualStyleBackColor = true;
            this.myBtnPlay.Click += new System.EventHandler(this.OnButtonPlayClicked);
            // 
            // myBtnStop
            // 
            this.myBtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.myBtnStop.Location = new System.Drawing.Point(261, 548);
            this.myBtnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myBtnStop.Name = "myBtnStop";
            this.myBtnStop.Size = new System.Drawing.Size(112, 35);
            this.myBtnStop.TabIndex = 2;
            this.myBtnStop.Text = "Stop";
            this.myBtnStop.UseVisualStyleBackColor = true;
            this.myBtnStop.Click += new System.EventHandler(this.OnButtonStopClicked);
            // 
            // myLblMediaLength
            // 
            this.myLblMediaLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.myLblMediaLength.AutoSize = true;
            this.myLblMediaLength.Location = new System.Drawing.Point(492, 555);
            this.myLblMediaLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLblMediaLength.Name = "myLblMediaLength";
            this.myLblMediaLength.Size = new System.Drawing.Size(71, 20);
            this.myLblMediaLength.TabIndex = 3;
            this.myLblMediaLength.Text = "00:00:00";
            // 
            // myLblVlcPosition
            // 
            this.myLblVlcPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.myLblVlcPosition.AutoSize = true;
            this.myLblVlcPosition.Location = new System.Drawing.Point(382, 555);
            this.myLblVlcPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLblVlcPosition.Name = "myLblVlcPosition";
            this.myLblVlcPosition.Size = new System.Drawing.Size(71, 20);
            this.myLblVlcPosition.TabIndex = 4;
            this.myLblVlcPosition.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 555);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 555);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "State:";
            // 
            // myLblState
            // 
            this.myLblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.myLblState.AutoSize = true;
            this.myLblState.Location = new System.Drawing.Point(656, 555);
            this.myLblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLblState.Name = "myLblState";
            this.myLblState.Size = new System.Drawing.Size(0, 20);
            this.myLblState.TabIndex = 7;
            // 
            // myBtnPause
            // 
            this.myBtnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.myBtnPause.Location = new System.Drawing.Point(140, 548);
            this.myBtnPause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myBtnPause.Name = "myBtnPause";
            this.myBtnPause.Size = new System.Drawing.Size(112, 35);
            this.myBtnPause.TabIndex = 8;
            this.myBtnPause.Text = "Pause";
            this.myBtnPause.UseVisualStyleBackColor = true;
            this.myBtnPause.Click += new System.EventHandler(this.OnButtonPauseClicked);
            // 
            // myGrpAudioInformations
            // 
            this.myGrpAudioInformations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myGrpAudioInformations.Controls.Add(this.myLblAudioRate);
            this.myGrpAudioInformations.Controls.Add(this.myLblAudioChannels);
            this.myGrpAudioInformations.Controls.Add(this.myLblAudioCodec);
            this.myGrpAudioInformations.Location = new System.Drawing.Point(873, 18);
            this.myGrpAudioInformations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myGrpAudioInformations.Name = "myGrpAudioInformations";
            this.myGrpAudioInformations.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myGrpAudioInformations.Size = new System.Drawing.Size(328, 118);
            this.myGrpAudioInformations.TabIndex = 9;
            this.myGrpAudioInformations.TabStop = false;
            this.myGrpAudioInformations.Text = "Audio informations";
            // 
            // myLblAudioRate
            // 
            this.myLblAudioRate.AutoSize = true;
            this.myLblAudioRate.Location = new System.Drawing.Point(10, 80);
            this.myLblAudioRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLblAudioRate.Name = "myLblAudioRate";
            this.myLblAudioRate.Size = new System.Drawing.Size(48, 20);
            this.myLblAudioRate.TabIndex = 2;
            this.myLblAudioRate.Text = "Rate:";
            // 
            // myLblAudioChannels
            // 
            this.myLblAudioChannels.AutoSize = true;
            this.myLblAudioChannels.Location = new System.Drawing.Point(10, 55);
            this.myLblAudioChannels.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLblAudioChannels.Name = "myLblAudioChannels";
            this.myLblAudioChannels.Size = new System.Drawing.Size(80, 20);
            this.myLblAudioChannels.TabIndex = 1;
            this.myLblAudioChannels.Text = "Channels:";
            // 
            // myLblAudioCodec
            // 
            this.myLblAudioCodec.AutoSize = true;
            this.myLblAudioCodec.Location = new System.Drawing.Point(10, 31);
            this.myLblAudioCodec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLblAudioCodec.Name = "myLblAudioCodec";
            this.myLblAudioCodec.Size = new System.Drawing.Size(59, 20);
            this.myLblAudioCodec.TabIndex = 0;
            this.myLblAudioCodec.Text = "Codec:";
            // 
            // myGrpVideoInformations
            // 
            this.myGrpVideoInformations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myGrpVideoInformations.Controls.Add(this.myLblVideoWidth);
            this.myGrpVideoInformations.Controls.Add(this.myLblVideoCodec);
            this.myGrpVideoInformations.Controls.Add(this.myLblVideoHeight);
            this.myGrpVideoInformations.Location = new System.Drawing.Point(873, 146);
            this.myGrpVideoInformations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myGrpVideoInformations.Name = "myGrpVideoInformations";
            this.myGrpVideoInformations.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myGrpVideoInformations.Size = new System.Drawing.Size(328, 114);
            this.myGrpVideoInformations.TabIndex = 10;
            this.myGrpVideoInformations.TabStop = false;
            this.myGrpVideoInformations.Text = "Video informations";
            // 
            // myLblVideoWidth
            // 
            this.myLblVideoWidth.AutoSize = true;
            this.myLblVideoWidth.Location = new System.Drawing.Point(9, 74);
            this.myLblVideoWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLblVideoWidth.Name = "myLblVideoWidth";
            this.myLblVideoWidth.Size = new System.Drawing.Size(54, 20);
            this.myLblVideoWidth.TabIndex = 5;
            this.myLblVideoWidth.Text = "Width:";
            // 
            // myLblVideoCodec
            // 
            this.myLblVideoCodec.AutoSize = true;
            this.myLblVideoCodec.Location = new System.Drawing.Point(9, 25);
            this.myLblVideoCodec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLblVideoCodec.Name = "myLblVideoCodec";
            this.myLblVideoCodec.Size = new System.Drawing.Size(59, 20);
            this.myLblVideoCodec.TabIndex = 3;
            this.myLblVideoCodec.Text = "Codec:";
            // 
            // myLblVideoHeight
            // 
            this.myLblVideoHeight.AutoSize = true;
            this.myLblVideoHeight.Location = new System.Drawing.Point(9, 49);
            this.myLblVideoHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLblVideoHeight.Name = "myLblVideoHeight";
            this.myLblVideoHeight.Size = new System.Drawing.Size(60, 20);
            this.myLblVideoHeight.TabIndex = 4;
            this.myLblVideoHeight.Text = "Height:";
            // 
            // myCbxAspectRatio
            // 
            this.myCbxAspectRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myCbxAspectRatio.Enabled = false;
            this.myCbxAspectRatio.FormattingEnabled = true;
            this.myCbxAspectRatio.Items.AddRange(new object[] {
            "16:9",
            "16:10",
            "4:3"});
            this.myCbxAspectRatio.Location = new System.Drawing.Point(1020, 262);
            this.myCbxAspectRatio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myCbxAspectRatio.Name = "myCbxAspectRatio";
            this.myCbxAspectRatio.Size = new System.Drawing.Size(180, 28);
            this.myCbxAspectRatio.TabIndex = 11;
            this.myCbxAspectRatio.TextChanged += new System.EventHandler(this.myCbxAspectRatio_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(870, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Video Aspect Ratio:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(906, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1051, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "NOT Connected";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(906, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Server";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1051, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "NOT Listening";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(914, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Test1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1074, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Test1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 602);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.myCbxAspectRatio);
            this.Controls.Add(this.myGrpVideoInformations);
            this.Controls.Add(this.myGrpAudioInformations);
            this.Controls.Add(this.myBtnPause);
            this.Controls.Add(this.myLblState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myLblVlcPosition);
            this.Controls.Add(this.myLblMediaLength);
            this.Controls.Add(this.myBtnStop);
            this.Controls.Add(this.myBtnPlay);
            this.Controls.Add(this.myVlcControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Vlc.DotNet - Winform Player Sample";
            this.SizeChanged += new System.EventHandler(this.Sample_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.myVlcControl)).EndInit();
            this.myGrpAudioInformations.ResumeLayout(false);
            this.myGrpAudioInformations.PerformLayout();
            this.myGrpVideoInformations.ResumeLayout(false);
            this.myGrpVideoInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl myVlcControl;
        private System.Windows.Forms.Button myBtnPlay;
        private System.Windows.Forms.Button myBtnStop;
        private System.Windows.Forms.Label myLblMediaLength;
        private System.Windows.Forms.Label myLblVlcPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label myLblState;
        private System.Windows.Forms.Button myBtnPause;
        private System.Windows.Forms.GroupBox myGrpAudioInformations;
        private System.Windows.Forms.GroupBox myGrpVideoInformations;
        private System.Windows.Forms.Label myLblAudioRate;
        private System.Windows.Forms.Label myLblAudioChannels;
        private System.Windows.Forms.Label myLblAudioCodec;
        private System.Windows.Forms.Label myLblVideoWidth;
        private System.Windows.Forms.Label myLblVideoCodec;
        private System.Windows.Forms.Label myLblVideoHeight;
        private System.Windows.Forms.ComboBox myCbxAspectRatio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

