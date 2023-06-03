namespace hmok.Tiles
{
    partial class TileService
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labeltitle = new System.Windows.Forms.Label();
            this.labelCostAndTime = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeltitle.Location = new System.Drawing.Point(157, 13);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(166, 20);
            this.labeltitle.TabIndex = 1;
            this.labeltitle.Text = "Наименование услуги";
            // 
            // labelCostAndTime
            // 
            this.labelCostAndTime.AutoSize = true;
            this.labelCostAndTime.Location = new System.Drawing.Point(157, 44);
            this.labelCostAndTime.Name = "labelCostAndTime";
            this.labelCostAndTime.Size = new System.Drawing.Size(134, 15);
            this.labelCostAndTime.TabIndex = 2;
            this.labelCostAndTime.Text = "800 рублей за 25 минут";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDiscount.Location = new System.Drawing.Point(157, 68);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(75, 13);
            this.labelDiscount.TabIndex = 2;
            this.labelDiscount.Text = "* скидка 10%";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(157, 84);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 31);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(297, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TileService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelCostAndTime);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TileService";
            this.Size = new System.Drawing.Size(657, 132);
            this.Load += new System.EventHandler(this.TileService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labeltitle;
        private Label labelCostAndTime;
        private Label labelDiscount;
        private Button btnEdit;
        private Button btnDelete;
    }
}
