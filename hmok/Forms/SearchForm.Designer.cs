namespace hmok.Forms
{
    partial class SearchForm
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
            this.TextBox1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.ComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.AnimateReadOnly = false;
            this.TextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBox1.Depth = 0;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBox1.HideSelection = true;
            this.TextBox1.LeadingIcon = null;
            this.TextBox1.Location = new System.Drawing.Point(15, 97);
            this.TextBox1.MaxLength = 32767;
            this.TextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.PrefixSuffixText = null;
            this.TextBox1.ReadOnly = false;
            this.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBox1.SelectedText = "";
            this.TextBox1.SelectionLength = 0;
            this.TextBox1.SelectionStart = 0;
            this.TextBox1.ShortcutsEnabled = true;
            this.TextBox1.Size = new System.Drawing.Size(250, 48);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.TabStop = false;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox1.TrailingIcon = null;
            this.TextBox1.UseSystemPasswordChar = false;
            this.TextBox1.TextChanged += new System.EventHandler(this.materialTextBox21_TextChanged);
            // 
            // ComboBox1
            // 
            this.ComboBox1.AutoResize = false;
            this.ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox1.Depth = 0;
            this.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBox1.DropDownHeight = 174;
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.DropDownWidth = 121;
            this.ComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.IntegralHeight = false;
            this.ComboBox1.ItemHeight = 43;
            this.ComboBox1.Items.AddRange(new object[] {
            "Все",
            "От 0 до 5%",
            "От 5% до 15%",
            "От 15% до 30%",
            "От 30% до 70%",
            "От 70% до 100%"});
            this.ComboBox1.Location = new System.Drawing.Point(15, 179);
            this.ComboBox1.MaxDropDownItems = 4;
            this.ComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(250, 49);
            this.ComboBox1.StartIndex = 0;
            this.ComboBox1.TabIndex = 1;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(15, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Название";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(15, 157);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Скидка";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(15, 263);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(250, 50);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "Закрыть";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 337);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.TextBox1);
            this.Name = "SearchForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 TextBox1;
        private MaterialSkin.Controls.MaterialComboBox ComboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}