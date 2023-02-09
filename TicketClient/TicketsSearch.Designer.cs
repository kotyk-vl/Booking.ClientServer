namespace lab2
{
    partial class TicketsSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsSearch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_From = new System.Windows.Forms.TextBox();
            this.label_From = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_Date_Dep = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_To = new System.Windows.Forms.TextBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_back = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Звідки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Куди = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_Час = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер_поїзда = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вагонів = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Кількість_місць = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вибрати = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_From
            // 
            this.textBox_From.AutoCompleteCustomSource.AddRange(new string[] {
            "Львів",
            "Київ",
            "Рівне",
            "Харків",
            "Одеса"});
            this.textBox_From.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_From.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_From.Location = new System.Drawing.Point(115, 85);
            this.textBox_From.Name = "textBox_From";
            this.textBox_From.Size = new System.Drawing.Size(160, 26);
            this.textBox_From.TabIndex = 0;
            this.textBox_From.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_From_KeyPress);
            this.textBox_From.Leave += new System.EventHandler(this.textBox_From_Leave);
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_From.Location = new System.Drawing.Point(51, 57);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(76, 25);
            this.label_From.TabIndex = 1;
            this.label_From.Text = "Звідки";
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_To.Location = new System.Drawing.Point(509, 57);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(61, 25);
            this.label_To.TabIndex = 1;
            this.label_To.Text = "Куди";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 168);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 10, 30, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2019, 10, 30, 0, 0, 0, 0);
            // 
            // label_Date_Dep
            // 
            this.label_Date_Dep.AutoSize = true;
            this.label_Date_Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date_Dep.Location = new System.Drawing.Point(51, 131);
            this.label_Date_Dep.Name = "label_Date_Dep";
            this.label_Date_Dep.Size = new System.Drawing.Size(202, 25);
            this.label_Date_Dep.TabIndex = 1;
            this.label_Date_Dep.Text = "Дата відправлення";
            // 
            // button_Search
            // 
            this.button_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Search.FlatAppearance.BorderSize = 0;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Search.Location = new System.Drawing.Point(293, 405);
            this.button_Search.Margin = new System.Windows.Forms.Padding(0);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(277, 48);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Пошук ";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_To
            // 
            this.textBox_To.AutoCompleteCustomSource.AddRange(new string[] {
            "Львів",
            "Київ",
            "Рівне",
            "Харків",
            "Одеса"});
            this.textBox_To.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_To.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_To.Location = new System.Drawing.Point(582, 85);
            this.textBox_To.Name = "textBox_To";
            this.textBox_To.Size = new System.Drawing.Size(160, 26);
            this.textBox_To.TabIndex = 1;
            this.textBox_To.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_To_KeyPress);
            this.textBox_To.Leave += new System.EventHandler(this.textBox_To_Leave);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.Control;
            this.button_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_exit.BackgroundImage")));
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_exit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_exit.Location = new System.Drawing.Point(12, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(64, 42);
            this.button_exit.TabIndex = 6;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            this.button_exit.MouseEnter += new System.EventHandler(this.button_exit_MouseEnter);
            this.button_exit.MouseLeave += new System.EventHandler(this.button_exit_MouseLeave);
            // 
            // label_back
            // 
            this.label_back.AutoSize = true;
            this.label_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_back.Location = new System.Drawing.Point(82, 25);
            this.label_back.Name = "label_back";
            this.label_back.Size = new System.Drawing.Size(58, 20);
            this.label_back.TabIndex = 7;
            this.label_back.Text = "Назад";
            this.label_back.Visible = false;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(640, 132);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(60, 24);
            this.label_Time.TabIndex = 8;
            this.label_Time.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Час зараз :";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(640, 168);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(60, 24);
            this.label_Date.TabIndex = 8;
            this.label_Date.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(175)))), ((int)(((byte)(237)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Звідки,
            this.Куди,
            this.Дата_Час,
            this.Номер_поїзда,
            this.Вагонів,
            this.Кількість_місць,
            this.Вибрати});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(889, 206);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Звідки
            // 
            this.Звідки.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.NullValue = null;
            this.Звідки.DefaultCellStyle = dataGridViewCellStyle1;
            this.Звідки.HeaderText = "Звідки";
            this.Звідки.Name = "Звідки";
            this.Звідки.ReadOnly = true;
            // 
            // Куди
            // 
            this.Куди.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Куди.HeaderText = "Куди";
            this.Куди.Name = "Куди";
            this.Куди.ReadOnly = true;
            // 
            // Дата_Час
            // 
            this.Дата_Час.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Дата_Час.HeaderText = "Дата_Час";
            this.Дата_Час.Name = "Дата_Час";
            this.Дата_Час.ReadOnly = true;
            // 
            // Номер_поїзда
            // 
            this.Номер_поїзда.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Номер_поїзда.HeaderText = "Номер_поїзда";
            this.Номер_поїзда.Name = "Номер_поїзда";
            this.Номер_поїзда.ReadOnly = true;
            // 
            // Вагонів
            // 
            this.Вагонів.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Вагонів.HeaderText = "Вагонів";
            this.Вагонів.Name = "Вагонів";
            this.Вагонів.ReadOnly = true;
            // 
            // Кількість_місць
            // 
            this.Кількість_місць.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Кількість_місць.HeaderText = "Кількість_місць";
            this.Кількість_місць.Name = "Кількість_місць";
            this.Кількість_місць.ReadOnly = true;
            // 
            // Вибрати
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(222)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Вибрати.DefaultCellStyle = dataGridViewCellStyle2;
            this.Вибрати.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Вибрати.HeaderText = "";
            this.Вибрати.Name = "Вибрати";
            this.Вибрати.ReadOnly = true;
            this.Вибрати.Text = "Вибрати";
            this.Вибрати.UseColumnTextForButtonValue = true;
            // 
            // Form5_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 462);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_back);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_Date_Dep);
            this.Controls.Add(this.label_To);
            this.Controls.Add(this.label_From);
            this.Controls.Add(this.textBox_To);
            this.Controls.Add(this.textBox_From);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пошук";
            this.Load += new System.EventHandler(this.Form5_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_From;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_Date_Dep;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_To;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_back;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Звідки;
        private System.Windows.Forms.DataGridViewTextBoxColumn Куди;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_Час;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер_поїзда;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вагонів;
        private System.Windows.Forms.DataGridViewTextBoxColumn Кількість_місць;
        private System.Windows.Forms.DataGridViewButtonColumn Вибрати;
    }
}