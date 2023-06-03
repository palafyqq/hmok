namespace hmok.Tiles
{
    partial class TileRecord
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(8, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(74, 15);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Tag = "";
            this.lbTitle.Text = "Имя услуги:";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(8, 30);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(84, 15);
            this.lbFullName.TabIndex = 0;
            this.lbFullName.Tag = "";
            this.lbFullName.Text = "ФИО клиента:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(8, 45);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(39, 15);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Tag = "";
            this.lbEmail.Text = "email:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(8, 60);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(57, 15);
            this.lbPhone.TabIndex = 0;
            this.lbPhone.Tag = "";
            this.lbPhone.Text = "телефон:";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTimer.Location = new System.Drawing.Point(534, 45);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(153, 17);
            this.lbTimer.TabIndex = 0;
            this.lbTimer.Tag = "";
            this.lbTimer.Text = "Осталось: 2 часа 30 минут";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(8, 75);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(76, 15);
            this.lbDate.TabIndex = 0;
            this.lbDate.Tag = "";
            this.lbDate.Text = "Дата записи:";
            // 
            // TileRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.lbTitle);
            this.Name = "TileRecord";
            this.Size = new System.Drawing.Size(704, 114);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private Label lbFullName;
        private Label lbEmail;
        private Label lbPhone;
        private Label lbTimer;
        private Label lbDate;
    }
}
