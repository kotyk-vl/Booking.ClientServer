namespace lab2
{
    partial class TicketsHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label_back = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Звідки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Куди = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_Час = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер_поїзда = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Місце = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вагон = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Прізвище = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Імя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Історія замовлень";
            // 
            // label_back
            // 
            this.label_back.AutoSize = true;
            this.label_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_back.Location = new System.Drawing.Point(82, 23);
            this.label_back.Name = "label_back";
            this.label_back.Size = new System.Drawing.Size(58, 20);
            this.label_back.TabIndex = 11;
            this.label_back.Text = "Назад";
            this.label_back.Visible = false;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_exit.BackgroundImage")));
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_exit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_exit.Location = new System.Drawing.Point(12, 10);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(64, 42);
            this.button_exit.TabIndex = 10;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            this.button_exit.MouseEnter += new System.EventHandler(this.button_exit_MouseEnter);
            this.button_exit.MouseLeave += new System.EventHandler(this.button_exit_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Звідки,
            this.Куди,
            this.Дата_Час,
            this.Номер_поїзда,
            this.Місце,
            this.Вагон,
            this.Прізвище,
            this.Імя});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(567, 375);
            this.dataGridView1.TabIndex = 12;
            // 
            // Звідки
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.Звідки.DefaultCellStyle = dataGridViewCellStyle1;
            this.Звідки.HeaderText = "Звідки";
            this.Звідки.Name = "Звідки";
            this.Звідки.ReadOnly = true;
            this.Звідки.Width = 75;
            // 
            // Куди
            // 
            this.Куди.HeaderText = "Куди";
            this.Куди.Name = "Куди";
            this.Куди.ReadOnly = true;
            this.Куди.Width = 75;
            // 
            // Дата_Час
            // 
            this.Дата_Час.HeaderText = "Дата_Час";
            this.Дата_Час.Name = "Дата_Час";
            this.Дата_Час.ReadOnly = true;
            this.Дата_Час.Width = 110;
            // 
            // Номер_поїзда
            // 
            this.Номер_поїзда.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Номер_поїзда.HeaderText = "Номер_поїзда";
            this.Номер_поїзда.Name = "Номер_поїзда";
            this.Номер_поїзда.ReadOnly = true;
            this.Номер_поїзда.Width = 72;
            // 
            // Місце
            // 
            this.Місце.HeaderText = "Місце";
            this.Місце.Name = "Місце";
            this.Місце.ReadOnly = true;
            this.Місце.Width = 65;
            // 
            // Вагон
            // 
            this.Вагон.HeaderText = "Вагон";
            this.Вагон.Name = "Вагон";
            this.Вагон.ReadOnly = true;
            this.Вагон.Width = 65;
            // 
            // Прізвище
            // 
            this.Прізвище.HeaderText = "Прізвище";
            this.Прізвище.Name = "Прізвище";
            this.Прізвище.ReadOnly = true;
            // 
            // Імя
            // 
            this.Імя.HeaderText = "Імя";
            this.Імя.Name = "Імя";
            this.Імя.ReadOnly = true;
            // 
            // Form6_Hist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 462);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_back);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6_Hist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Історія замовлень";
            this.Load += new System.EventHandler(this.Form6_Hist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_back;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Звідки;
        private System.Windows.Forms.DataGridViewTextBoxColumn Куди;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_Час;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер_поїзда;
        private System.Windows.Forms.DataGridViewTextBoxColumn Місце;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вагон;
        private System.Windows.Forms.DataGridViewTextBoxColumn Прізвище;
        private System.Windows.Forms.DataGridViewTextBoxColumn Імя;
    }
}