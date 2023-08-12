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
            timer_focus = new System.Windows.Forms.Timer(components);
            timer_break = new System.Windows.Forms.Timer(components);
            panel_settings = new Panel();
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
            panel_settings.SuspendLayout();
            SuspendLayout();
            // 
            // timer_focus
            // 
            timer_focus.Interval = 1000;
            timer_focus.Tick += timer_focus_Tick;
            // 
            // timer_break
            // 
            timer_break.Interval = 1000;
            // 
            // panel_settings
            // 
            panel_settings.Controls.Add(txt_pomodorocycles);
            panel_settings.Controls.Add(label_pomodorocycles);
            panel_settings.Controls.Add(txt_longbreak);
            panel_settings.Controls.Add(txt_shortbreak);
            panel_settings.Controls.Add(txt_pomodoro);
            panel_settings.Controls.Add(btn_applysettings);
            panel_settings.Controls.Add(label_longbreak);
            panel_settings.Controls.Add(label_shortbreak);
            panel_settings.Controls.Add(label_pomodoro);
            panel_settings.Location = new Point(14, 16);
            panel_settings.Margin = new Padding(3, 4, 3, 4);
            panel_settings.Name = "panel_settings";
            panel_settings.Size = new Size(887, 568);
            panel_settings.TabIndex = 6;
            panel_settings.Visible = false;
            // 
            // txt_pomodorocycles
            // 
            txt_pomodorocycles.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pomodorocycles.Location = new Point(408, 327);
            txt_pomodorocycles.Margin = new Padding(3, 4, 3, 4);
            txt_pomodorocycles.Name = "txt_pomodorocycles";
            txt_pomodorocycles.Size = new Size(114, 40);
            txt_pomodorocycles.TabIndex = 8;
            txt_pomodorocycles.Text = "4";
            // 
            // label_pomodorocycles
            // 
            label_pomodorocycles.AutoSize = true;
            label_pomodorocycles.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_pomodorocycles.Location = new Point(35, 320);
            label_pomodorocycles.Name = "label_pomodorocycles";
            label_pomodorocycles.Size = new Size(371, 33);
            label_pomodorocycles.TabIndex = 7;
            label_pomodorocycles.Text = "Pomodoros between long breaks";
            // 
            // txt_longbreak
            // 
            txt_longbreak.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_longbreak.Location = new Point(408, 244);
            txt_longbreak.Margin = new Padding(3, 4, 3, 4);
            txt_longbreak.Name = "txt_longbreak";
            txt_longbreak.Size = new Size(114, 40);
            txt_longbreak.TabIndex = 6;
            txt_longbreak.Text = "30";
            // 
            // txt_shortbreak
            // 
            txt_shortbreak.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_shortbreak.Location = new Point(408, 160);
            txt_shortbreak.Margin = new Padding(3, 4, 3, 4);
            txt_shortbreak.Name = "txt_shortbreak";
            txt_shortbreak.Size = new Size(114, 40);
            txt_shortbreak.TabIndex = 5;
            txt_shortbreak.Text = "5";
            // 
            // txt_pomodoro
            // 
            txt_pomodoro.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pomodoro.Location = new Point(408, 75);
            txt_pomodoro.Margin = new Padding(3, 4, 3, 4);
            txt_pomodoro.Name = "txt_pomodoro";
            txt_pomodoro.Size = new Size(114, 40);
            txt_pomodoro.TabIndex = 4;
            txt_pomodoro.Text = "25";
            // 
            // btn_applysettings
            // 
            btn_applysettings.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_applysettings.Location = new Point(362, 456);
            btn_applysettings.Margin = new Padding(3, 4, 3, 4);
            btn_applysettings.Name = "btn_applysettings";
            btn_applysettings.Size = new Size(194, 55);
            btn_applysettings.TabIndex = 3;
            btn_applysettings.Text = "Apply Settings";
            btn_applysettings.UseVisualStyleBackColor = true;
            btn_applysettings.Click += btn_applysettings_Click;
            // 
            // label_longbreak
            // 
            label_longbreak.AutoSize = true;
            label_longbreak.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_longbreak.Location = new Point(35, 237);
            label_longbreak.Name = "label_longbreak";
            label_longbreak.Size = new Size(332, 33);
            label_longbreak.TabIndex = 2;
            label_longbreak.Text = "Long break length (minutes):";
            // 
            // label_shortbreak
            // 
            label_shortbreak.AutoSize = true;
            label_shortbreak.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_shortbreak.Location = new Point(35, 153);
            label_shortbreak.Name = "label_shortbreak";
            label_shortbreak.Size = new Size(345, 33);
            label_shortbreak.TabIndex = 1;
            label_shortbreak.Text = "Short break length (minutes):";
            // 
            // label_pomodoro
            // 
            label_pomodoro.AutoSize = true;
            label_pomodoro.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_pomodoro.Location = new Point(35, 68);
            label_pomodoro.Name = "label_pomodoro";
            label_pomodoro.Size = new Size(323, 33);
            label_pomodoro.TabIndex = 0;
            label_pomodoro.Text = "Pomodoro Length (minutes):";
            // 
            // btn_settings
            // 
            btn_settings.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_settings.Location = new Point(745, 55);
            btn_settings.Margin = new Padding(3, 4, 3, 4);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(117, 48);
            btn_settings.TabIndex = 19;
            btn_settings.Text = "Settings";
            btn_settings.UseVisualStyleBackColor = true;
            btn_settings.Click += btn_settings_Click;
            // 
            // label_state
            // 
            label_state.AutoSize = true;
            label_state.Font = new Font("Comic Sans MS", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_state.ImageAlign = ContentAlignment.MiddleRight;
            label_state.Location = new Point(389, 41);
            label_state.Name = "label_state";
            label_state.Size = new Size(169, 59);
            label_state.TabIndex = 18;
            label_state.Text = "FOCUS";
            // 
            // btn_stop
            // 
            btn_stop.BackColor = Color.LightCoral;
            btn_stop.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_stop.Location = new Point(553, 509);
            btn_stop.Margin = new Padding(3, 4, 3, 4);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(160, 47);
            btn_stop.TabIndex = 17;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = false;
            btn_stop.Click += btn_stop_Click;
            // 
            // btn_continue
            // 
            btn_continue.BackColor = Color.LightGreen;
            btn_continue.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_continue.Location = new Point(376, 417);
            btn_continue.Margin = new Padding(3, 4, 3, 4);
            btn_continue.Name = "btn_continue";
            btn_continue.Size = new Size(160, 47);
            btn_continue.TabIndex = 16;
            btn_continue.Text = "Continue";
            btn_continue.UseVisualStyleBackColor = false;
            btn_continue.Click += btn_continue_Click;
            // 
            // btn_pause
            // 
            btn_pause.BackColor = Color.LightYellow;
            btn_pause.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_pause.Location = new Point(193, 509);
            btn_pause.Margin = new Padding(3, 4, 3, 4);
            btn_pause.Name = "btn_pause";
            btn_pause.Size = new Size(160, 47);
            btn_pause.TabIndex = 15;
            btn_pause.Text = "Pause";
            btn_pause.UseVisualStyleBackColor = false;
            btn_pause.Click += btn_pause_Click;
            // 
            // label_timer
            // 
            label_timer.AutoSize = true;
            label_timer.Font = new Font("Comic Sans MS", 100F, FontStyle.Regular, GraphicsUnit.Point);
            label_timer.Location = new Point(193, 133);
            label_timer.Name = "label_timer";
            label_timer.Size = new Size(555, 232);
            label_timer.TabIndex = 14;
            label_timer.Text = "25:00";
            // 
            // btn_start
            // 
            btn_start.BackColor = Color.LightBlue;
            btn_start.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_start.Location = new Point(362, 496);
            btn_start.Margin = new Padding(3, 4, 3, 4);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(184, 59);
            btn_start.TabIndex = 13;
            btn_start.Text = "Start Timer";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel_settings);
            Controls.Add(btn_settings);
            Controls.Add(label_state);
            Controls.Add(btn_stop);
            Controls.Add(btn_continue);
            Controls.Add(btn_pause);
            Controls.Add(label_timer);
            Controls.Add(btn_start);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}
