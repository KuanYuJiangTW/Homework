namespace Lab_Homework
{
    partial class Lab_Homework01
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab_Homework01));
            this.Say_HELLO = new System.Windows.Forms.Button();
            this.Say_Hi = new System.Windows.Forms.Button();
            this.CN_Name = new System.Windows.Forms.Label();
            this.EN_Name = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.CON = new System.Windows.Forms.Label();
            this.textCN_Name = new System.Windows.Forms.TextBox();
            this.textEN_Name = new System.Windows.Forms.TextBox();
            this.text_Sex = new System.Windows.Forms.TextBox();
            this.text_CON = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Say_HELLO
            // 
            this.Say_HELLO.Font = new System.Drawing.Font("SetoFont", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Say_HELLO.Location = new System.Drawing.Point(41, 323);
            this.Say_HELLO.Name = "Say_HELLO";
            this.Say_HELLO.Size = new System.Drawing.Size(139, 31);
            this.Say_HELLO.TabIndex = 0;
            this.Say_HELLO.Text = "Say HELLO!";
            this.Say_HELLO.UseVisualStyleBackColor = true;
            this.Say_HELLO.Click += new System.EventHandler(this.Say_HELLO_Click);
            // 
            // Say_Hi
            // 
            this.Say_Hi.Font = new System.Drawing.Font("SetoFont", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Say_Hi.Location = new System.Drawing.Point(199, 323);
            this.Say_Hi.Name = "Say_Hi";
            this.Say_Hi.Size = new System.Drawing.Size(108, 31);
            this.Say_Hi.TabIndex = 1;
            this.Say_Hi.Text = "Say Hi!";
            this.Say_Hi.UseMnemonic = false;
            this.Say_Hi.UseVisualStyleBackColor = true;
            this.Say_Hi.Click += new System.EventHandler(this.Say_Hi_Click);
            // 
            // CN_Name
            // 
            this.CN_Name.AutoSize = true;
            this.CN_Name.BackColor = System.Drawing.Color.Transparent;
            this.CN_Name.Font = new System.Drawing.Font("SetoFont", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CN_Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CN_Name.Location = new System.Drawing.Point(37, 71);
            this.CN_Name.Name = "CN_Name";
            this.CN_Name.Size = new System.Drawing.Size(70, 24);
            this.CN_Name.TabIndex = 2;
            this.CN_Name.Text = "姓名:";
            // 
            // EN_Name
            // 
            this.EN_Name.AutoSize = true;
            this.EN_Name.BackColor = System.Drawing.Color.Transparent;
            this.EN_Name.Font = new System.Drawing.Font("SetoFont", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EN_Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EN_Name.Location = new System.Drawing.Point(37, 124);
            this.EN_Name.Name = "EN_Name";
            this.EN_Name.Size = new System.Drawing.Size(166, 24);
            this.EN_Name.TabIndex = 3;
            this.EN_Name.Text = "English Name:";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.BackColor = System.Drawing.Color.Transparent;
            this.Sex.Font = new System.Drawing.Font("SetoFont", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sex.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sex.Location = new System.Drawing.Point(37, 174);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(73, 24);
            this.Sex.TabIndex = 4;
            this.Sex.Text = "性別:";
            // 
            // CON
            // 
            this.CON.AutoSize = true;
            this.CON.BackColor = System.Drawing.Color.Transparent;
            this.CON.Font = new System.Drawing.Font("SetoFont", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CON.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CON.Location = new System.Drawing.Point(37, 226);
            this.CON.Name = "CON";
            this.CON.Size = new System.Drawing.Size(73, 24);
            this.CON.TabIndex = 5;
            this.CON.Text = "星座:";
            // 
            // textCN_Name
            // 
            this.textCN_Name.Font = new System.Drawing.Font("SetoFont", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textCN_Name.Location = new System.Drawing.Point(207, 71);
            this.textCN_Name.Name = "textCN_Name";
            this.textCN_Name.Size = new System.Drawing.Size(100, 31);
            this.textCN_Name.TabIndex = 6;
            // 
            // textEN_Name
            // 
            this.textEN_Name.Font = new System.Drawing.Font("SetoFont", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textEN_Name.Location = new System.Drawing.Point(207, 124);
            this.textEN_Name.Name = "textEN_Name";
            this.textEN_Name.Size = new System.Drawing.Size(100, 31);
            this.textEN_Name.TabIndex = 7;
            // 
            // text_Sex
            // 
            this.text_Sex.Font = new System.Drawing.Font("SetoFont", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_Sex.Location = new System.Drawing.Point(207, 174);
            this.text_Sex.Name = "text_Sex";
            this.text_Sex.Size = new System.Drawing.Size(100, 31);
            this.text_Sex.TabIndex = 8;
            // 
            // text_CON
            // 
            this.text_CON.Font = new System.Drawing.Font("SetoFont", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_CON.Location = new System.Drawing.Point(207, 226);
            this.text_CON.Name = "text_CON";
            this.text_CON.Size = new System.Drawing.Size(100, 31);
            this.text_CON.TabIndex = 9;
            // 
            // Lab_Homework01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(644, 429);
            this.Controls.Add(this.text_CON);
            this.Controls.Add(this.text_Sex);
            this.Controls.Add(this.textEN_Name);
            this.Controls.Add(this.textCN_Name);
            this.Controls.Add(this.CON);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.EN_Name);
            this.Controls.Add(this.CN_Name);
            this.Controls.Add(this.Say_Hi);
            this.Controls.Add(this.Say_HELLO);
            this.Name = "Lab_Homework01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "你好! C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Say_HELLO;
        private System.Windows.Forms.Button Say_Hi;
        private System.Windows.Forms.Label CN_Name;
        private System.Windows.Forms.Label EN_Name;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label CON;
        private System.Windows.Forms.TextBox textCN_Name;
        private System.Windows.Forms.TextBox textEN_Name;
        private System.Windows.Forms.TextBox text_Sex;
        private System.Windows.Forms.TextBox text_CON;
    }
}

