namespace PomodoroTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer_focus = new System.Windows.Forms.Timer(components);
            timer_break = new System.Windows.Forms.Timer(components);
            panel_settings = new Panel();
            btn_cancel_settings = new Button();
            txt_pomodorocycles = new TextBox();
            label_pomodorocycles = new Label();
            txt_longbreak = new TextBox();
            txt_shortbreak = new TextBox();
            txt_pomodoro = new TextBox();
            btn_applysettings = new Button();
            label_longbreak = new Label();
            label_shortbreak = new Label();
            label_pomodoro = new Label();
            btn_settings = new Button();
            label_state = new Label();
            btn_stop = new Button();
            btn_continue = new Button();
            btn_pause = new Button();
            label_timer = new Label();
            btn_start = new Button();
            btn_reset_settings = new Button();
            panel_settings.SuspendLayout();
            SuspendLayout();
            // 
            // timer_focus
            // 
            timer_focus.Interval = 1000;
            timer_focus.Tick += Timer_focus_Tick;
            // 
            // timer_break
            // 
            timer_break.Interval = 1000;
            // 
            // panel_settings
            // 
            panel_settings.Controls.Add(btn_reset_settings);
            panel_settings.Controls.Add(btn_cancel_settings);
            panel_settings.Controls.Add(txt_pomodorocycles);
            panel_settings.Controls.Add(label_pomodorocycles);
            panel_settings.Controls.Add(txt_longbreak);
            panel_settings.Controls.Add(txt_shortbreak);
            panel_settings.Controls.Add(txt_pomodoro);
            panel_settings.Controls.Add(btn_applysettings);
            panel_settings.Controls.Add(label_longbreak);
            panel_settings.Controls.Add(label_shortbreak);
            panel_settings.Controls.Add(label_pomodoro);
            panel_settings.ForeColor = Color.Salmon;
            panel_settings.Location = new Point(13, 14);
            panel_settings.Name = "panel_settings";
            panel_settings.Size = new Size(776, 426);
            panel_settings.TabIndex = 6;
            panel_settings.Visible = false;
            // 
            // btn_cancel_settings
            // 
            btn_cancel_settings.BackColor = Color.BurlyWood;
            btn_cancel_settings.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancel_settings.ForeColor = Color.SaddleBrown;
            btn_cancel_settings.Location = new Point(714, 37);
            btn_cancel_settings.Name = "btn_cancel_settings";
            btn_cancel_settings.Size = new Size(43, 41);
            btn_cancel_settings.TabIndex = 9;
            btn_cancel_settings.Text = "X";
            btn_cancel_settings.UseVisualStyleBackColor = false;
            btn_cancel_settings.Click += btn_cancel_settings_Click;
            // 
            // txt_pomodorocycles
            // 
            txt_pomodorocycles.BackColor = Color.PeachPuff;
            txt_pomodorocycles.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pomodorocycles.ForeColor = Color.SaddleBrown;
            txt_pomodorocycles.Location = new Point(387, 240);
            txt_pomodorocycles.Name = "txt_pomodorocycles";
            txt_pomodorocycles.Size = new Size(100, 34);
            txt_pomodorocycles.TabIndex = 8;
            txt_pomodorocycles.Text = pomodoroController.PomodoroCycles.ToString();
            // 
            // label_pomodorocycles
            // 
            label_pomodorocycles.AutoSize = true;
            label_pomodorocycles.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_pomodorocycles.Location = new Point(22, 240);
            label_pomodorocycles.Name = "label_pomodorocycles";
            label_pomodorocycles.Size = new Size(319, 27);
            label_pomodorocycles.TabIndex = 7;
            label_pomodorocycles.Text = "Pomodoros between long breaks:";
            // 
            // txt_longbreak
            // 
            txt_longbreak.BackColor = Color.PeachPuff;
            txt_longbreak.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_longbreak.ForeColor = Color.SaddleBrown;
            txt_longbreak.Location = new Point(387, 178);
            txt_longbreak.Name = "txt_longbreak";
            txt_longbreak.Size = new Size(100, 34);
            txt_longbreak.TabIndex = 6;
            txt_longbreak.Text = pomodoroController.LongBreakLength.ToString();
            // 
            // txt_shortbreak
            // 
            txt_shortbreak.BackColor = Color.PeachPuff;
            txt_shortbreak.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_shortbreak.ForeColor = Color.SaddleBrown;
            txt_shortbreak.Location = new Point(387, 115);
            txt_shortbreak.Name = "txt_shortbreak";
            txt_shortbreak.Size = new Size(100, 34);
            txt_shortbreak.TabIndex = 5;
            txt_shortbreak.Text = pomodoroController.ShortBreakLength.ToString();
            // 
            // txt_pomodoro
            // 
            txt_pomodoro.BackColor = Color.PeachPuff;
            txt_pomodoro.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pomodoro.ForeColor = Color.SaddleBrown;
            txt_pomodoro.Location = new Point(387, 51);
            txt_pomodoro.Name = "txt_pomodoro";
            txt_pomodoro.Size = new Size(100, 34);
            txt_pomodoro.TabIndex = 4;
            txt_pomodoro.Text = pomodoroController.PomodoroLength.ToString();
            // 
            // btn_applysettings
            // 
            btn_applysettings.BackColor = Color.BurlyWood;
            btn_applysettings.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_applysettings.ForeColor = Color.SaddleBrown;
            btn_applysettings.Location = new Point(317, 342);
            btn_applysettings.Name = "btn_applysettings";
            btn_applysettings.Size = new Size(205, 41);
            btn_applysettings.TabIndex = 3;
            btn_applysettings.Text = "Apply Settings";
            btn_applysettings.UseVisualStyleBackColor = false;
            btn_applysettings.Click += Btn_applysettings_Click;
            // 
            // label_longbreak
            // 
            label_longbreak.AutoSize = true;
            label_longbreak.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_longbreak.Location = new Point(22, 178);
            label_longbreak.Name = "label_longbreak";
            label_longbreak.Size = new Size(277, 27);
            label_longbreak.TabIndex = 2;
            label_longbreak.Text = "Long break length (minutes):";
            // 
            // label_shortbreak
            // 
            label_shortbreak.AutoSize = true;
            label_shortbreak.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_shortbreak.ForeColor = Color.Salmon;
            label_shortbreak.Location = new Point(22, 115);
            label_shortbreak.Name = "label_shortbreak";
            label_shortbreak.Size = new Size(281, 27);
            label_shortbreak.TabIndex = 1;
            label_shortbreak.Text = "Short break length (minutes):";
            // 
            // label_pomodoro
            // 
            label_pomodoro.AutoSize = true;
            label_pomodoro.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_pomodoro.ForeColor = Color.Salmon;
            label_pomodoro.Location = new Point(22, 51);
            label_pomodoro.Name = "label_pomodoro";
            label_pomodoro.Size = new Size(277, 27);
            label_pomodoro.TabIndex = 0;
            label_pomodoro.Text = "Pomodoro Length (minutes):";
            // 
            // btn_settings
            // 
            btn_settings.BackColor = Color.PeachPuff;
            btn_settings.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_settings.ForeColor = Color.SaddleBrown;
            btn_settings.Location = new Point(657, 31);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(113, 36);
            btn_settings.TabIndex = 19;
            btn_settings.Text = "Settings";
            btn_settings.UseVisualStyleBackColor = false;
            btn_settings.Click += Btn_settings_Click;
            // 
            // label_state
            // 
            label_state.AutoSize = true;
            label_state.Font = new Font("Corbel", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_state.ForeColor = Color.Salmon;
            label_state.ImageAlign = ContentAlignment.MiddleRight;
            label_state.Location = new Point(340, 31);
            label_state.Name = "label_state";
            label_state.Size = new Size(122, 41);
            label_state.TabIndex = 18;
            label_state.Text = "FOCUS";
            // 
            // btn_stop
            // 
            btn_stop.BackColor = Color.LightCoral;
            btn_stop.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_stop.ForeColor = Color.SaddleBrown;
            btn_stop.Location = new Point(484, 382);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(140, 35);
            btn_stop.TabIndex = 17;
            btn_stop.Text = "End";
            btn_stop.UseVisualStyleBackColor = false;
            btn_stop.Click += Btn_stop_Click;
            // 
            // btn_continue
            // 
            btn_continue.BackColor = Color.LightGreen;
            btn_continue.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_continue.ForeColor = Color.SaddleBrown;
            btn_continue.Location = new Point(329, 313);
            btn_continue.Name = "btn_continue";
            btn_continue.Size = new Size(140, 35);
            btn_continue.TabIndex = 16;
            btn_continue.Text = "Continue";
            btn_continue.UseVisualStyleBackColor = false;
            btn_continue.Click += Btn_continue_Click;
            // 
            // btn_pause
            // 
            btn_pause.BackColor = Color.LightYellow;
            btn_pause.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_pause.ForeColor = Color.SaddleBrown;
            btn_pause.Location = new Point(169, 382);
            btn_pause.Name = "btn_pause";
            btn_pause.Size = new Size(140, 35);
            btn_pause.TabIndex = 15;
            btn_pause.Text = "Pause";
            btn_pause.UseVisualStyleBackColor = false;
            btn_pause.Click += Btn_pause_Click;
            // 
            // label_timer
            // 
            label_timer.AutoSize = true;
            label_timer.Font = new Font("Corbel", 100.200005F, FontStyle.Regular, GraphicsUnit.Point);
            label_timer.ForeColor = Color.Salmon;
            label_timer.Location = new Point(169, 100);
            label_timer.Name = "label_timer";
            label_timer.Size = new Size(448, 164);
            label_timer.TabIndex = 14;
            label_timer.Text = "START";
            // 
            // btn_start
            // 
            btn_start.BackColor = Color.LightBlue;
            btn_start.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_start.ForeColor = Color.SaddleBrown;
            btn_start.Location = new Point(317, 372);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(161, 44);
            btn_start.TabIndex = 13;
            btn_start.Text = "Start Timer";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += Btn_start_Click;
            // 
            // btn_reset_settings
            // 
            btn_reset_settings.BackColor = Color.BurlyWood;
            btn_reset_settings.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_reset_settings.ForeColor = Color.SaddleBrown;
            btn_reset_settings.Location = new Point(617, 37);
            btn_reset_settings.Name = "btn_reset_settings";
            btn_reset_settings.Size = new Size(91, 41);
            btn_reset_settings.TabIndex = 10;
            btn_reset_settings.Text = "Reset";
            btn_reset_settings.UseVisualStyleBackColor = false;
            btn_reset_settings.Click += btn_reset_settings_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_settings);
            Controls.Add(btn_settings);
            Controls.Add(label_state);
            Controls.Add(btn_stop);
            Controls.Add(btn_continue);
            Controls.Add(btn_pause);
            Controls.Add(label_timer);
            Controls.Add(btn_start);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Pomodoro Timer";
            panel_settings.ResumeLayout(false);
            panel_settings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private EventHandler btn_pause_Click()
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Timer timer_focus;
        private System.Windows.Forms.Timer timer_break;
        private Panel panel_settings;
        private Button btn_settings;
        private Label label_state;
        private Button btn_stop;
        private Button btn_continue;
        private Button btn_pause;
        private Label label_timer;
        private Button btn_start;
        private Button btn_applysettings;
        private Label label_longbreak;
        private Label label_shortbreak;
        private Label label_pomodoro;
        private TextBox txt_longbreak;
        private TextBox txt_shortbreak;
        private TextBox txt_pomodoro;
        private Label label_pomodorocycles;
        private TextBox txt_pomodorocycles;
        private Button btn_cancel_settings;
        private Button btn_reset_settings;
    }
}
