
namespace Database
{
    partial class ViewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUserRefresh = new System.Windows.Forms.Button();
            this.btnDeactivateUser = new System.Windows.Forms.Button();
            this.btnResetUserPassword = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lbUserData = new System.Windows.Forms.Label();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUserRefresh
            // 
            this.btnUserRefresh.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnUserRefresh.Location = new System.Drawing.Point(609, 71);
            this.btnUserRefresh.Name = "btnUserRefresh";
            this.btnUserRefresh.Size = new System.Drawing.Size(229, 44);
            this.btnUserRefresh.TabIndex = 11;
            this.btnUserRefresh.Text = "Refresh";
            this.btnUserRefresh.UseVisualStyleBackColor = true;
            this.btnUserRefresh.Click += new System.EventHandler(this.btnUserRefresh_Click);
            // 
            // btnDeactivateUser
            // 
            this.btnDeactivateUser.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDeactivateUser.Location = new System.Drawing.Point(609, 333);
            this.btnDeactivateUser.Name = "btnDeactivateUser";
            this.btnDeactivateUser.Size = new System.Drawing.Size(229, 107);
            this.btnDeactivateUser.TabIndex = 10;
            this.btnDeactivateUser.Text = "Deactivate  Activate User";
            this.btnDeactivateUser.UseVisualStyleBackColor = true;
            this.btnDeactivateUser.Click += new System.EventHandler(this.btnDeactivateUser_Click);
            // 
            // btnResetUserPassword
            // 
            this.btnResetUserPassword.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnResetUserPassword.Location = new System.Drawing.Point(609, 258);
            this.btnResetUserPassword.Name = "btnResetUserPassword";
            this.btnResetUserPassword.Size = new System.Drawing.Size(229, 44);
            this.btnResetUserPassword.TabIndex = 9;
            this.btnResetUserPassword.Text = "Reset Password";
            this.btnResetUserPassword.UseVisualStyleBackColor = true;
            this.btnResetUserPassword.Click += new System.EventHandler(this.btnResetUserPassword_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(609, 158);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(229, 49);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lbUserData
            // 
            this.lbUserData.AutoSize = true;
            this.lbUserData.BackColor = System.Drawing.Color.Transparent;
            this.lbUserData.Font = new System.Drawing.Font("MV Boli", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserData.Location = new System.Drawing.Point(299, 11);
            this.lbUserData.Name = "lbUserData";
            this.lbUserData.Size = new System.Drawing.Size(190, 49);
            this.lbUserData.TabIndex = 7;
            this.lbUserData.Text = "User List";
            // 
            // dgvUserList
            // 
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Location = new System.Drawing.Point(12, 71);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.Size = new System.Drawing.Size(546, 369);
            this.dgvUserList.TabIndex = 6;
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.btnUserRefresh);
            this.Controls.Add(this.btnDeactivateUser);
            this.Controls.Add(this.btnResetUserPassword);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lbUserData);
            this.Controls.Add(this.dgvUserList);
            this.Name = "ViewUser";
            this.Text = "ManageUser";
            this.Load += new System.EventHandler(this.ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserRefresh;
        private System.Windows.Forms.Button btnDeactivateUser;
        private System.Windows.Forms.Button btnResetUserPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lbUserData;
        private System.Windows.Forms.DataGridView dgvUserList;
    }
}