namespace hmok.Forms
{
    partial class FormEditService
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
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.txtTitle = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCost = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDuration = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDescription = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDiscount = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPicture = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(15, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Название";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(15, 149);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Стоимость";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(15, 222);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(108, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Длительность";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(15, 295);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(73, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Описание";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(15, 368);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(57, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Скидка";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(15, 441);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(102, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Изображение";
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(7, 523);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(297, 36);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(7, 571);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(297, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Отмена";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.AnimateReadOnly = false;
            this.txtTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTitle.Depth = 0;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTitle.HideSelection = true;
            this.txtTitle.LeadingIcon = null;
            this.txtTitle.Location = new System.Drawing.Point(15, 98);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PrefixSuffixText = null;
            this.txtTitle.ReadOnly = false;
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(289, 48);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TabStop = false;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTitle.TrailingIcon = null;
            this.txtTitle.UseSystemPasswordChar = false;
            // 
            // txtCost
            // 
            this.txtCost.AnimateReadOnly = false;
            this.txtCost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCost.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCost.Depth = 0;
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCost.HideSelection = true;
            this.txtCost.LeadingIcon = null;
            this.txtCost.Location = new System.Drawing.Point(15, 171);
            this.txtCost.MaxLength = 32767;
            this.txtCost.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCost.Name = "txtCost";
            this.txtCost.PasswordChar = '\0';
            this.txtCost.PrefixSuffixText = null;
            this.txtCost.ReadOnly = false;
            this.txtCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCost.SelectedText = "";
            this.txtCost.SelectionLength = 0;
            this.txtCost.SelectionStart = 0;
            this.txtCost.ShortcutsEnabled = true;
            this.txtCost.Size = new System.Drawing.Size(289, 48);
            this.txtCost.TabIndex = 2;
            this.txtCost.TabStop = false;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCost.TrailingIcon = null;
            this.txtCost.UseSystemPasswordChar = false;
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
            this.txtDuration.Location = new System.Drawing.Point(15, 244);
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
            this.txtDuration.Size = new System.Drawing.Size(289, 48);
            this.txtDuration.TabIndex = 2;
            this.txtDuration.TabStop = false;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDuration.TrailingIcon = null;
            this.txtDuration.UseSystemPasswordChar = false;
            // 
            // txtDescription
            // 
            this.txtDescription.AnimateReadOnly = false;
            this.txtDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescription.Depth = 0;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescription.HideSelection = true;
            this.txtDescription.LeadingIcon = null;
            this.txtDescription.Location = new System.Drawing.Point(15, 317);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PrefixSuffixText = null;
            this.txtDescription.ReadOnly = false;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(289, 48);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TabStop = false;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.TrailingIcon = null;
            this.txtDescription.UseSystemPasswordChar = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.AnimateReadOnly = false;
            this.txtDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDiscount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDiscount.Depth = 0;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiscount.HideSelection = true;
            this.txtDiscount.LeadingIcon = null;
            this.txtDiscount.Location = new System.Drawing.Point(15, 390);
            this.txtDiscount.MaxLength = 32767;
            this.txtDiscount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PrefixSuffixText = null;
            this.txtDiscount.ReadOnly = false;
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionLength = 0;
            this.txtDiscount.SelectionStart = 0;
            this.txtDiscount.ShortcutsEnabled = true;
            this.txtDiscount.Size = new System.Drawing.Size(289, 48);
            this.txtDiscount.TabIndex = 2;
            this.txtDiscount.TabStop = false;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscount.TrailingIcon = null;
            this.txtDiscount.UseSystemPasswordChar = false;
            // 
            // txtPicture
            // 
            this.txtPicture.AnimateReadOnly = false;
            this.txtPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPicture.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPicture.Depth = 0;
            this.txtPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPicture.HideSelection = true;
            this.txtPicture.LeadingIcon = null;
            this.txtPicture.Location = new System.Drawing.Point(15, 463);
            this.txtPicture.MaxLength = 32767;
            this.txtPicture.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.PasswordChar = '\0';
            this.txtPicture.PrefixSuffixText = null;
            this.txtPicture.ReadOnly = false;
            this.txtPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPicture.SelectedText = "";
            this.txtPicture.SelectionLength = 0;
            this.txtPicture.SelectionStart = 0;
            this.txtPicture.ShortcutsEnabled = true;
            this.txtPicture.Size = new System.Drawing.Size(289, 48);
            this.txtPicture.TabIndex = 2;
            this.txtPicture.TabStop = false;
            this.txtPicture.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPicture.TrailingIcon = null;
            this.txtPicture.UseSystemPasswordChar = false;
            // 
            // FormEditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 616);
            this.Controls.Add(this.txtPicture);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FormEditService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialTextBox2 txtTitle;
        private MaterialSkin.Controls.MaterialTextBox2 txtCost;
        private MaterialSkin.Controls.MaterialTextBox2 txtDuration;
        private MaterialSkin.Controls.MaterialTextBox2 txtDescription;
        private MaterialSkin.Controls.MaterialTextBox2 txtDiscount;
        private MaterialSkin.Controls.MaterialTextBox2 txtPicture;
    }
}