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
    public partial class MainWindows : Form
    {
        private LoginForm _loginForm;
        public string _RoleShortName;
        public Login _login;
        public MainWindows()
        {
            InitializeComponent();
        }

        public MainWindows(LoginForm loginF, Login login)
        {
            InitializeComponent();
            _loginForm = loginF;
            _login = login;
            _RoleShortName = login.UserRoles.FirstOrDefault().Role.ShortName; 
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //var userRegForm = new RegistrationForm();
            //userRegForm.MdiParent = this;
            //userRegForm.Show();
            //var OpanForm = Application.OpenForms.Cast<Form>();
            //var isOpan = OpanForm.Any(form => form.Name == "RegistrationForm");

            // Util is one of the cs class file wich cantine above codel to chack file is open or not
            if (!Util.FormIsOpen("RegistrationForm"))
            {
                var cityData = new RegistrationForm();
                cityData.MdiParent = this;
                cityData.Show();
            }

        }

        private void manageDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chack Opan FOrm 
            //var opanForm = Application.OpenForms.Cast<Form>();
            //var isOpan = opanForm.Any(form => form.Name == "wfCityData");
            if (!Util.FormIsOpen("wfCityData"))
            {
                var cityData = new wfCityData();
                cityData.MdiParent = this;
                cityData.Show();
            }

        }


        // close form and close login form to wich is hide
        private void MainWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Close();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   var OpanForm = Application.OpenForms.Cast<Form>();
         //   var isOpan = OpanForm.Any(form => form.Name == "ViewUser");
            if (!Util.FormIsOpen("ViewUser"))
            {
                var cityData = new ViewUser();
                cityData.MdiParent = this;
                cityData.Show();
            }
        }
        // chack role when form lode
        private void MainWindows_Load(object sender, EventArgs e)
        {

            if(_login.Password == Util.DefultHasePassword())
            {
                var resetPassword = new ResetPassword(_login);
                resetPassword.ShowDialog();
            }

            var username = _login.Name;
            slRoleTest.Text = $"Logged in as : { username } and Role is { _RoleShortName }";
            // if ist not admin it will hide the menu
            if(_RoleShortName != "Admin")
            {
                manageUserToolStripMenuItem.Visible = false;
            }
        }
    }
}
