using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class LoginForm : Form
    {
        private readonly UserDataBaseEntities _db;

        public LoginForm()
        {
            InitializeComponent();
            _db = new UserDataBaseEntities();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try 
            {
                // SHA Algo
                SHA256 sha = SHA256.Create(); 

                // collect data from user
                var username = tbUserName.Text.Trim();
                var password = tbUserPassword.Text;
                /*
                    // Convert i/p to byte array and compute the hash.
                    byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                    // Create A new Stringbuilder to collect the bytes and create a string
                    StringBuilder stringBuilder = new StringBuilder();

                    // loop through each byte of hashed data and format each one as haxadecimal string
                    for (int i = 0; i < data.Length; i++)
                    {
                        stringBuilder.Append(data[i].ToString("x2"));
                    }
                */
                var hashed_password = Util.HasePassword(password);

                // check data to databse 
                var user = _db.Logins.FirstOrDefault(column => column.Name == username && column.Password == hashed_password 
                            && column.IsActive == true);
                // Not Found
                if (user == null)
                {
                    MessageBox.Show("User Not Found");
                }
                // Found
                else 
                {

                    // pass object of login windows
                    //var role = user.UserRoles.FirstOrDefault();
                    //var roleShortName = role.Role.ShortName;
                    var mainWindows = new MainWindows(this, user);
                    mainWindows.Show();
                    Hide();
                }
            }
            catch (Exception loginex)
            {
                MessageBox.Show($"Login Problem: { loginex }");
            }
        }
    }
}
