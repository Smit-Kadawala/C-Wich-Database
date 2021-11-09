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
    
    public partial class ViewUser : Form
    {
        private readonly UserDataBaseEntities _db;
        public ViewUser()
        {
            InitializeComponent();
            _db = new UserDataBaseEntities();
        } 
        // Add User
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!Util.FormIsOpen("AddUserForm"))
            {
                var addUser = new AddUserForm(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }

        }
        // Reset Password
        private void btnResetUserPassword_Click(object sender, EventArgs e)
        {
            try
            {
                // get id of selected row

                var id = (int)dgvUserList.SelectedRows[0].Cells["id"].Value;

                // query 

                var login = _db.Logins.FirstOrDefault(column => column.id == id);
                // var genericPassword = "Password@123";
                //var hashed_password = Util.HasePassword(genericPassword);
                var hashed_password = Util.DefultHasePassword();
                login.Password = hashed_password;
                _db.SaveChanges();


                MessageBox.Show($"{login.Name}'s Password has been reset");
                RefUserListGride();

            }
            catch (Exception resertpassbtn)
            {
                MessageBox.Show($"Reset Button Error { resertpassbtn }");
            }
        }

        // Deactivate or remove user
        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                // get id of selected row

                var id = (int)dgvUserList.SelectedRows[0].Cells["id"].Value;

                // query 

                var login = _db.Logins.FirstOrDefault(column => column.id == id);


                DialogResult dr = MessageBox.Show("Are You Sure You Want to do This Action ?",
                   "User Action",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Warning);
     
                if (dr == DialogResult.Yes)
                {
                    login.IsActive = login.IsActive == true ? false : true;
                    _db.SaveChanges();
                }


                MessageBox.Show($"{login.Name}'s Active Status Has Changed");
                RefUserListGride();

            }
            catch (Exception resertpassbtn)
            {
                MessageBox.Show($"Reset Button Error { resertpassbtn }");
            }
        }

        // lode user data 
        private void ViewUser_Load(object sender, EventArgs e)
        {
            RefUserListGride();
        }

        public void RefUserListGride()
        {
            var login = _db.Logins
                .Select(column => new
                {
                    column.id,
                    column.Name,
                    column.UserRoles.FirstOrDefault().Role.ShortName,
                    column.IsActive
                }).ToList();
            dgvUserList.DataSource = login;
            dgvUserList.Columns["Name"].HeaderText = "Name";
            dgvUserList.Columns["ShortName"].HeaderText = "Role";
            dgvUserList.Columns["IsActive"].HeaderText = "Active Status";
            dgvUserList.Columns["id"].Visible = false;
        }

        private void btnUserRefresh_Click(object sender, EventArgs e)
        {
            RefUserListGride();
        }
    }
}
