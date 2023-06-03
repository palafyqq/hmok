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
using System.Linq;
using System.Drawing;

namespace hmok.Forms
{
    public partial class ListServiceForm : MaterialForm
    {
        private Point mouseOffset;
        private bool isMouseDown=false, SimppleQuery=false;

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
                tile.Discount = Convert.ToDouble(GlobalVar.listService.MainTable.Rows[i][5].ToString());
                tile.Time = Convert.ToInt32(GlobalVar.listService.MainTable.Rows[i][3].ToString());

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

        private void btnRecord_Click(object sender, EventArgs e)
        {
            FormCustomerRecord q = new FormCustomerRecord();  
            q.Show();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            FormAddService addService= new FormAddService();
            addService.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.layoutPanel = flowLayoutPanel1;
            search.Show();
        }

        private void btnNearest_Click(object sender, EventArgs e)
        {
            ShowRecordingForm show=new ShowRecordingForm();
            show.Show();
        }

        private void BtnSortingV_Click(object sender, EventArgs e)
        {
            List<TileService> _currentTiles= new List<TileService>();   
            foreach(TileService _curTIles in flowLayoutPanel1.Controls)
            {
                _currentTiles.Add(_curTIles);
            }
            flowLayoutPanel1.Controls.Clear();

            var SortedTile=from u in _currentTiles orderby u.Cost select u;

            foreach(TileService u in SortedTile)
            {
                flowLayoutPanel1.Controls.Add(u);
            }
            SortedTile = null;
            _currentTiles.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnSortingY_Click(object sender, EventArgs e)
        {
            List<TileService> _currentTiles = new List<TileService>();
            foreach (TileService _curTIles in flowLayoutPanel1.Controls)
            {
                _currentTiles.Add(_curTIles);
            }
            flowLayoutPanel1.Controls.Clear();

            var SortedTile = from u in _currentTiles orderby u.Cost descending select u;

            foreach (TileService u in SortedTile)
            {
                flowLayoutPanel1.Controls.Add(u);
            }
            SortedTile = null;
            _currentTiles.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListServiceForm_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;
            if(e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset= -e.Y - SystemInformation.CaptionHeight-SystemInformation.FrameBorderSize.Height;
                mouseOffset=new Point(xOffset, yOffset);
                isMouseDown=true;

            }
        }

        private void ListServiceForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }

        }

        private void ListServiceForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown=false;
            }
        }
    }
}
