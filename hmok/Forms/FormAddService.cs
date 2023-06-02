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
using System.Drawing.Text;
using hmok.Code;
using Microsoft.VisualBasic;

namespace hmok.Forms
{
    public partial class FormAddService : MaterialForm
    {
        public FormAddService()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Command command1 = new Command();

            command1.AddParameter("@title", SqlDbType.NVarChar, txtTitle.Text);
            command1.AddParameter("@mainPicure", SqlDbType.NVarChar, txtPicture.Text);
            command1.AddParameter("@duration", SqlDbType.NVarChar, txtDuration.Text);
            command1.AddParameter("@cost", SqlDbType.NVarChar, txtCost.Text);
            command1.AddParameter("@discount", SqlDbType.Float, Convert.ToString(Convert.ToDouble(txtDiscount.Text) * 0.01));

            command1.SendCommand("INSERT INTO Service values (@title, @mainPicture, @duration, @cost, @discount);");
            MessageBox.Show("Услуга добавлена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
