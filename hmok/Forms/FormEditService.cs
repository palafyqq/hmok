using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hmok.Code;
using MaterialSkin.Controls;

namespace hmok.Forms
{
    public partial class FormEditService : MaterialForm
    {
        private string IdBase = "0";
        public FormEditService()
        {
            InitializeComponent();
        }

       public void LoadData(string idBase,string _title,string _cost,string _duration,string _discription,string _discount,string _mainPicture)
        {
            IdBase= idBase;
            txtTitle.Text= _title;
            txtCost.Text= _cost;
            txtDuration.Text= _duration;
            txtDescription.Text= _discription;
            txtDiscount.Text= _discount;
            txtPicture.Text= _mainPicture;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if((Convert.ToInt32(txtDuration.Text)<=0)&&(Convert.ToInt32(txtDuration.Text)>240))
            {
                MessageBox.Show("Время не может быть отрицательным или более 4х часов!","Внимание",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDouble(txtCost.Text) < 0)
            {
                MessageBox.Show("Стоимость не может быть отрицательной!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Command command= new Command();
                command.AddParameter("@title",SqlDbType.NVarChar,txtTitle.Text);
                command.AddParameter("@mainPicture", SqlDbType.NVarChar, txtPicture.Text);
                command.AddParameter("@duration", SqlDbType.Int, txtDuration.Text);
                command.AddParameter("@cost", SqlDbType.Float, txtCost.Text);
                command.AddParameter("@discount", SqlDbType.Int,txtDiscount.Text);
                command.SendCommand("Update Service set TitleService=@title,MainPicture=@mainPicture,Duration=@duration,Cost=@cost,Discount=@discount where ID_Service="+ IdBase);
                MessageBox.Show("Услуга изменена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
