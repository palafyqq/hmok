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
using hmok.Tiles;

namespace hmok.Forms
{
    public partial class ShowRecordingForm : MaterialForm
    {
        private Command Service = new Command();
        public ShowRecordingForm()
        {
            InitializeComponent();
        }

        private void ShowRecordingForm_Load(object sender, EventArgs e)
        {
            LoadDate();
        }

        public void LoadDate()
        {
            flowLayoutPanel1.Controls.Clear();

            Service.LoadData("Select recording.TitleService, client.Surname,client.Name,client.Patronymic,client.Email,client.Phone,recording.StartServiceProvision from " +
                "ServiceClient recording, Clients client where client.Surname = recording.SurnameClient order by recording.StartServiceProvision ASC");

            for (int i=0;i<Service.MainTable.Rows.Count;i++)
            {
                TileRecord rec = new TileRecord();
                rec.TitleService = Service.MainTable.Rows[i][0].ToString();
                rec.FulNameClient = Service.MainTable.Rows[i][1].ToString()+" "+ Service.MainTable.Rows[i][2].ToString() + " " + Service.MainTable.Rows[i][3].ToString() + " ";
                rec.Email = Service.MainTable.Rows[i][4].ToString();
                rec.NumberPhone = Service.MainTable.Rows[i][5].ToString();
                rec.StartDate = Convert.ToDateTime(Service.MainTable.Rows[i][6].ToString());
                rec.LoadData();

                flowLayoutPanel1.Controls.Add(rec);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
