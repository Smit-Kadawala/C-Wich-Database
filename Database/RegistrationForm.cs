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
    
    public partial class RegistrationForm : Form
    {

        private readonly UserDataBaseEntities userDataBaseEntities;

        public RegistrationForm()
        {
            InitializeComponent();
            userDataBaseEntities = new UserDataBaseEntities();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Selec Query

            var city = userDataBaseEntities.CityLists.ToList();

            //var city = userDataBaseEntities.CityLists
            //    .Select(col => new {
            //        ID = col.CityId,
            //        Name = col.CityName + " " + col.CityState
            //    })
            //    .ToList();

            // Column Name
            cbUserCity.DisplayMember = "CityName";
            cbUserCity.ValueMember = "CityId";
            cbUserCity.DataSource = city;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Collect Data Wich Enter By User And Stor In Variable
            int UserID = 0;
            string UserName = tbUserName.Text;
            string UserEmail = tbUserEmail.Text;
            string UserPasswod = tbUserPassword.Text;
            var UserDate = dtpUserDateOfBirth.Value;
            var UserCity = cbUserCity.SelectedItem.ToString();

            var isValid = true;
            var ErrorMessage = "";

            // Exaption handaling with try and catch

            try
            {
                // form validation chack all data is insert or not 
                if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(UserEmail) || string.IsNullOrWhiteSpace(UserPasswod) || string.IsNullOrEmpty(Convert.ToString(UserDate)) || string.IsNullOrEmpty(Convert.ToString(UserCity)) )
                {
                    // if data is messing set isValide false
                    isValid = false;
                    ErrorMessage += "Enter Messing Data.\n";
                }

                if(isValid)
                {

                    var userRecord = new UserInfo();
                    userRecord.UserId = UserID + 1;
                    userRecord.UserName = UserName;
                    userRecord.UserEmail = UserEmail;
                    userRecord.UserPassword = UserPasswod;
                    userRecord.UserDate = UserDate;
                    userRecord.UserCityId = (int)cbUserCity.SelectedValue;


                    // work linke insert query :)
                    userDataBaseEntities.UserInfoes.Add(userRecord);
                    userDataBaseEntities.SaveChanges();

                    //MessageBox.Show($"User Name : {UserName}\n" +
                    //                $"User Email : {UserEmail}\n" +
                    //                $"User Date of Birth : {UserDate}\n" +
                    //                $"User City : {(int)cbUserCity.SelectedValue}\n" +
                    //                $"User Password : {UserPasswod}");

                    MessageBox.Show($"Data Store : {userRecord}");
                }
                else
                {
                    MessageBox.Show($"Problem is : {ErrorMessage}");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Problem is : {ex.Message} ");
            }


        }
    }
}
