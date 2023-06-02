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
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.cbClient = new MaterialSkin.Controls.MaterialComboBox();
            this.cbService = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDuration = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
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
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(62, 365);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(158, 36);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Создать запись";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.cbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
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
            this.cbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
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
            this.cbService.SelectedIndexChanged += new System.EventHandler(this.cbService_SelectedIndexChanged);
            // 
            // txtDuration
            // 
            this.txtDuration.AnimateReadOnly = false;
            this.txtDuration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDuration.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDuration.Depth = 0;
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDuration.HideSelection = true;
            this.txtDuration.LeadingIcon = null;
            this.txtDuration.Location = new System.Drawing.Point(22, 305);
            this.txtDuration.MaxLength = 32767;
            this.txtDuration.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.PasswordChar = '\0';
            this.txtDuration.PrefixSuffixText = null;
            this.txtDuration.ReadOnly = false;
            this.txtDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDuration.SelectedText = "";
            this.txtDuration.SelectionLength = 0;
            this.txtDuration.SelectionStart = 0;
            this.txtDuration.ShortcutsEnabled = true;
            this.txtDuration.Size = new System.Drawing.Size(250, 48);
            this.txtDuration.TabIndex = 14;
            this.txtDuration.TabStop = false;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDuration.TrailingIcon = null;
            this.txtDuration.UseSystemPasswordChar = false;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(62, 413);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(158, 36);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Выйти";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormCustomerRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 464);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.cbService);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
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
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialComboBox cbClient;
        private MaterialSkin.Controls.MaterialComboBox cbService;
        private MaterialSkin.Controls.MaterialTextBox2 txtDuration;
        private MaterialSkin.Controls.MaterialButton btnClose;
    }
}