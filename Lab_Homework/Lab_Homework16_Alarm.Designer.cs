namespace Lab_Homework
{
    partial class Lab_Homework16_Alarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab_Homework16_Alarm));
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupSelectTime = new System.Windows.Forms.GroupBox();
            this.labAT = new System.Windows.Forms.Label();
            this.checkSetAlarm = new System.Windows.Forms.CheckBox();
            this.textTime = new System.Windows.Forms.TextBox();
            this.labAlarmTime = new System.Windows.Forms.Label();
            this.groupSelectTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("SetoFont", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTime.Location = new System.Drawing.Point(50, 53);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(72, 27);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Time";
            this.labelTime.EnabledChanged += new System.EventHandler(this.Lab_Homework16_Alarm_Load);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupSelectTime
            // 
            this.groupSelectTime.BackColor = System.Drawing.Color.Transparent;
            this.groupSelectTime.Controls.Add(this.labAT);
            this.groupSelectTime.Controls.Add(this.checkSetAlarm);
            this.groupSelectTime.Controls.Add(this.textTime);
            this.groupSelectTime.Controls.Add(this.labAlarmTime);
            this.groupSelectTime.Font = new System.Drawing.Font("SetoFont", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupSelectTime.Location = new System.Drawing.Point(91, 124);
            this.groupSelectTime.Name = "groupSelectTime";
            this.groupSelectTime.Size = new System.Drawing.Size(472, 230);
            this.groupSelectTime.TabIndex = 1;
            this.groupSelectTime.TabStop = false;
            this.groupSelectTime.Text = "Select Time";
            // 
            // labAT
            // 
            this.labAT.AutoSize = true;
            this.labAT.Location = new System.Drawing.Point(32, 106);
            this.labAT.Name = "labAT";
            this.labAT.Size = new System.Drawing.Size(130, 19);
            this.labAT.TabIndex = 3;
            this.labAT.Text = "Alarm Time:";
            // 
            // checkSetAlarm
            // 
            this.checkSetAlarm.AutoSize = true;
            this.checkSetAlarm.Location = new System.Drawing.Point(172, 157);
            this.checkSetAlarm.Name = "checkSetAlarm";
            this.checkSetAlarm.Size = new System.Drawing.Size(127, 23);
            this.checkSetAlarm.TabIndex = 2;
            this.checkSetAlarm.Text = "Set Alarm";
            this.checkSetAlarm.UseVisualStyleBackColor = true;
            // 
            // textTime
            // 
            this.textTime.Location = new System.Drawing.Point(168, 103);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(131, 26);
            this.textTime.TabIndex = 1;
            this.textTime.Text = "__時__分__秒";
            this.textTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labAlarmTime
            // 
            this.labAlarmTime.AutoSize = true;
            this.labAlarmTime.Location = new System.Drawing.Point(173, 63);
            this.labAlarmTime.Name = "labAlarmTime";
            this.labAlarmTime.Size = new System.Drawing.Size(119, 19);
            this.labAlarmTime.TabIndex = 0;
            this.labAlarmTime.Text = "Alarm Time";
            // 
            // Lab_Homework16_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 387);
            this.Controls.Add(this.groupSelectTime);
            this.Controls.Add(this.labelTime);
            this.Name = "Lab_Homework16_Alarm";
            this.Text = "Lab_Homework16_Alarm";
            this.EnabledChanged += new System.EventHandler(this.Lab_Homework16_Alarm_Load);
            this.groupSelectTime.ResumeLayout(false);
            this.groupSelectTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupSelectTime;
        private System.Windows.Forms.CheckBox checkSetAlarm;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.Label labAlarmTime;
        private System.Windows.Forms.Label labAT;
    }
}