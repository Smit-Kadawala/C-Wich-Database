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
    public partial class AddUserForm : Form
    {
        private readonly UserDataBaseEntities _db;
        private ViewUser _viewUser;
        public AddUserForm(ViewUser viewUser)
        {
            InitializeComponent();
            _db = new UserDataBaseEntities();
            _viewUser = viewUser;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var role = _db.Roles.ToList();
            cbUserRole.DataSource = role;
            cbUserRole.ValueMember = "id";
            cbUserRole.DisplayMember = "Name";
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var userName = tbUserName.Text;
                var roleId = (int)cbUserRole.SelectedValue;
                var password = Util.DefultHasePassword();
                var login = new Login
                {
                    Name = userName,
                    Password = password,
                    IsActive = true
                };
                _db.Logins.Add(login);
                _db.SaveChanges();

                var loginId = login.id;

                var userRole = new UserRole
                {
                    userId = loginId,
                    roleId = roleId
                };

                _db.UserRoles.Add(userRole);
                _db.SaveChanges();

                MessageBox.Show("Add User Successfully");
                _viewUser.RefUserListGride();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Add User Error { ex }");
            }
        }
    }
}
