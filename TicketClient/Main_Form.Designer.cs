namespace lab2
{
    partial class Main_Form
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Log = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_history = new System.Windows.Forms.Button();
            this.button_tick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(889, 229);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_Search
            // 
            this.button_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Search.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Search.FlatAppearance.BorderSize = 0;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Search.Location = new System.Drawing.Point(344, 287);
            this.button_Search.Margin = new System.Windows.Forms.Padding(0);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(277, 85);
            this.button_Search.TabIndex = 0;
            this.button_Search.Text = "Пошук квитків";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Log
            // 
            this.button_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Log.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Log.FlatAppearance.BorderSize = 0;
            this.button_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Log.ForeColor = System.Drawing.Color.Blue;
            this.button_Log.Location = new System.Drawing.Point(3, 3);
            this.button_Log.Name = "button_Log";
            this.button_Log.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Log.Size = new System.Drawing.Size(231, 62);
            this.button_Log.TabIndex = 4;
            this.button_Log.Text = "Авторизація";
            this.button_Log.UseVisualStyleBackColor = false;
            this.button_Log.Click += new System.EventHandler(this.button_Log_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_history, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_tick, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Log, 0, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 287);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(237, 176);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // button_history
            // 
            this.button_history.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_history.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_history.FlatAppearance.BorderSize = 0;
            this.button_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_history.ForeColor = System.Drawing.Color.Blue;
            this.button_history.Location = new System.Drawing.Point(3, 124);
            this.button_history.Name = "button_history";
            this.button_history.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_history.Size = new System.Drawing.Size(231, 49);
            this.button_history.TabIndex = 6;
            this.button_history.Text = "Історія замовлень";
            this.button_history.UseVisualStyleBackColor = false;
            this.button_history.Visible = false;
            this.button_history.Click += new System.EventHandler(this.button_history_Click);
            // 
            // button_tick
            // 
            this.button_tick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_tick.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_tick.FlatAppearance.BorderSize = 0;
            this.button_tick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tick.ForeColor = System.Drawing.Color.Blue;
            this.button_tick.Location = new System.Drawing.Point(3, 71);
            this.button_tick.Name = "button_tick";
            this.button_tick.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_tick.Size = new System.Drawing.Size(231, 47);
            this.button_tick.TabIndex = 5;
            this.button_tick.Text = "Актуальні квитки";
            this.button_tick.UseVisualStyleBackColor = false;
            this.button_tick.Visible = false;
            this.button_tick.Click += new System.EventHandler(this.button_tick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(913, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Log;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_history;
        private System.Windows.Forms.Button button_tick;
    }
}

