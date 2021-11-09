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
    public partial class ResetPassword : Form
    {
        private readonly UserDataBaseEntities _db;
        private Login _login;
        public ResetPassword(Login login)
        {
            InitializeComponent();
            _db = new UserDataBaseEntities();
            _login = login;
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbResetPass.Text;
                var confirm_password = tbConfirmPass.Text;
                var login = _db.Logins.FirstOrDefault(column => column.id == _login.id);
                if (password != confirm_password)
                {
                    MessageBox.Show("Password Dose not Match");
                }
                else
                {
                    _login.Password = Util.HasePassword(password);
                    _db.SaveChanges();
                    MessageBox.Show("Password Is Reset");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Problem to resetpassword { ex }");
            }

        }
    }
}
