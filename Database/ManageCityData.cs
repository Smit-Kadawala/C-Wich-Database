using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class wfCityData : Form
    {

        private readonly UserDataBaseEntities _db;

        public wfCityData()
        {
            InitializeComponent();
            _db = new UserDataBaseEntities();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refg();
        }


        // Referes Gride 
        public void refg()
        {
            var city = _db.CityLists
                .Select(column => new
                {
                    CityID = column.CityId,
                    CityName = column.CityName,
                    CityState = column.CityState
                })
                .ToList();
            dgvCitiList.DataSource = city;
        }

        private void wfCityData_Load(object sender, EventArgs e)
        {
            // select * from 
            //var city = _db.CityLists.ToList();
            //dgvCitiList.DataSource = city; 

            // select (Column) form table

            var city = _db.CityLists
                .Select(column => new 
                { 
                    CityID = column.CityId, 
                    CityName = column.CityName,
                    CityState = column.CityState
                })
                .ToList();
            // dgvCitiList.Columns[1].HeaderText = "Name";
            dgvCitiList.DataSource = city;
 
        }


        // Insert Data
        private void btnInsertCityData_Click(object sender, EventArgs e)
        {
            try
            {
                // open addedit city form
                var addEditCity = new AddEditCity(this);
                addEditCity.MdiParent = this.MdiParent;
                addEditCity.Show();
                dgvCitiList.Refresh();
            }
            catch (Exception insertbtne)
            {
                MessageBox.Show($"Inser Button Error { insertbtne }");
            }

        }

        //Edit Data
        private void btnEditCityData_Click(object sender, EventArgs e)
        {
            try
            {
                // get id of selected row

                var id = (int)dgvCitiList.SelectedRows[0].Cells["CityId"].Value;

                // query 

                var city = _db.CityLists.FirstOrDefault(column => column.CityId == id);

                //launch addEditCity Form with data
                var addEditCity = new AddEditCity(city, this);
                addEditCity.MdiParent = this.MdiParent;
                addEditCity.Show();
                dgvCitiList.Refresh();

            }
            catch (Exception edittbtne)
            {
                MessageBox.Show($"Inser Button Error { edittbtne }");
            }
        }

        // Delet Data
        private void btnDeletCityData_Click(object sender, EventArgs e)
        {
            try
            {
                // get id of selected row

                var id = (int)dgvCitiList.SelectedRows[0].Cells["CityId"].Value;

                // query 

                var city = _db.CityLists.FirstOrDefault(column => column.CityId == id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want to Delete This Record ?", 
                    "Deleted" , 
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);


                // delet data
                if(dr == DialogResult.Yes)
                {
                    _db.CityLists.Remove(city);
                    _db.SaveChanges();
                }
                refg();

                // dgvCitiList.Refresh();

            }
            catch (Exception deletbtne)
            {
                MessageBox.Show($"Inser Button Error { deletbtne }");
            }
        }

    }
}
