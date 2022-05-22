using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private long duration;

        private void timer1_Tick(object sender, EventArgs e) {
            updateTime();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            duration = timePicker.Value.TimeOfDay.Ticks + TimeSpan.TicksPerSecond;
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e) {
            timer1.Stop();
            duration = timePicker.Value.TimeOfDay.Ticks + TimeSpan.TicksPerSecond;
            updateTime();

        }

        private void updateTime() {
            duration -= (timer1.Interval * TimeSpan.TicksPerMillisecond);
            lbTime.Text = new DateTime(duration).ToString("HH:mm:ss");
            //lbTime.Text = duration.ToString();
            if (duration <= 0) {
                timer1.Stop();
                lbTime.Text = "Konec";
            }
        }
    }
}
