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
            btn_start = new Button();
            label_timer = new Label();
            timer_focus = new System.Windows.Forms.Timer(components);
            btn_pause = new Button();
            btn_continue = new Button();
            btn_stop = new Button();
            timer_break = new System.Windows.Forms.Timer(components);
            label_state = new Label();
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.BackColor = Color.LightBlue;
            btn_start.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_start.Location = new Point(320, 369);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(161, 44);
            btn_start.TabIndex = 0;
            btn_start.Text = "Start Timer";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_Click;
            // 
            // label_timer
            // 
            label_timer.AutoSize = true;
            label_timer.Font = new Font("Comic Sans MS", 100F, FontStyle.Regular, GraphicsUnit.Point);
            label_timer.Location = new Point(172, 97);
            label_timer.Name = "label_timer";
            label_timer.Size = new Size(446, 186);
            label_timer.TabIndex = 1;
            label_timer.Text = "25:00";
            // 
            // timer_focus
            // 
            timer_focus.Interval = 1000;
            timer_focus.Tick += timer_focus_Tick;
            // 
            // btn_pause
            // 
            btn_pause.BackColor = Color.LightYellow;
            btn_pause.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_pause.Location = new Point(172, 379);
            btn_pause.Name = "btn_pause";
            btn_pause.Size = new Size(140, 35);
            btn_pause.TabIndex = 2;
            btn_pause.Text = "Pause";
            btn_pause.UseVisualStyleBackColor = false;
            btn_pause.Click += btn_pause_Click;
            // 
            // btn_continue
            // 
            btn_continue.BackColor = Color.LightGreen;
            btn_continue.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_continue.Location = new Point(332, 310);
            btn_continue.Name = "btn_continue";
            btn_continue.Size = new Size(140, 35);
            btn_continue.TabIndex = 3;
            btn_continue.Text = "Continue";
            btn_continue.UseVisualStyleBackColor = false;
            btn_continue.Click += btn_continue_Click;
            // 
            // btn_stop
            // 
            btn_stop.BackColor = Color.LightCoral;
            btn_stop.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_stop.Location = new Point(487, 379);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(140, 35);
            btn_stop.TabIndex = 4;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = false;
            btn_stop.Click += btn_stop_Click;
            // 
            // timer_break
            // 
            timer_break.Interval = 1000;
            // 
            // label_state
            // 
            label_state.AutoSize = true;
            label_state.Font = new Font("Comic Sans MS", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_state.ImageAlign = ContentAlignment.MiddleRight;
            label_state.Location = new Point(343, 28);
            label_state.Name = "label_state";
            label_state.Size = new Size(133, 46);
            label_state.TabIndex = 5;
            label_state.Text = "FOCUS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_state);
            Controls.Add(btn_stop);
            Controls.Add(btn_continue);
            Controls.Add(btn_pause);
            Controls.Add(label_timer);
            Controls.Add(btn_start);
            Name = "Form1";
            Text = "Pomodoro Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_start;
        private Label label_timer;
        private System.Windows.Forms.Timer timer_focus;
        private Button btn_pause;
        private Button btn_continue;
        private Button btn_stop;
        private System.Windows.Forms.Timer timer_break;
        private Label label_state;

    }
}
