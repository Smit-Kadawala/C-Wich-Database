
namespace Database
{
    partial class RegistrationForm
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
            this.Title = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserEmail = new System.Windows.Forms.Label();
            this.lbUserPassword = new System.Windows.Forms.Label();
            this.lbUserDateOfBurth = new System.Windows.Forms.Label();
            this.lbUserCity = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.tbUserEmail = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.cbUserCity = new System.Windows.Forms.ComboBox();
            this.dtpUserDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(13, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(90, 33);
            this.Title.TabIndex = 0;
            this.Title.Text = "Form";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(13, 62);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(79, 28);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Name";
            // 
            // lbUserEmail
            // 
            this.lbUserEmail.AutoSize = true;
            this.lbUserEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic);
            this.lbUserEmail.Location = new System.Drawing.Point(13, 90);
            this.lbUserEmail.Name = "lbUserEmail";
            this.lbUserEmail.Size = new System.Drawing.Size(77, 28);
            this.lbUserEmail.TabIndex = 2;
            this.lbUserEmail.Text = "Email";
            // 
            // lbUserPassword
            // 
            this.lbUserPassword.AutoSize = true;
            this.lbUserPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic);
            this.lbUserPassword.Location = new System.Drawing.Point(12, 118);
            this.lbUserPassword.Name = "lbUserPassword";
            this.lbUserPassword.Size = new System.Drawing.Size(128, 28);
            this.lbUserPassword.TabIndex = 3;
            this.lbUserPassword.Text = "Password";
            // 
            // lbUserDateOfBurth
            // 
            this.lbUserDateOfBurth.AutoSize = true;
            this.lbUserDateOfBurth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic);
            this.lbUserDateOfBurth.Location = new System.Drawing.Point(14, 146);
            this.lbUserDateOfBurth.Name = "lbUserDateOfBurth";
            this.lbUserDateOfBurth.Size = new System.Drawing.Size(129, 28);
            this.lbUserDateOfBurth.TabIndex = 4;
            this.lbUserDateOfBurth.Text = "Birth Date";
            // 
            // lbUserCity
            // 
            this.lbUserCity.AutoSize = true;
            this.lbUserCity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic);
            this.lbUserCity.Location = new System.Drawing.Point(14, 174);
            this.lbUserCity.Name = "lbUserCity";
            this.lbUserCity.Size = new System.Drawing.Size(58, 28);
            this.lbUserCity.TabIndex = 5;
            this.lbUserCity.Text = "City";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic);
            this.btnSubmit.Location = new System.Drawing.Point(19, 205);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(122, 41);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Location = new System.Drawing.Point(177, 124);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(201, 20);
            this.tbUserPassword.TabIndex = 7;
            // 
            // tbUserEmail
            // 
            this.tbUserEmail.Location = new System.Drawing.Point(177, 98);
            this.tbUserEmail.Name = "tbUserEmail";
            this.tbUserEmail.Size = new System.Drawing.Size(201, 20);
            this.tbUserEmail.TabIndex = 9;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(177, 70);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(201, 20);
            this.tbUserName.TabIndex = 10;
            // 
            // cbUserCity
            // 
            this.cbUserCity.FormattingEnabled = true;
            this.cbUserCity.Location = new System.Drawing.Point(177, 180);
            this.cbUserCity.Name = "cbUserCity";
            this.cbUserCity.Size = new System.Drawing.Size(201, 21);
            this.cbUserCity.TabIndex = 11;
            // 
            // dtpUserDateOfBirth
            // 
            this.dtpUserDateOfBirth.Location = new System.Drawing.Point(177, 153);
            this.dtpUserDateOfBirth.Name = "dtpUserDateOfBirth";
            this.dtpUserDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpUserDateOfBirth.TabIndex = 12;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpUserDateOfBirth);
            this.Controls.Add(this.cbUserCity);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbUserEmail);
            this.Controls.Add(this.tbUserPassword);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbUserCity);
            this.Controls.Add(this.lbUserDateOfBurth);
            this.Controls.Add(this.lbUserPassword);
            this.Controls.Add(this.lbUserEmail);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.Title);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserEmail;
        private System.Windows.Forms.Label lbUserPassword;
        private System.Windows.Forms.Label lbUserDateOfBurth;
        private System.Windows.Forms.Label lbUserCity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.TextBox tbUserEmail;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.ComboBox cbUserCity;
        private System.Windows.Forms.DateTimePicker dtpUserDateOfBirth;
    }
}

