using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MaterialSkin.Controls;
using System.Threading.Tasks;
using System.Windows.Forms;
using hmok.Code;

namespace hmok.Forms
{
    public partial class SearchForm : MaterialForm
    {
        public FlowLayoutPanel layoutPanel;
        private int DiscountMin, DiscountMax;
        public SearchForm()
        {
            InitializeComponent();
            ComboBox1.SelectedIndex = 0;
        }

        private void materialTextBox21_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            if (layoutPanel == null) return;

            GetDiscount();
            layoutPanel.Controls.Clear();

            for (int i = 0; i < GlobalVar.listService.MainTable.Rows.Count; i++)
            {
                if ((GlobalVar.Tiles[i].Title.IndexOf(TextBox1.Text) != -1) && (GlobalVar.Tiles[i].Discount >= DiscountMin && GlobalVar.Tiles[i].Discount <= DiscountMax))
                {
                    layoutPanel.Controls.Add(GlobalVar.Tiles[i]);
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetDiscount()
        {
            switch (ComboBox1.SelectedIndex)
            {
                 case 0:
                  DiscountMin = 0;
                    DiscountMax = 100;
                    break;
                 case 1:
                    DiscountMin = 0;
                    DiscountMax= 5;
                    break;
                 case 2:
                    DiscountMin = 5;
                    DiscountMax= 15;
                    break;
                 case 3:
                    DiscountMin = 15;
                    DiscountMax= 30;
                    break;
                 case 4:
                    DiscountMin = 30;
                    DiscountMax= 70;
                    break;
                 case 5:
                    DiscountMin = 70;
                    DiscountMax= 100;
                    break;
                 
            }
        }
    }
}
