namespace hmok.Forms
{
    partial class FormCustomerRecord
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dateRecording = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.cbClient = new MaterialSkin.Controls.MaterialComboBox();
            this.cbService = new MaterialSkin.Controls.MaterialComboBox();
            this.txtBoxDuration = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(22, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Клиент";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(22, 149);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(52, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Услуга";
            // 
            // dateRecording
            // 
            this.dateRecording.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateRecording.Location = new System.Drawing.Point(22, 245);
            this.dateRecording.Name = "dateRecording";
            this.dateRecording.Size = new System.Drawing.Size(250, 35);
            this.dateRecording.TabIndex = 2;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(22, 223);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(95, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Дата записи";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(22, 283);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(161, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Длительность услуги";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(62, 365);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 11;
            this.materialButton1.Text = "Создать запись";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // cbClient
            // 
            this.cbClient.AutoResize = false;
            this.cbClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbClient.Depth = 0;
            this.cbClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbClient.DropDownHeight = 174;
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.DropDownWidth = 121;
            this.cbClient.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbClient.FormattingEnabled = true;
            this.cbClient.IntegralHeight = false;
            this.cbClient.ItemHeight = 43;
            this.cbClient.Location = new System.Drawing.Point(22, 97);
            this.cbClient.MaxDropDownItems = 4;
            this.cbClient.MouseState = MaterialSkin.MouseState.OUT;
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(250, 49);
            this.cbClient.StartIndex = 0;
            this.cbClient.TabIndex = 12;
            // 
            // cbService
            // 
            this.cbService.AutoResize = false;
            this.cbService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbService.Depth = 0;
            this.cbService.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbService.DropDownHeight = 174;
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.DropDownWidth = 121;
            this.cbService.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbService.FormattingEnabled = true;
            this.cbService.IntegralHeight = false;
            this.cbService.ItemHeight = 43;
            this.cbService.Location = new System.Drawing.Point(22, 171);
            this.cbService.MaxDropDownItems = 4;
            this.cbService.MouseState = MaterialSkin.MouseState.OUT;
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(250, 49);
            this.cbService.StartIndex = 0;
            this.cbService.TabIndex = 13;
            // 
            // txtBoxDuration
            // 
            this.txtBoxDuration.AnimateReadOnly = false;
            this.txtBoxDuration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxDuration.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxDuration.Depth = 0;
            this.txtBoxDuration.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxDuration.HideSelection = true;
            this.txtBoxDuration.LeadingIcon = null;
            this.txtBoxDuration.Location = new System.Drawing.Point(22, 305);
            this.txtBoxDuration.MaxLength = 32767;
            this.txtBoxDuration.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxDuration.Name = "txtBoxDuration";
            this.txtBoxDuration.PasswordChar = '\0';
            this.txtBoxDuration.PrefixSuffixText = null;
            this.txtBoxDuration.ReadOnly = false;
            this.txtBoxDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxDuration.SelectedText = "";
            this.txtBoxDuration.SelectionLength = 0;
            this.txtBoxDuration.SelectionStart = 0;
            this.txtBoxDuration.ShortcutsEnabled = true;
            this.txtBoxDuration.Size = new System.Drawing.Size(250, 48);
            this.txtBoxDuration.TabIndex = 14;
            this.txtBoxDuration.TabStop = false;
            this.txtBoxDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxDuration.TrailingIcon = null;
            this.txtBoxDuration.UseSystemPasswordChar = false;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(62, 413);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(158, 36);
            this.materialButton2.TabIndex = 11;
            this.materialButton2.Text = "Выйти";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // FormCustomerRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 464);
            this.Controls.Add(this.txtBoxDuration);
            this.Controls.Add(this.cbService);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.dateRecording);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FormCustomerRecord";
            this.Text = "FormCustomerRecord";
            this.Load += new System.EventHandler(this.FormCustomerRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private DateTimePicker dateRecording;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialComboBox cbClient;
        private MaterialSkin.Controls.MaterialComboBox cbService;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxDuration;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}