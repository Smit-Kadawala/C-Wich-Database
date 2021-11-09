
namespace Database
{
    partial class wfCityData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfCityData));
            this.dgvCitiList = new System.Windows.Forms.DataGridView();
            this.lbCityData = new System.Windows.Forms.Label();
            this.btnInsertCityData = new System.Windows.Forms.Button();
            this.btnEditCityData = new System.Windows.Forms.Button();
            this.btnDeletCityData = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitiList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCitiList
            // 
            this.dgvCitiList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitiList.Location = new System.Drawing.Point(12, 69);
            this.dgvCitiList.Name = "dgvCitiList";
            this.dgvCitiList.Size = new System.Drawing.Size(546, 369);
            this.dgvCitiList.TabIndex = 0;
            // 
            // lbCityData
            // 
            this.lbCityData.AutoSize = true;
            this.lbCityData.BackColor = System.Drawing.Color.Transparent;
            this.lbCityData.Font = new System.Drawing.Font("MV Boli", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCityData.Location = new System.Drawing.Point(299, 9);
            this.lbCityData.Name = "lbCityData";
            this.lbCityData.Size = new System.Drawing.Size(186, 49);
            this.lbCityData.TabIndex = 1;
            this.lbCityData.Text = "City List";
            // 
            // btnInsertCityData
            // 
            this.btnInsertCityData.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCityData.Location = new System.Drawing.Point(609, 171);
            this.btnInsertCityData.Name = "btnInsertCityData";
            this.btnInsertCityData.Size = new System.Drawing.Size(179, 49);
            this.btnInsertCityData.TabIndex = 2;
            this.btnInsertCityData.Text = "Insert Data";
            this.btnInsertCityData.UseVisualStyleBackColor = true;
            this.btnInsertCityData.Click += new System.EventHandler(this.btnInsertCityData_Click);
            // 
            // btnEditCityData
            // 
            this.btnEditCityData.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEditCityData.Location = new System.Drawing.Point(609, 281);
            this.btnEditCityData.Name = "btnEditCityData";
            this.btnEditCityData.Size = new System.Drawing.Size(179, 44);
            this.btnEditCityData.TabIndex = 3;
            this.btnEditCityData.Text = "Edit Data";
            this.btnEditCityData.UseVisualStyleBackColor = true;
            this.btnEditCityData.Click += new System.EventHandler(this.btnEditCityData_Click);
            // 
            // btnDeletCityData
            // 
            this.btnDeletCityData.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDeletCityData.Location = new System.Drawing.Point(609, 391);
            this.btnDeletCityData.Name = "btnDeletCityData";
            this.btnDeletCityData.Size = new System.Drawing.Size(179, 47);
            this.btnDeletCityData.TabIndex = 4;
            this.btnDeletCityData.Text = "Delet Data";
            this.btnDeletCityData.UseVisualStyleBackColor = true;
            this.btnDeletCityData.Click += new System.EventHandler(this.btnDeletCityData_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRefresh.Location = new System.Drawing.Point(609, 69);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(179, 44);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // wfCityData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeletCityData);
            this.Controls.Add(this.btnEditCityData);
            this.Controls.Add(this.btnInsertCityData);
            this.Controls.Add(this.lbCityData);
            this.Controls.Add(this.dgvCitiList);
            this.Name = "wfCityData";
            this.Text = "Manage City Data";
            this.Load += new System.EventHandler(this.wfCityData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitiList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCitiList;
        private System.Windows.Forms.Label lbCityData;
        private System.Windows.Forms.Button btnInsertCityData;
        private System.Windows.Forms.Button btnEditCityData;
        private System.Windows.Forms.Button btnDeletCityData;
        private System.Windows.Forms.Button btnRefresh;
    }
}