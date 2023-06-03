using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hmok.Tiles
{
    public partial class TileRecord : UserControl
    {
        public string IDBase;
        public int IDMassiv;
        public string TitleService;
        public string FulNameClient;
        public string Email;
        public string NumberPhone;
        public DateTime StartDate;
        public TimeSpan TimeLeft;

        public TileRecord()
        {
            InitializeComponent();
        }

       public void LoadData()
        {
            TimeLeft=StartDate.Subtract(DateTime.Now);
            lbTitle.Text = "Имя услуги: "+ TitleService;
            lbFullName.Text = "ФИО клиента: "+ FulNameClient;
            lbEmail.Text= "Email: "+Email;
            lbPhone.Text = "Телефон: " + NumberPhone;
            lbDate.Text="Дата и время записи: "+ StartDate.ToString();
            lbTimer.Text="Осталось: "+TimeLeft.ToString()+" часа "+ TimeLeft.Minutes.ToString()+" минут " ;

            if (TimeLeft.Hours < 1)
            {
                if (TimeLeft.Minutes < 0)
                {
                    lbTimer.Text = "Время вышло";
                }
                else
                {
                    lbTimer.ForeColor= Color.Red;
                }
            }
        }



     
    }
}
