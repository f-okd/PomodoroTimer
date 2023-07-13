namespace PomodoroTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set to value of pomodoro length in form 2
            label_timer.Text = string.Empty;
            btn_continue.Visible = false;
            btn_stop.Visible = false;
            btn_pause.Visible = false;
        }

        static int pomodoro_length = 25 * 60;
        int time_left_secs = pomodoro_length;

        private void btn_start_Click(object sender, EventArgs e)
        {
            // Set pomodoro timer to 25 minutes; TODO: Take input from form 2

            restartTimer();
            btn_start.Visible = false;
            btn_pause.Visible = true;
        }

        private void displayTime(int seconds)
        {
            TimeSpan time_left = TimeSpan.FromSeconds(time_left_secs);
            label_timer.Text = time_left.ToString("mm\\:ss");
        }
        private void timer_focus_Tick(object sender, EventArgs e)
        {
            if (time_left_secs > 0)
            {
                time_left_secs -= 1;
                displayTime(time_left_secs);
            }
            else
            {
                timer_focus.Stop();
                restartTimer();
                label_timer.Text = "Time Up!!"; // add alarm sounds
            }
        }

        private void restartTimer()
        {
            time_left_secs = pomodoro_length;
            displayTime(time_left_secs);
            timer_focus.Start();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            timer_focus.Stop();
            btn_pause.Visible = false;
            btn_continue.Visible = true;
            btn_stop.Visible = true;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            timer_focus.Start();
            btn_continue.Visible = false;
            btn_stop.Visible = false;
            btn_pause.Visible = true;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            restartTimer();
            timer_focus.Stop();
            btn_stop.Visible = false;
            btn_continue.Visible = false;
            btn_start.Visible = true;
        }
    }
}