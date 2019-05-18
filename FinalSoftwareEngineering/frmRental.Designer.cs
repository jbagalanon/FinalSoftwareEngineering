﻿namespace FinalSoftwareEngineering
{
    partial class frmRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRental));
            this.txtRate = new System.Windows.Forms.TextBox();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.pnldataGRidView = new System.Windows.Forms.Panel();
            this.dgvAddedProducts = new System.Windows.Forms.DataGridView();
            this.lblDGVTtitle = new System.Windows.Forms.Label();
            this.pnlCalculation = new System.Windows.Forms.Panel();
            this.cboDiscount = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblcalculationTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlCustomerRent = new System.Windows.Forms.Panel();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblDeaCustTitle = new System.Windows.Forms.Label();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblProductSearch = new System.Windows.Forms.Label();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.pnldataGRidView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).BeginInit();
            this.pnlCalculation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.pnlCustomerRent.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(588, 22);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(97, 25);
            this.txtRate.TabIndex = 11;
            // 
            // TxtQty
            // 
            this.TxtQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQty.Location = new System.Drawing.Point(738, 21);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(108, 25);
            this.TxtQty.TabIndex = 10;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(240, 24);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(127, 25);
            this.txtProductName.TabIndex = 9;
            // 
            // pnldataGRidView
            // 
            this.pnldataGRidView.Controls.Add(this.dgvAddedProducts);
            this.pnldataGRidView.Controls.Add(this.lblDGVTtitle);
            this.pnldataGRidView.Location = new System.Drawing.Point(13, 249);
            this.pnldataGRidView.Name = "pnldataGRidView";
            this.pnldataGRidView.Size = new System.Drawing.Size(542, 295);
            this.pnldataGRidView.TabIndex = 10;
            // 
            // dgvAddedProducts
            // 
            this.dgvAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedProducts.Location = new System.Drawing.Point(7, 35);
            this.dgvAddedProducts.Name = "dgvAddedProducts";
            this.dgvAddedProducts.Size = new System.Drawing.Size(517, 245);
            this.dgvAddedProducts.TabIndex = 1;
            // 
            // lblDGVTtitle
            // 
            this.lblDGVTtitle.AutoSize = true;
            this.lblDGVTtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGVTtitle.Location = new System.Drawing.Point(7, 4);
            this.lblDGVTtitle.Name = "lblDGVTtitle";
            this.lblDGVTtitle.Size = new System.Drawing.Size(106, 17);
            this.lblDGVTtitle.TabIndex = 0;
            this.lblDGVTtitle.Text = "Added Products";
            // 
            // pnlCalculation
            // 
            this.pnlCalculation.Controls.Add(this.cboDiscount);
            this.pnlCalculation.Controls.Add(this.btnSave);
            this.pnlCalculation.Controls.Add(this.txtBalance);
            this.pnlCalculation.Controls.Add(this.txtPaidAmount);
            this.pnlCalculation.Controls.Add(this.txtGrandTotal);
            this.pnlCalculation.Controls.Add(this.txtSubTotal);
            this.pnlCalculation.Controls.Add(this.lblBalance);
            this.pnlCalculation.Controls.Add(this.lblPaidAmount);
            this.pnlCalculation.Controls.Add(this.lblGrandTotal);
            this.pnlCalculation.Controls.Add(this.lblDiscount);
            this.pnlCalculation.Controls.Add(this.lblSubTotal);
            this.pnlCalculation.Controls.Add(this.lblcalculationTitle);
            this.pnlCalculation.Location = new System.Drawing.Point(561, 249);
            this.pnlCalculation.Name = "pnlCalculation";
            this.pnlCalculation.Size = new System.Drawing.Size(406, 295);
            this.pnlCalculation.TabIndex = 11;
            // 
            // cboDiscount
            // 
            this.cboDiscount.FormattingEnabled = true;
            this.cboDiscount.Location = new System.Drawing.Point(143, 67);
            this.cboDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.cboDiscount.Name = "cboDiscount";
            this.cboDiscount.Size = new System.Drawing.Size(164, 21);
            this.cboDiscount.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(174, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 37);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.DarkRed;
            this.txtBalance.Location = new System.Drawing.Point(143, 185);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(164, 32);
            this.txtBalance.TabIndex = 12;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(143, 140);
            this.txtPaidAmount.Multiline = true;
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(164, 30);
            this.txtPaidAmount.TabIndex = 11;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(143, 110);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(164, 25);
            this.txtGrandTotal.TabIndex = 10;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(143, 31);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(164, 25);
            this.txtSubTotal.TabIndex = 7;
            this.txtSubTotal.Text = "0";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(23, 193);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(52, 17);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "Balance";
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmount.Location = new System.Drawing.Point(23, 148);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(82, 17);
            this.lblPaidAmount.TabIndex = 5;
            this.lblPaidAmount.Text = "Paid Amount";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(26, 112);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(76, 17);
            this.lblGrandTotal.TabIndex = 4;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(26, 69);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(81, 17);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Discount (%)";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(31, 33);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(62, 17);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // lblcalculationTitle
            // 
            this.lblcalculationTitle.AutoSize = true;
            this.lblcalculationTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalculationTitle.Location = new System.Drawing.Point(4, 4);
            this.lblcalculationTitle.Name = "lblcalculationTitle";
            this.lblcalculationTitle.Size = new System.Drawing.Size(124, 17);
            this.lblcalculationTitle.TabIndex = 0;
            this.lblcalculationTitle.Text = "Calculation Details";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(864, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 36);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtInventory
            // 
            this.txtInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(438, 23);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(104, 25);
            this.txtInventory.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.lblTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 33);
            this.panel1.TabIndex = 7;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(937, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(33, 31);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTop.Location = new System.Drawing.Point(403, 4);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(146, 21);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "RENTAL (Wala pa)";
            // 
            // pnlCustomerRent
            // 
            this.pnlCustomerRent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCustomerRent.Controls.Add(this.dtpBillDate);
            this.pnlCustomerRent.Controls.Add(this.txtName);
            this.pnlCustomerRent.Controls.Add(this.txtContact);
            this.pnlCustomerRent.Controls.Add(this.txtAddress);
            this.pnlCustomerRent.Controls.Add(this.txtCustomerType);
            this.pnlCustomerRent.Controls.Add(this.txtSearch);
            this.pnlCustomerRent.Controls.Add(this.lblAddress);
            this.pnlCustomerRent.Controls.Add(this.lblBillDate);
            this.pnlCustomerRent.Controls.Add(this.lblName);
            this.pnlCustomerRent.Controls.Add(this.lblContact);
            this.pnlCustomerRent.Controls.Add(this.lblEmail);
            this.pnlCustomerRent.Controls.Add(this.lblSearch);
            this.pnlCustomerRent.Controls.Add(this.lblDeaCustTitle);
            this.pnlCustomerRent.Location = new System.Drawing.Point(13, 46);
            this.pnlCustomerRent.Name = "pnlCustomerRent";
            this.pnlCustomerRent.Size = new System.Drawing.Size(954, 100);
            this.pnlCustomerRent.TabIndex = 8;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBillDate.Location = new System.Drawing.Point(781, 45);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(108, 25);
            this.dtpBillDate.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(61, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 25);
            this.txtName.TabIndex = 11;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(337, 64);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(188, 25);
            this.txtContact.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(599, 20);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(162, 67);
            this.txtAddress.TabIndex = 9;
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerType.Location = new System.Drawing.Point(337, 25);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(188, 25);
            this.txtCustomerType.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(61, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 25);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(541, 22);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 17);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.Location = new System.Drawing.Point(777, 21);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(55, 17);
            this.lblBillDate.TabIndex = 5;
            this.lblBillDate.Text = "Bill Date";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(230, 62);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(52, 17);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(230, 25);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(95, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Customer Type";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(7, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 17);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // lblDeaCustTitle
            // 
            this.lblDeaCustTitle.AutoSize = true;
            this.lblDeaCustTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeaCustTitle.Location = new System.Drawing.Point(4, 4);
            this.lblDeaCustTitle.Name = "lblDeaCustTitle";
            this.lblDeaCustTitle.Size = new System.Drawing.Size(114, 17);
            this.lblDeaCustTitle.TabIndex = 0;
            this.lblDeaCustTitle.Text = "Customer Details";
            // 
            // pnlProducts
            // 
            this.pnlProducts.Controls.Add(this.btnAdd);
            this.pnlProducts.Controls.Add(this.txtRate);
            this.pnlProducts.Controls.Add(this.TxtQty);
            this.pnlProducts.Controls.Add(this.txtProductName);
            this.pnlProducts.Controls.Add(this.txtInventory);
            this.pnlProducts.Controls.Add(this.txtSearchProduct);
            this.pnlProducts.Controls.Add(this.lblProductName);
            this.pnlProducts.Controls.Add(this.lblInventory);
            this.pnlProducts.Controls.Add(this.lblQuantity);
            this.pnlProducts.Controls.Add(this.lblRate);
            this.pnlProducts.Controls.Add(this.lblProductSearch);
            this.pnlProducts.Controls.Add(this.lblProductTitle);
            this.pnlProducts.Location = new System.Drawing.Point(13, 163);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(954, 66);
            this.pnlProducts.TabIndex = 9;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(57, 26);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(128, 25);
            this.txtSearchProduct.TabIndex = 7;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(193, 26);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(43, 17);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Name";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(374, 25);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(61, 17);
            this.lblInventory.TabIndex = 5;
            this.lblInventory.Text = "Inventory";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(701, 24);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(31, 17);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Qty.";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(548, 24);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(34, 17);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "Rate";
            // 
            // lblProductSearch
            // 
            this.lblProductSearch.AutoSize = true;
            this.lblProductSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSearch.Location = new System.Drawing.Point(7, 29);
            this.lblProductSearch.Name = "lblProductSearch";
            this.lblProductSearch.Size = new System.Drawing.Size(47, 17);
            this.lblProductSearch.TabIndex = 1;
            this.lblProductSearch.Text = "Search";
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTitle.Location = new System.Drawing.Point(4, 0);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(103, 17);
            this.lblProductTitle.TabIndex = 0;
            this.lblProductTitle.Text = "Product Details";
            // 
            // frmRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(972, 550);
            this.Controls.Add(this.pnldataGRidView);
            this.Controls.Add(this.pnlCalculation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCustomerRent);
            this.Controls.Add(this.pnlProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRental";
            this.Load += new System.EventHandler(this.frmRental_Load);
            this.pnldataGRidView.ResumeLayout(false);
            this.pnldataGRidView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).EndInit();
            this.pnlCalculation.ResumeLayout(false);
            this.pnlCalculation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.pnlCustomerRent.ResumeLayout(false);
            this.pnlCustomerRent.PerformLayout();
            this.pnlProducts.ResumeLayout(false);
            this.pnlProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Panel pnldataGRidView;
        private System.Windows.Forms.DataGridView dgvAddedProducts;
        private System.Windows.Forms.Label lblDGVTtitle;
        private System.Windows.Forms.Panel pnlCalculation;
        private System.Windows.Forms.ComboBox cboDiscount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblcalculationTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel pnlCustomerRent;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblDeaCustTitle;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblProductSearch;
        private System.Windows.Forms.Label lblProductTitle;
        protected internal System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}