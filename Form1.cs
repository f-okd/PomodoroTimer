using System.Media;

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

        private enum States
        {
            state_default,
            state_focus,
            state_break
        }
        private States _state = States.state_focus;

        // default values can be changes in settings
        private static int _pomodoro_length = 25 * 60;
        private int _break_length = 5 * 60;
        private int _long_break_length = 30 * 60;
        private int _time_left_secs = _pomodoro_length;
        private int _pomodoro_count = 0;
        private int _pomodoro_cycles = 4;


        private DialogResult _result;
        private readonly SoundPlayer _alarm = new(@"..\..\..\alarm.wav");


        private void Btn_start_Click(object sender, EventArgs e)
        {
            // Set pomodoro timer to 25 minutes; TODO: Take input from form 2

            RestartTimer(_state);
            btn_start.Visible = false;
            btn_pause.Visible = true;
        }

        private void DisplayTime(int seconds)
        {
            TimeSpan time_left = TimeSpan.FromSeconds(_time_left_secs);
            label_timer.Text = time_left.ToString("mm\\:ss");
        }

        private void SwitchStates()
        {
            switch (_state)
            {
                case States.state_focus:
                    _pomodoro_count = (_pomodoro_count + 1) % _pomodoro_cycles;
                    _state = States.state_break;
                    label_state.Text = "BREAK";
                    break;
                case States.state_break:
                    _state = States.state_focus;
                    label_state.Text = "FOCUS";
                    break;
                default:
                    break;
            }
        }
        private void Timer_focus_Tick(object sender, EventArgs e)
        {
            if (_time_left_secs > 0)
            {
                _time_left_secs -= 1;
                DisplayTime(_time_left_secs);
            }
            else
            {
                timer_focus.Stop();
                label_timer.Text = "Time Up!!";
                _alarm.Play();

                switch (_state)
                {
                    case States.state_focus:
                        _result = MessageBox.Show("Timer is finished! Click OK to start the break timer.", "Timer Finished", MessageBoxButtons.OK); break;
                    case States.state_break:
                        _result = MessageBox.Show("Break is finished! Click OK to start the focus timer.", "Timer Finished", MessageBoxButtons.OK); break;
                    default:
                        _result = DialogResult.OK; break;
                }

                SwitchStates();


                if (_result == DialogResult.OK)
                {
                    RestartTimer(_state);
                    _alarm.Stop();
                }
                else
                {
                    RestartTimer(_state);
                    _alarm.Stop();
                }
            }
        }

        private void RestartTimer(States state)
        {
            switch (state)
            {
                case States.state_focus:
                    _time_left_secs = _pomodoro_length; break;
                case States.state_break: // Every 3 pomodoros, long break
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

            DisplayTime(_time_left_secs);
            timer_focus.Start();
        }

        private void Btn_pause_Click(object sender, EventArgs e)
        {
            timer_focus.Stop();

            btn_pause.Visible = false;
            btn_continue.Visible = true;
            btn_stop.Visible = true;
        }

        private void Btn_continue_Click(object sender, EventArgs e)
        {
            timer_focus.Start();
            btn_continue.Visible = false;
            btn_stop.Visible = false;
            btn_pause.Visible = true;
        }

        private void Btn_stop_Click(object sender, EventArgs e)
        {
            timer_focus.Stop();

            SwitchStates();

            RestartTimer(_state);
            timer_focus.Stop();

            btn_stop.Visible = false;
            btn_continue.Visible = false;
            btn_start.Visible = true;
        }

        private void Btn_settings_Click(object sender, EventArgs e)
        {
            panel_settings.Visible = true;
        }

        private void Btn_applysettings_Click(object sender, EventArgs e)
        {
            bool isPomodoroParsed = int.TryParse(txt_pomodoro.Text, out int pomodoro_length);
            bool isBreakParsed = int.TryParse(txt_shortbreak.Text, out int break_length);
            bool isLongBreakParsed = int.TryParse(txt_pomodorocycles.Text, out int pomodoro_cycles);
            bool isPomodoroCyclesParsed = int.TryParse(txt_longbreak.Text, out int long_break_length);

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