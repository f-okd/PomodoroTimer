namespace PomodoroTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set to value of pomodoro length in form 2
            label_timer.Text = string.Empty;
        }

        static int pomodoro_length = 25 * 60;
        int time_left_secs = pomodoro_length;

        private void btn_start_Click(object sender, EventArgs e)
        {
            // Set pomodoro timer to 25 minutes; TODO: Take input from form 2

            timer_countdown.Start();
        }

        private void timer_countdown_Tick(object sender, EventArgs e)
        {
            if (time_left_secs > 0)
            {
                time_left_secs -= 1;
                TimeSpan time_left = TimeSpan.FromSeconds(time_left_secs);
                label_timer.Text = time_left.ToString("mm\\:ss");
            }
            else
            {
                timer_countdown.Stop();
                label_timer.Text = "Time Up!!";
            }
        }
    }
}