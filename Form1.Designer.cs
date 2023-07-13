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
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.Location = new Point(315, 363);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(161, 44);
            btn_start.TabIndex = 0;
            btn_start.Text = "Start Timer";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // label_timer
            // 
            label_timer.AutoSize = true;
            label_timer.Location = new Point(384, 214);
            label_timer.Name = "label_timer";
            label_timer.Size = new Size(38, 15);
            label_timer.TabIndex = 1;
            label_timer.Text = "label1";
            // 
            // timer_focus
            // 
            timer_focus.Interval = 1000;
            timer_focus.Tick += timer_focus_Tick;
            // 
            // btn_pause
            // 
            btn_pause.Location = new Point(315, 312);
            btn_pause.Name = "btn_pause";
            btn_pause.Size = new Size(161, 45);
            btn_pause.TabIndex = 2;
            btn_pause.Text = "Pause";
            btn_pause.UseVisualStyleBackColor = true;
            btn_pause.Click += btn_pause_Click;
            // 
            // btn_continue
            // 
            btn_continue.Location = new Point(213, 248);
            btn_continue.Name = "btn_continue";
            btn_continue.Size = new Size(161, 45);
            btn_continue.TabIndex = 3;
            btn_continue.Text = "Continue";
            btn_continue.UseVisualStyleBackColor = true;
            btn_continue.Click += btn_continue_Click;
            // 
            // btn_stop
            // 
            btn_stop.Location = new Point(413, 248);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(161, 45);
            btn_stop.TabIndex = 4;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = true;
            btn_stop.Click += btn_stop_Click;
            // 
            // timer_break
            // 
            timer_break.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_stop);
            Controls.Add(btn_continue);
            Controls.Add(btn_pause);
            Controls.Add(label_timer);
            Controls.Add(btn_start);
            Name = "Form1";
            Text = "Form1";
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
    }
}