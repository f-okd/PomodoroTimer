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
            btn_continue.Visible = false;
            btn_stop.Visible = false;
            btn_pause.Visible = false;
        }

        private enum states
        {
            state_default,
            state_focus,
            state_break
        }
        private states _state = states.state_focus;

        // default values can be changes in settings
        private static int _pomodoro_length = 25 * 60;
        private int _break_length = 5 * 60;
        private int _long_break_length = 30 * 60;
        private int _time_left_secs = _pomodoro_length;
        private int _pomodoro_count = 0;
        private int _pomodoro_cycles = 4;


        private DialogResult _result;
        private SoundPlayer _alarm = new SoundPlayer(@"..\..\..\alarm.wav");


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
                    _pomodoro_count = (_pomodoro_count + 1) % _pomodoro_cycles;
                    _state = states.state_break;
                    label_state.Text = "BREAK";
                    break;
                case states.state_break:
                    _state = states.state_focus;
                    label_state.Text = "FOCUS";
                    break;
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
                label_timer.Text = "Time Up!!";
                _alarm.Play();

                switch (_state)
                {
                    case states.state_focus:
                        _result = MessageBox.Show("Timer is finished! Click OK to start the break timer.", "Timer Finished", MessageBoxButtons.OK); break;
                    case states.state_break:
                        _result = MessageBox.Show("Break is finished! Click OK to start the focus timer.", "Timer Finished", MessageBoxButtons.OK); break;
                    default:
                        _result = DialogResult.OK; break;
                }

                switchStates();


                if (_result == DialogResult.OK)
                {
                    restartTimer(_state);
                    _alarm.Stop();
                }
                else
                {
                    restartTimer(_state);
                    _alarm.Stop();
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
                    if (_pomodoro_count == 3)
                    {
                        _time_left_secs = _long_break_length; break;
                    }
                    else
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

        private void btn_settings_Click(object sender, EventArgs e)
        {
            panel_settings.Visible = true;
        }

        private void btn_applysettings_Click(object sender, EventArgs e)
        {
            int pomodoro_length, break_length, long_break_length, pomodoro_cycles;

            bool isPomodoroParsed = int.TryParse(txt_pomodoro.Text, out pomodoro_length);
            bool isBreakParsed = int.TryParse(txt_shortbreak.Text, out break_length);
            bool isLongBreakParsed = int.TryParse(txt_pomodorocycles.Text, out pomodoro_cycles);
            bool isPomodoroCyclesParsed = int.TryParse(txt_longbreak.Text, out long_break_length);

            if (isPomodoroParsed && isBreakParsed && isLongBreakParsed && isPomodoroCyclesParsed)
            {
                _pomodoro_length = pomodoro_length * 60;  // Convert minutes to seconds
                _break_length = break_length * 60;  // Convert minutes to seconds
                _long_break_length = long_break_length * 60;  // Convert minutes to seconds
                _pomodoro_cycles = pomodoro_cycles;

                panel_settings.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid input, please enter numbers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}