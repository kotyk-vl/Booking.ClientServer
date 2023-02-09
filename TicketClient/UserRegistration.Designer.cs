namespace lab2
{
    partial class UserRegistration
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
            this.button_Reg = new System.Windows.Forms.Button();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_log = new System.Windows.Forms.Label();
            this.label_Reg = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_FName = new System.Windows.Forms.Label();
            this.label_LNam = new System.Windows.Forms.Label();
            this.maskedTextBox_Fname = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Lname = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button_Reg
            // 
            this.button_Reg.BackColor = System.Drawing.Color.LightGreen;
            this.button_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_Reg.Location = new System.Drawing.Point(153, 343);
            this.button_Reg.Name = "button_Reg";
            this.button_Reg.Size = new System.Drawing.Size(288, 47);
            this.button_Reg.TabIndex = 6;
            this.button_Reg.Text = "Зареєструватись";
            this.button_Reg.UseVisualStyleBackColor = false;
            this.button_Reg.Click += new System.EventHandler(this.button_Reg_Click);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.Location = new System.Drawing.Point(153, 279);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '*';
            this.textBox_pass.Size = new System.Drawing.Size(326, 29);
            this.textBox_pass.TabIndex = 5;
            // 
            // textBox_Log
            // 
            this.textBox_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Log.Location = new System.Drawing.Point(153, 166);
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.Size = new System.Drawing.Size(326, 29);
            this.textBox_Log.TabIndex = 3;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(12, 279);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(115, 31);
            this.label_pass.TabIndex = 3;
            this.label_pass.Text = "Пароль ";
            this.label_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_log
            // 
            this.label_log.AutoSize = true;
            this.label_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_log.Location = new System.Drawing.Point(12, 166);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(86, 31);
            this.label_log.TabIndex = 4;
            this.label_log.Text = "Логін ";
            this.label_log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Reg
            // 
            this.label_Reg.AutoSize = true;
            this.label_Reg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Reg.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_Reg.Location = new System.Drawing.Point(213, 9);
            this.label_Reg.Name = "label_Reg";
            this.label_Reg.Size = new System.Drawing.Size(175, 37);
            this.label_Reg.TabIndex = 5;
            this.label_Reg.Text = "Реєстрація";
            this.label_Reg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mail.Location = new System.Drawing.Point(12, 226);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(90, 31);
            this.label_mail.TabIndex = 10;
            this.label_mail.Text = "E-mail";
            this.label_mail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_mail
            // 
            this.textBox_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mail.Location = new System.Drawing.Point(153, 226);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(326, 29);
            this.textBox_mail.TabIndex = 4;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_exit.Location = new System.Drawing.Point(445, 420);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(120, 30);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Назад";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_FName
            // 
            this.label_FName.AutoSize = true;
            this.label_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FName.Location = new System.Drawing.Point(12, 115);
            this.label_FName.Name = "label_FName";
            this.label_FName.Size = new System.Drawing.Size(61, 31);
            this.label_FName.TabIndex = 12;
            this.label_FName.Text = "Ім\'я";
            this.label_FName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_LNam
            // 
            this.label_LNam.AutoSize = true;
            this.label_LNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LNam.Location = new System.Drawing.Point(12, 59);
            this.label_LNam.Name = "label_LNam";
            this.label_LNam.Size = new System.Drawing.Size(135, 31);
            this.label_LNam.TabIndex = 13;
            this.label_LNam.Text = "Прізвище";
            this.label_LNam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox_Fname
            // 
            this.maskedTextBox_Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Fname.Location = new System.Drawing.Point(153, 112);
            this.maskedTextBox_Fname.Name = "maskedTextBox_Fname";
            this.maskedTextBox_Fname.PromptChar = ' ';
            this.maskedTextBox_Fname.Size = new System.Drawing.Size(325, 29);
            this.maskedTextBox_Fname.TabIndex = 2;
            this.maskedTextBox_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox_Fname_KeyPress);
            // 
            // maskedTextBox_Lname
            // 
            this.maskedTextBox_Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Lname.Location = new System.Drawing.Point(153, 61);
            this.maskedTextBox_Lname.Name = "maskedTextBox_Lname";
            this.maskedTextBox_Lname.PromptChar = ' ';
            this.maskedTextBox_Lname.Size = new System.Drawing.Size(325, 29);
            this.maskedTextBox_Lname.TabIndex = 1;
            this.maskedTextBox_Lname.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_Lname_MaskInputRejected);
            this.maskedTextBox_Lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox_Lname_KeyPress);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 462);
            this.Controls.Add(this.maskedTextBox_Lname);
            this.Controls.Add(this.maskedTextBox_Fname);
            this.Controls.Add(this.label_LNam);
            this.Controls.Add(this.label_FName);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.button_Reg);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.textBox_Log);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_log);
            this.Controls.Add(this.label_Reg);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Reg;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_Log;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.Label label_Reg;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_FName;
        private System.Windows.Forms.Label label_LNam;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Fname;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Lname;
    }
}