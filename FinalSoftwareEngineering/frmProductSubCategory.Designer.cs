namespace FinalSoftwareEngineering
{
    partial class frmProductSubCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductSubCategory));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSubCatSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvSubCategories = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSubCatname = new System.Windows.Forms.TextBox();
            this.txtSubCatId = new System.Windows.Forms.TextBox();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(613, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 22);
            this.pictureBox2.TabIndex = 126;
            this.pictureBox2.TabStop = false;
            // 
            // txtSubCatSearch
            // 
            this.txtSubCatSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCatSearch.Location = new System.Drawing.Point(438, 50);
            this.txtSubCatSearch.Name = "txtSubCatSearch";
            this.txtSubCatSearch.Size = new System.Drawing.Size(171, 23);
            this.txtSubCatSearch.TabIndex = 125;
            this.txtSubCatSearch.TextChanged += new System.EventHandler(this.txtSubCatSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(378, 52);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 19);
            this.lblSearch.TabIndex = 124;
            this.lblSearch.Text = "Search";
            // 
            // dgvSubCategories
            // 
            this.dgvSubCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategories.Location = new System.Drawing.Point(398, 79);
            this.dgvSubCategories.Name = "dgvSubCategories";
            this.dgvSubCategories.Size = new System.Drawing.Size(248, 145);
            this.dgvSubCategories.TabIndex = 123;
            this.dgvSubCategories.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSubCategories_CellMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(684, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtSubCatname
            // 
            this.txtSubCatname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCatname.Location = new System.Drawing.Point(32, 102);
            this.txtSubCatname.Name = "txtSubCatname";
            this.txtSubCatname.Size = new System.Drawing.Size(154, 23);
            this.txtSubCatname.TabIndex = 119;
            // 
            // txtSubCatId
            // 
            this.txtSubCatId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCatId.Location = new System.Drawing.Point(52, 44);
            this.txtSubCatId.Name = "txtSubCatId";
            this.txtSubCatId.ReadOnly = true;
            this.txtSubCatId.Size = new System.Drawing.Size(112, 25);
            this.txtSubCatId.TabIndex = 118;
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategory.Location = new System.Drawing.Point(35, 80);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(150, 19);
            this.lblSubCategory.TabIndex = 117;
            this.lblSubCategory.Text = "Sub Category Name";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryID.Location = new System.Drawing.Point(46, 22);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(119, 19);
            this.lblCategoryID.TabIndex = 116;
            this.lblCategoryID.Text = "SUB Category ID";
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTop.Location = new System.Drawing.Point(268, 6);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(195, 21);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "PRODUCT SUB CATEGORY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 32);
            this.panel1.TabIndex = 115;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(261, 237);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(17, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 143;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(166, 239);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(11, 17);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 142;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(72, 240);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 141;
            this.pictureBox3.TabStop = false;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.Black;
            this.btnADD.Location = new System.Drawing.Point(63, 234);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(89, 28);
            this.btnADD.TabIndex = 132;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(259, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 28);
            this.btnDelete.TabIndex = 134;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(162, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 28);
            this.btnUpdate.TabIndex = 133;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSubCatname);
            this.groupBox1.Controls.Add(this.lblCategoryID);
            this.groupBox1.Controls.Add(this.lblSubCategory);
            this.groupBox1.Controls.Add(this.txtSubCatId);
            this.groupBox1.Location = new System.Drawing.Point(63, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 145);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sub Category";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Location = new System.Drawing.Point(-62, 302);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 28);
            this.panel3.TabIndex = 147;
            // 
            // frmProductSubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(716, 330);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtSubCatSearch);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvSubCategories);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProductSubCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductSubCategory";
            this.Load += new System.EventHandler(this.frmProductSubCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSubCatSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvSubCategories;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSubCatname;
        private System.Windows.Forms.TextBox txtSubCatId;
        private System.Windows.Forms.Label lblSubCategory;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
    }
}