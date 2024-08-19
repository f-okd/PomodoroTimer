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

        private SettingsController settingsController = new SettingsController();
        private PomodoroController pomodoroController = new PomodoroController();


        private DialogResult _result;
        private readonly SoundPlayer _alarm = new(Path.Combine(Application.StartupPath, "datafiles/alarm.wav"));


        private void Btn_start_Click(object sender, EventArgs e)
        {
            // Set pomodoro timer to 25 minutes; TODO: Take input from form 2

            RestartTimer(_state);
            btn_start.Visible = false;
            btn_pause.Visible = true;
        }

        private void DisplayTime(int seconds)
        {
            TimeSpan time_left = TimeSpan.FromSeconds(pomodoroController.TimeLeft);
            label_timer.Text = time_left.ToString("mm\\:ss");
        }

        private void SwitchStates()
        {
            switch (_state)
            {
                case States.state_focus:
                    pomodoroController.PomodoroCount += 1;
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
            if (pomodoroController.TimeLeft > 0)
            {
                pomodoroController.TimeLeft -= 1;
                DisplayTime(pomodoroController.TimeLeft);
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
                    pomodoroController.TimeLeft = pomodoroController.PomodoroLength * 60; break;
                case States.state_break: // 4th pomodoro break is a long break
                    if (pomodoroController.PomodoroCount == 3)
                    {
                        pomodoroController.StartLongBreak(); break;
                    }
                    else
                    {
                        pomodoroController.StartShortBreak(); break;
                    }
                default:
                    break;
            }

            DisplayTime(pomodoroController.TimeLeft);
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
            bool isPomodoroParsed = int.TryParse(txt_pomodoro.Text, out int pomodoroLength);
            bool isBreakParsed = int.TryParse(txt_shortbreak.Text, out int shortBreakLength);
            bool isPomodoroCyclesParsed = int.TryParse(txt_longbreak.Text, out int longBreakLength);
            bool isLongBreakParsed = int.TryParse(txt_pomodorocycles.Text, out int pomodoroCycles);

            if (isPomodoroParsed && isBreakParsed && isLongBreakParsed && isPomodoroCyclesParsed)
            {
                settingsController.UpdateSettings(pomodoroLength, shortBreakLength, longBreakLength, pomodoroCycles);
                pomodoroController.SyncSettings();

                panel_settings.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid input, please enter integers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_settings_Click(object sender, EventArgs e)
        {
            txt_pomodoro.Text = pomodoroController.PomodoroLength.ToString();
            txt_shortbreak.Text = pomodoroController.ShortBreakLength.ToString();
            txt_longbreak.Text = pomodoroController.LongBreakLength.ToString();
            txt_pomodorocycles.Text = pomodoroController.PomodoroCycles.ToString();

            panel_settings.Visible = false;
        }
    }
}