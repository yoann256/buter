using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buter
{
    public partial class collbuterdogvideo : Form
    {
        public collbuterdogvideo()
        {
            InitializeComponent();
        }

        private void collbuterdogvideo_Load(object sender, EventArgs e)
        {
            string videoPath = Path.Combine(Application.StartupPath, "butter_dog_type_beat.mp4");
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
