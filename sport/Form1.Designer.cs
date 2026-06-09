namespace sport
{
    partial class Form1
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
            this.dataGridViewSections = new System.Windows.Forms.DataGridView();
            this.SectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoachName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxCountParticipants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSections)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSections
            // 
            this.dataGridViewSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SectionName,
            this.CoachName,
            this.MaxCountParticipants});
            this.dataGridViewSections.Location = new System.Drawing.Point(119, 67);
            this.dataGridViewSections.Name = "dataGridViewSections";
            this.dataGridViewSections.Size = new System.Drawing.Size(342, 201);
            this.dataGridViewSections.TabIndex = 0;
            this.dataGridViewSections.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSections_CellClick);
            // 
            // SectionName
            // 
            this.SectionName.HeaderText = "Название секции";
            this.SectionName.Name = "SectionName";
            // 
            // CoachName
            // 
            this.CoachName.HeaderText = "Тренер";
            this.CoachName.Name = "CoachName";
            // 
            // MaxCountParticipants
            // 
            this.MaxCountParticipants.HeaderText = "Доступно мест";
            this.MaxCountParticipants.Name = "MaxCountParticipants";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSections);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSections)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSections;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoachName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxCountParticipants;
    }
}

