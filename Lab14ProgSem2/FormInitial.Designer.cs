namespace Lab14ProgSem2
{
    partial class FormInitial
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.RotateTextBtn = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerText = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(458, 219);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(172, 239);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(97, 53);
            this.buttonGen.TabIndex = 15;
            this.buttonGen.Text = "Generate";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(298, 240);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(97, 53);
            this.buttonLogin.TabIndex = 14;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // RotateTextBtn
            // 
            this.RotateTextBtn.Enabled = false;
            this.RotateTextBtn.Location = new System.Drawing.Point(429, 269);
            this.RotateTextBtn.Name = "RotateTextBtn";
            this.RotateTextBtn.Size = new System.Drawing.Size(75, 23);
            this.RotateTextBtn.TabIndex = 13;
            this.RotateTextBtn.Text = "Move Text";
            this.RotateTextBtn.UseVisualStyleBackColor = true;
            this.RotateTextBtn.Click += new System.EventHandler(this.RotateTextBtn_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(429, 239);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 12;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(15, 239);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(137, 54);
            this.richTextBox.TabIndex = 11;
            this.richTextBox.Text = "";
            // 
            // buttonRotate
            // 
            this.buttonRotate.Enabled = false;
            this.buttonRotate.Location = new System.Drawing.Point(510, 239);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(75, 23);
            this.buttonRotate.TabIndex = 10;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(510, 269);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 9;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // timer
            // 
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerText
            // 
            this.timerText.Tick += new System.EventHandler(this.timerText_Tick);
            // 
            // FormInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 317);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.RotateTextBtn);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.pictureBox);
            this.Name = "FormInitial";
            this.Text = "Moving";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.Button buttonGen;
        public System.Windows.Forms.Button buttonLogin;
        public System.Windows.Forms.Button RotateTextBtn;
        public System.Windows.Forms.Button buttonStop;
        public System.Windows.Forms.RichTextBox richTextBox;
        public System.Windows.Forms.Button buttonRotate;
        public System.Windows.Forms.Button buttonDraw;
        public System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Timer timerText;
    }
}

