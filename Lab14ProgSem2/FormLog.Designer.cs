namespace Lab14ProgSem2
{
    partial class FormLog
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
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelActCode = new System.Windows.Forms.Label();
            this.labelPas = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.textBoxActCode = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(68, 123);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(102, 23);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelActCode
            // 
            this.labelActCode.AutoSize = true;
            this.labelActCode.Location = new System.Drawing.Point(22, 101);
            this.labelActCode.Name = "labelActCode";
            this.labelActCode.Size = new System.Drawing.Size(82, 13);
            this.labelActCode.TabIndex = 12;
            this.labelActCode.Text = "Activation Code";
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Location = new System.Drawing.Point(22, 65);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(53, 13);
            this.labelPas.TabIndex = 11;
            this.labelPas.Text = "Password";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(22, 25);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(33, 13);
            this.labelLog.TabIndex = 10;
            this.labelLog.Text = "Login";
            // 
            // textBoxActCode
            // 
            this.textBoxActCode.Location = new System.Drawing.Point(127, 95);
            this.textBoxActCode.Name = "textBoxActCode";
            this.textBoxActCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxActCode.TabIndex = 9;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(127, 59);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 8;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(127, 19);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 7;
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 162);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelActCode);
            this.Controls.Add(this.labelPas);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.textBoxActCode);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "FormLog";
            this.Text = "FormLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelActCode;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.TextBox textBoxActCode;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxLogin;
    }
}