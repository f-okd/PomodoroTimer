using System.Media;
using static System.Windows.Forms.AxHost;

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

        private enum  states
        {
            state_default,
            state_focus,
            state_break
        }
        private states _state = states.state_focus;


        private static int _pomodoro_length = 5;
        private int _break_length = 7; 
        private int _long_break_length = 30 * 60;
        private int _time_left_secs = _pomodoro_length;
        private int pomodoro_count = 0;
        
        private DialogResult result;
        private SoundPlayer _sound_player = new SoundPlayer();


        private void btn_start_Click(object sender, EventArgs e)
        {
            // Set pomodoro timer to 25 minutes; TODO: Take input from form 2

            restartTimer(_state);
            btn_start.Visible = false;
            btn_pause.Visible = true;
        }

        private void displayTime(int seconds)
        {
            TimeSpan time_left = TimeSpan.FromSeconds(_time_left_secs);
            label_timer.Text = time_left.ToString("mm\\:ss");
        }

        private void switchStates()
        {
            switch (_state)
            {
                case states.state_focus:
                    pomodoro_count = (pomodoro_count + 1) % 4;
                    _state = states.state_break; break;
                case states.state_break:
                    _state = states.state_focus; break;
                default:
                    break;
            }
        }
        private void timer_focus_Tick(object sender, EventArgs e)
        {
            if (_time_left_secs > 0)
            {
                _time_left_secs -= 1;
                displayTime(_time_left_secs);
            }
            else
            {
                timer_focus.Stop();
                label_timer.Text = "Time Up!!"; // add alarm sounds

                switch (_state)
                {
                    case states.state_focus:
                        result = MessageBox.Show("Timer is finished! Click OK to start the break timer.", "Timer Finished", MessageBoxButtons.OK); break;
                    case states.state_break:
                        result = MessageBox.Show("Break is finished! Click OK to start the focus timer.", "Timer Finished", MessageBoxButtons.OK); break;
                    default:
                        result = DialogResult.OK; break;
                }

                switchStates();


                if (result == DialogResult.OK)
                {
                    restartTimer(_state);
                }
                else
                {
                    restartTimer(_state);
                }
            }
        }

        private void restartTimer(states state)
        {
            switch (state)
            {
                case states.state_focus:
                    _time_left_secs = _pomodoro_length; break;
                case states.state_break: // Every 3 pomodoros, long break
                    if (pomodoro_count == 3)
                    {
                        _time_left_secs = _long_break_length; break;
                    } else
                    {
                        _time_left_secs = _break_length; break;
                    }
                    
                default: 
                    break;
            }

            displayTime(_time_left_secs);
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
            timer_focus.Stop();

            switchStates();

            restartTimer(_state);
            timer_focus.Stop();

            btn_stop.Visible = false;
            btn_continue.Visible = false;
            btn_start.Visible = true;
        }
    }
}