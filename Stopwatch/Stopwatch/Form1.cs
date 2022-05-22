using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch {
    public partial class form : Form {
        public form() {
            InitializeComponent();
        }

        private long duration;

        private void timer1_Tick(object sender, EventArgs e) {
            updateTime();
        }

        private void btn_Click(object sender, EventArgs e) {
            if (btnStart.Text == "Start") {
                duration = timePicker.Value.TimeOfDay.Ticks;
                if (duration != 0) {
                    timer1.Start();
                    btnStart.Text = "Stop";
                }
                
            }else if (btnStart.Text == "Stop") {
                timer1.Stop();
                btnStart.Text = "Reset";
            } else {
                duration = timePicker.Value.TimeOfDay.Ticks;
                updateTime();
                btnStart.Text = "Start";
            }
        }

        private void updateTime() {
            duration -= (timer1.Interval * TimeSpan.TicksPerMillisecond);
            lbTime.Text = new DateTime(duration).ToString("HH:mm:ss");
            if (duration <= 0) {
                timer1.Stop();
                lbTime.Text = "Konec";
                btnStart.Text = "Start";
            }
        }
    }
}
