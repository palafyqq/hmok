namespace hmok.Forms
{
    partial class ListServiceForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.BtnSortingV = new MaterialSkin.Controls.MaterialButton();
            this.BtnSortingY = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNearest = new MaterialSkin.Controls.MaterialButton();
            this.btnAddService = new MaterialSkin.Controls.MaterialButton();
            this.btnRecord = new MaterialSkin.Controls.MaterialButton();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.labelCount = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(-1, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 51);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(63, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(45, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Меню";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = false;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(183, 70);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(123, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // BtnSortingV
            // 
            this.BtnSortingV.AutoSize = false;
            this.BtnSortingV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSortingV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnSortingV.Depth = 0;
            this.BtnSortingV.HighEmphasis = true;
            this.BtnSortingV.Icon = null;
            this.BtnSortingV.Location = new System.Drawing.Point(314, 70);
            this.BtnSortingV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSortingV.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSortingV.Name = "BtnSortingV";
            this.BtnSortingV.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSortingV.Size = new System.Drawing.Size(149, 36);
            this.BtnSortingV.TabIndex = 2;
            this.BtnSortingV.Text = "По возрастанию";
            this.BtnSortingV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSortingV.UseAccentColor = false;
            this.BtnSortingV.UseVisualStyleBackColor = true;
            this.BtnSortingV.Click += new System.EventHandler(this.BtnSortingV_Click);
            // 
            // BtnSortingY
            // 
            this.BtnSortingY.AutoSize = false;
            this.BtnSortingY.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSortingY.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnSortingY.Depth = 0;
            this.BtnSortingY.HighEmphasis = true;
            this.BtnSortingY.Icon = null;
            this.BtnSortingY.Location = new System.Drawing.Point(471, 70);
            this.BtnSortingY.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSortingY.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSortingY.Name = "BtnSortingY";
            this.BtnSortingY.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSortingY.Size = new System.Drawing.Size(123, 36);
            this.BtnSortingY.TabIndex = 2;
            this.BtnSortingY.Text = "По убыванию";
            this.BtnSortingY.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSortingY.UseAccentColor = false;
            this.BtnSortingY.UseVisualStyleBackColor = true;
            this.BtnSortingY.Click += new System.EventHandler(this.BtnSortingY_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnNearest);
            this.panel2.Controls.Add(this.btnAddService);
            this.panel2.Controls.Add(this.btnRecord);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(-1, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 342);
            this.panel2.TabIndex = 3;
            // 
            // btnNearest
            // 
            this.btnNearest.AutoSize = false;
            this.btnNearest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNearest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNearest.Depth = 0;
            this.btnNearest.HighEmphasis = true;
            this.btnNearest.Icon = null;
            this.btnNearest.Location = new System.Drawing.Point(7, 169);
            this.btnNearest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNearest.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNearest.Name = "btnNearest";
            this.btnNearest.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNearest.Size = new System.Drawing.Size(167, 36);
            this.btnNearest.TabIndex = 4;
            this.btnNearest.Text = "Ближайшие записи";
            this.btnNearest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNearest.UseAccentColor = false;
            this.btnNearest.UseVisualStyleBackColor = true;
            this.btnNearest.Click += new System.EventHandler(this.btnNearest_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.AutoSize = false;
            this.btnAddService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddService.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddService.Depth = 0;
            this.btnAddService.HighEmphasis = true;
            this.btnAddService.Icon = null;
            this.btnAddService.Location = new System.Drawing.Point(7, 121);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddService.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddService.Size = new System.Drawing.Size(167, 36);
            this.btnAddService.TabIndex = 4;
            this.btnAddService.Text = "Добавить сервис";
            this.btnAddService.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddService.UseAccentColor = false;
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.AutoSize = false;
            this.btnRecord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRecord.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRecord.Depth = 0;
            this.btnRecord.HighEmphasis = true;
            this.btnRecord.Icon = null;
            this.btnRecord.Location = new System.Drawing.Point(7, 73);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRecord.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRecord.Size = new System.Drawing.Size(167, 36);
            this.btnRecord.TabIndex = 4;
            this.btnRecord.Text = "Записать клиента";
            this.btnRecord.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRecord.UseAccentColor = false;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = false;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExit.Depth = 0;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(4, 293);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExit.Size = new System.Drawing.Size(167, 36);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(7, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(167, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Depth = 0;
            this.labelCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCount.Location = new System.Drawing.Point(471, 422);
            this.labelCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(44, 19);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "0 из 0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(186, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(656, 300);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ListServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 455);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnSortingY);
            this.Controls.Add(this.BtnSortingV);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Name = "ListServiceForm";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListServiceForm";
            this.Load += new System.EventHandler(this.ListServiceForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListServiceForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListServiceForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListServiceForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton BtnSortingV;
        private MaterialSkin.Controls.MaterialButton BtnSortingY;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnNearest;
        private MaterialSkin.Controls.MaterialButton btnAddService;
        private MaterialSkin.Controls.MaterialButton btnRecord;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialLabel labelCount;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}