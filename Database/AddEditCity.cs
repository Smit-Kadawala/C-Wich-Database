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
    public partial class AddEditCity : Form
    {
        private bool isEdditMood;
        // form wich use to pass data not this form 
        public wfCityData _wfCityData;
        private readonly UserDataBaseEntities _db;
        public AddEditCity(wfCityData wfCityData = null)
        {
            InitializeComponent();
            lbHeader.Text = "Add City Data";
            isEdditMood = false;
            _wfCityData = wfCityData;

            _db = new UserDataBaseEntities();
        }
        // function overlode Edit

        public AddEditCity(CityList cityToEdit, wfCityData wfCityData = null)
        {
            InitializeComponent();
            lbHeader.Text = "Edit City Data";
            _wfCityData = wfCityData;
            isEdditMood = true;
            _db = new UserDataBaseEntities();
            Editdata(cityToEdit);
        }

        private void Editdata(CityList city)
        {

            // Retrive Data wich user Submit
            try
            {
                lbID.Text = city.CityId.ToString();
                tbCityName.Text = city.CityName;
                tbStateName.Text = city.CityState;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error : { e }");
            }
        }


        //Save Btn
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Edit Data
                if(isEdditMood)
                {
                    var id = int.Parse(lbID.Text);
                    var city = _db.CityLists.FirstOrDefault(column => column.CityId == id);
                    city.CityName = tbCityName.Text;
                    city.CityState = tbStateName.Text;

                    //_db.SaveChanges();

                    //this.Close();
                }
                // Add Data
                else
                {
                    var newCity = new CityList
                    {
                        CityName = tbCityName.Text,
                        CityState = tbStateName.Text
                    };
                    // Insert
                    _db.CityLists.Add(newCity);
                    //_db.SaveChanges();
                    //_wfCityData.refg();
                    //this.Close();

                }
                _db.SaveChanges();
                _wfCityData.refg();
                MessageBox.Show("Operation is Complite");
                this.Close();
            }
            catch (Exception savebtn)
            {
                MessageBox.Show($"Save Data Error : { savebtn }");
            }
        }
        //Cancel Btn
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
