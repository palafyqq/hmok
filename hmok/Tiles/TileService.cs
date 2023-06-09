﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hmok.Code;
using hmok.Forms;

namespace hmok.Tiles
{
    public partial class TileService : UserControl
    {
        public int IDBase;
        public int IDMassiv;
        public string PathPicture;
        public string Title;
        public double Cost;
        public double Discount;
        public int Time;
        private FlowLayoutPanel FlowLayoutPanel;

        public TileService()
        {
            InitializeComponent();
        }

        private void TileService_Load(object sender, EventArgs e)
        {
            if (GlobalVar.AdministrationMode)
            {
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
        }

        public void LoadData(FlowLayoutPanel _panel)
        {
            labeltitle.Text = Title;
            FlowLayoutPanel = _panel;
            pictureBox1.Image = Image.FromFile(GlobalVar.MainFolderPicture + PathPicture);//
            if (Discount>0)
            {
                labelDiscount.Visible= true;
                labelDiscount.Text="* скидка"+Discount+"%";
                this.BackColor = Color.FromArgb(192, 255, 192);
                Cost = Cost - (Cost * (Discount / 100));
            }
            labelCostAndTime.Text = Cost.ToString() + " рублей за " + Time + " минут";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormEditService edit= new FormEditService();
            edit.LoadData(IDBase.ToString(),Title,Cost.ToString(),Time.ToString(),"",Discount.ToString(),PathPicture);
            edit.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить "+Title+" ?","Внимание",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                Command command = new Command();
                command.SendCommand("delete from Service Where ID_Service=" + IDBase);
                FlowLayoutPanel.Controls.RemoveAt(IDMassiv);
                GlobalVar.Tiles.RemoveAt(IDMassiv);
            }
            
        }
    }
}
