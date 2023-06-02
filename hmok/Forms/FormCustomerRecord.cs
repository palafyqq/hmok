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
    public partial class FormCustomerRecord : MaterialForm
    {
        private Command command = new Command();
        private Command Services = new Command();
        private Command Clients = new Command();
        public FormCustomerRecord()
        {
            InitializeComponent();
        }

        private void FormCustomerRecord_Load(object sender, EventArgs e)
        {
            dateRecording.MinDate= DateTime.Today;
            dateRecording.CustomFormat = "dd-MM-yyyy HH:mm";
            LoadClients();
            LoadServices();
        }

        private void LoadClients()
        {
            Clients.LoadData("select Surname,Name,Patronymic from Clients");
            for (int i = 0; i<Clients.MainTable.Rows.Count; i++)
            {
                cbClient.Items.Add(Clients.MainTable.Rows[i][0].ToString()+" "
                    +Clients.MainTable.Rows[i][1].ToString()+" "+Clients.MainTable.Rows[i][1].ToString());
            }
        }
        private void LoadServices()
        {

            Clients.LoadData("select TitleService,Duration from Service");
            for (int i = 0; i<Services.MainTable.Rows.Count; i++)
            {
                cbService.Items.Add(Services.MainTable.Rows[i][0].ToString());
            }
        }

        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDuration.Text=Services.MainTable.Rows[cbService.SelectedIndex][1].ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command.AddParameter("@title", SqlDbType.NVarChar, cbService.Text);
            command.AddParameter("@strtDate",SqlDbType.DateTime, dateRecording.Value.ToString());
            command.AddParameter("@surname", SqlDbType.NVarChar, Clients.MainTable.Rows[cbClient.SelectedIndex][0].ToString());
            command.SendCommand("insert into ServiceClient values (@title,@startDate,@surname");
            MessageBox.Show("Запись создана успешно!","Информация",MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

