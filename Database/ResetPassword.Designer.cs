
namespace Database
{
    partial class ResetPassword
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbpassword = new System.Windows.Forms.Label();
            this.lbConfirmpassword = new System.Windows.Forms.Label();
            this.tbResetPass = new System.Windows.Forms.TextBox();
            this.tbConfirmPass = new System.Windows.Forms.TextBox();
            this.lbResetPassword = new System.Windows.Forms.Label();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbpassword, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbConfirmpassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbResetPass, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbConfirmPass, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(493, 100);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbpassword.Location = new System.Drawing.Point(3, 0);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(124, 31);
            this.lbpassword.TabIndex = 0;
            this.lbpassword.Text = "Password";
            // 
            // lbConfirmpassword
            // 
            this.lbConfirmpassword.AutoSize = true;
            this.lbConfirmpassword.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbConfirmpassword.Location = new System.Drawing.Point(3, 50);
            this.lbConfirmpassword.Name = "lbConfirmpassword";
            this.lbConfirmpassword.Size = new System.Drawing.Size(231, 31);
            this.lbConfirmpassword.TabIndex = 1;
            this.lbConfirmpassword.Text = "Confirm Password";
            // 
            // tbResetPass
            // 
            this.tbResetPass.Location = new System.Drawing.Point(249, 3);
            this.tbResetPass.Name = "tbResetPass";
            this.tbResetPass.PasswordChar = '*';
            this.tbResetPass.Size = new System.Drawing.Size(241, 20);
            this.tbResetPass.TabIndex = 2;
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.Location = new System.Drawing.Point(249, 53);
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.PasswordChar = '*';
            this.tbConfirmPass.Size = new System.Drawing.Size(241, 20);
            this.tbConfirmPass.TabIndex = 3;
            // 
            // lbResetPassword
            // 
            this.lbResetPassword.AutoSize = true;
            this.lbResetPassword.Font = new System.Drawing.Font("MV Boli", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResetPassword.Location = new System.Drawing.Point(33, 32);
            this.lbResetPassword.Name = "lbResetPassword";
            this.lbResetPassword.Size = new System.Drawing.Size(306, 49);
            this.lbResetPassword.TabIndex = 6;
            this.lbResetPassword.Text = "Reset Password";
            // 
            // btnResetPass
            // 
            this.btnResetPass.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPass.Location = new System.Drawing.Point(42, 229);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(493, 44);
            this.btnResetPass.TabIndex = 8;
            this.btnResetPass.Text = "Submit";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 305);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbResetPassword);
            this.Controls.Add(this.btnResetPass);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Label lbConfirmpassword;
        private System.Windows.Forms.TextBox tbResetPass;
        private System.Windows.Forms.TextBox tbConfirmPass;
        private System.Windows.Forms.Label lbResetPassword;
        private System.Windows.Forms.Button btnResetPass;
    }
}