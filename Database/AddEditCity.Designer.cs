
namespace Database
{
    partial class AddEditCity
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
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbcityname = new System.Windows.Forms.Label();
            this.lbStateName = new System.Windows.Forms.Label();
            this.tbCityName = new System.Windows.Forms.TextBox();
            this.tbStateName = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("MV Boli", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(387, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(0, 39);
            this.lbHeader.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("MV Boli", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSave.Location = new System.Drawing.Point(12, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(375, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("MV Boli", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCancel.Location = new System.Drawing.Point(418, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(370, 50);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbcityname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbStateName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbCityName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbStateName, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 130);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 100);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lbcityname
            // 
            this.lbcityname.AutoSize = true;
            this.lbcityname.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcityname.Location = new System.Drawing.Point(3, 0);
            this.lbcityname.Name = "lbcityname";
            this.lbcityname.Size = new System.Drawing.Size(145, 31);
            this.lbcityname.TabIndex = 0;
            this.lbcityname.Text = "City Name";
            // 
            // lbStateName
            // 
            this.lbStateName.AutoSize = true;
            this.lbStateName.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStateName.Location = new System.Drawing.Point(3, 50);
            this.lbStateName.Name = "lbStateName";
            this.lbStateName.Size = new System.Drawing.Size(165, 31);
            this.lbStateName.TabIndex = 1;
            this.lbStateName.Text = "State Name";
            // 
            // tbCityName
            // 
            this.tbCityName.Location = new System.Drawing.Point(396, 3);
            this.tbCityName.Name = "tbCityName";
            this.tbCityName.Size = new System.Drawing.Size(387, 20);
            this.tbCityName.TabIndex = 2;
            // 
            // tbStateName
            // 
            this.tbStateName.Location = new System.Drawing.Point(396, 53);
            this.tbStateName.Name = "tbStateName";
            this.tbStateName.Size = new System.Drawing.Size(387, 20);
            this.tbStateName.TabIndex = 3;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(675, 34);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 13);
            this.lbID.TabIndex = 5;
            this.lbID.Visible = false;
            // 
            // AddEditCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbHeader);
            this.Name = "AddEditCity";
            this.Text = "AddEditCity";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbcityname;
        private System.Windows.Forms.Label lbStateName;
        private System.Windows.Forms.TextBox tbCityName;
        private System.Windows.Forms.TextBox tbStateName;
        private System.Windows.Forms.Label lbID;
    }
}