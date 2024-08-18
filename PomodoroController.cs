using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{

    internal class PomodoroController
    {
        private int _pomodoroLength;
        private int _shortBreakLength;
        private int _longBreakLength;
        private int _pomodoroCycles;

        private int _pomodoroCount = 0;
        private int _timeLeft;
        public int PomodoroLength
        {
            get => _pomodoroLength;
        }
        public int ShortBreakLength
        {
            get => _shortBreakLength;
        }
        public int LongBreakLength
        {
            get => _longBreakLength;
        }
        public int TimeLeft
        {
            get => _timeLeft;
            set => _timeLeft = value;
        }

        public int PomodoroCount
        {
            get => _pomodoroCount;
            set => _pomodoroCount = value % this._pomodoroCycles;
        }

        public int PomodoroCycles
        {
            get => _pomodoroCycles;
            set => _pomodoroCycles = value;
        }

        private readonly SettingsController _settingsController = new();

        public PomodoroController()
        {
            this.SyncSettings();
            this.TimeLeft = this._pomodoroLength * 60;
        }

        public void StartLongBreak()
        {
            this._timeLeft = this._longBreakLength * 60;
        }

        public void StartShortBreak()
        {
            this._timeLeft = this._shortBreakLength * 60;
        }

        public void SyncSettings()
        {
            SortedDictionary<string, int> settings = this._settingsController.GetSettings();

            this._pomodoroLength = settings["PomodoroLength"];
            this._shortBreakLength = settings["ShortBreakLength"];
            this._longBreakLength = settings["LongBreakLength"];
            this._pomodoroCycles = settings["PomodoroCycles"];

            //MessageBox.Show(settings["PomodoroLength"].ToString());
            //MessageBox.Show(this.PomodoroLength.ToString());
        }
    }

}
