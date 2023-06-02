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
            dateRecording.MinDate= DateTime.Now;
            dateRecording.CustomFormat = "dd-MM-yyyy HH:mm";
            LoadClients();
            LoadServices();
        }

        private void LoadClients()
        {

        }
        private void LoadServices()
        {

        }
    }
}
