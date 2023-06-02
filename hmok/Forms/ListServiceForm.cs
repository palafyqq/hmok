using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using hmok.Code;
using hmok.Tiles;

namespace hmok.Forms
{
    public partial class ListServiceForm : MaterialForm
    {
        public ListServiceForm()
        {
            InitializeComponent();
        }
        private void ListServiceForm_Load(object sender, EventArgs e)
        {
            if (GlobalVar.AdministrationMode)
            {
                btnAddService.Visible= true;
                btnRecord.Visible= true;
                btnNearest.Visible= true;
            }
            else
            {
                btnAddService.Visible= false;
                btnRecord.Visible= false;
                btnNearest.Visible= false;
            }
            LoadData();
        }
        public void LoadData()
        {
            GlobalVar.Tiles.Clear();
            flowLayoutPanel1.Controls.Clear();
            GlobalVar.listService.LoadData("select * from service");
            for ( int i=0;i<GlobalVar.listService.MainTable.Rows.Count;i++)
            {

                TileService tile = new TileService();
                tile.IDBase = Convert.ToInt32(GlobalVar.listService.MainTable.Rows[i][0]);
                tile.Title = GlobalVar.listService.MainTable.Rows[i][1].ToString();
                tile.IDMassiv = i;
                tile.PathPicture = GlobalVar.listService.MainTable.Rows[i][2].ToString();
                tile.Cost = Convert.ToDouble(GlobalVar.listService.MainTable.Rows[i][4]);
                tile.Discount = Convert.ToDouble(GlobalVar.listService.MainTable.Rows[i][5].ToString);
                tile.Time = Convert.ToInt32(GlobalVar.listService.MainTable.Rows[i][3].ToString);

                tile.LoadData(flowLayoutPanel1);
                flowLayoutPanel1.Controls.Add(tile);
                GlobalVar.Tiles.Add(tile);
            }
            UpdateCountNotes();
        }

        void UpdateCountNotes()
        {
            labelCount.Text = flowLayoutPanel1.Controls.Count + " из " + GlobalVar.listService.MainTable.Rows.Count;
        }
    }
}
