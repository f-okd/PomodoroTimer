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
            timer_countdown = new System.Windows.Forms.Timer(components);
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
            // timer_countdown
            // 
            timer_countdown.Interval = 1000;
            timer_countdown.Tick += timer_countdown_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private System.Windows.Forms.Timer timer_countdown;
    }
}