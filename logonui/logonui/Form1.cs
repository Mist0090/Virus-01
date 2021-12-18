using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace logonui
{
    public partial class Form1 : Form
    {
        private List<Color> rainbowColors = new List<Color>()
        {
          Color.Red,
          Color.DarkRed,
          Color.Orange,
          Color.Yellow,
          Color.Green,
          Color.DarkGreen,
          Color.Blue,
          Color.DarkBlue,
          Color.Violet
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            timer1.Start();
        }

        private int rainbowIndex;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = this.rainbowColors[this.rainbowIndex++];
            this.rainbowIndex = this.rainbowIndex % this.rainbowColors.Count;

            this.Invalidate(); //Really change the formcolor
        }
    }
}
