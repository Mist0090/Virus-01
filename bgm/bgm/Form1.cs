using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bgm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            Hide();
            WMPLib.WindowsMediaPlayer mediaPlayer = new WMPLib.WindowsMediaPlayer();
            string tempD = System.IO.Path.GetTempPath();
            mediaPlayer.URL = "bgm.mp3";
            mediaPlayer.settings.setMode("loop", true);
            mediaPlayer.controls.play();
        }
    }
}
