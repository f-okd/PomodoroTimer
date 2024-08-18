using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    internal class SettingsController
    {
        private readonly static int DEFAULT_POMDORO_LENGTH = 20000;
        private readonly static int DEFAULT_SHORT_BREAK = 300;
        private readonly static int DEFAULT_LONG_BREAK = 1800;
        private readonly static int DEFAULT_POMODORO_CYCLES = 4;

        private readonly static string SETTINGS_FILE_PATH = Path.Combine(Application.StartupPath, "settings.txt");

        private int _pomodoroLength;
        private int _shortBreakLength;
        private int _longBreakLength;
        private int _pomodoroCycles = 4;

        public SettingsController()
        {
            this.ConfigureSettings();
        }
        protected void ConfigureSettings()
        {
            try 
            {
                string[] settings = File.ReadAllText(SETTINGS_FILE_PATH).Split('\n');
                SortedDictionary<String, int> settingsMap = new();

                foreach (string s in settings)
                {
                    string[] parts = s.Split('=');
                    settingsMap.Add(parts[0], int.Parse(parts[1]));
                }

                this._pomodoroLength = settingsMap["PomodoroLength"];
                this._shortBreakLength = settingsMap["ShortBreakLength"];
                this._longBreakLength = settingsMap["LongBreakLength"];
                this._pomodoroCycles = settingsMap["PomodoroCycles"];

            }
            catch (Exception e)
            { 
                this.ResetToDefault();
                Console.WriteLine(e);
            }
        }

        public SortedDictionary<String,int> GetSettings()
        {
            this.ConfigureSettings();
            SortedDictionary<String,int> settings = new()
            {
                { "PomodoroLength", this._pomodoroLength },
                { "ShortBreakLength", this._shortBreakLength },
                { "LongBreakLength", this._longBreakLength },
                { "PomodoroCycles", this._pomodoroCycles }
            };
            return settings;
        }

        public void UpdateSettings(int pomodoroLength, int shortBreakLength, int longBreakLength, int pomodoroCycles) {
            this._pomodoroLength= pomodoroLength;
            this._shortBreakLength= shortBreakLength;
            this._longBreakLength= longBreakLength;
            this._pomodoroCycles = pomodoroCycles;

            File.WriteAllText(SETTINGS_FILE_PATH, $"PomodoroLength={pomodoroLength}\nShortBreakLength={shortBreakLength}\nLongBreakLength={longBreakLength}\nPomodoroCycles={pomodoroCycles}");
        }

        public void ResetToDefault()
        {
            this._pomodoroLength = 1500;
            this._shortBreakLength = 300;
            this._longBreakLength = 1800;
            this._pomodoroCycles = 4;

            File.WriteAllText(SETTINGS_FILE_PATH, $"PomodoroLength={DEFAULT_POMDORO_LENGTH}\nShortBreakLength={DEFAULT_SHORT_BREAK}\nLongBreakLength={DEFAULT_LONG_BREAK}\nPomodoroCycles={DEFAULT_POMODORO_CYCLES}");
        }
    }
}
