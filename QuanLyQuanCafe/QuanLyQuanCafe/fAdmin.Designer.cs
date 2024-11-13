namespace QuanLyQuanCafe
{
    partial class fAdmin
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
            tcAdmin = new TabControl();
            tpBill = new TabPage();
            panel2 = new Panel();
            btnViewBill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            panel1 = new Panel();
            dtgvBill = new DataGridView();
            tpFood = new TabPage();
            panel6 = new Panel();
            txbSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel5 = new Panel();
            btnShowFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            panel4 = new Panel();
            panel10 = new Panel();
            numFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbxFoodCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            label2 = new Label();
            txbFoodName = new TextBox();
            panel7 = new Panel();
            label1 = new Label();
            txbFoodID = new TextBox();
            panel3 = new Panel();
            dtgvFood = new DataGridView();
            tpFoodCategory = new TabPage();
            panel13 = new Panel();
            panel16 = new Panel();
            label7 = new Label();
            txbCategoryName = new TextBox();
            panel17 = new Panel();
            label8 = new Label();
            txbCategory = new TextBox();
            panel12 = new Panel();
            dtgvCategory = new DataGridView();
            panel11 = new Panel();
            btnShowCategory = new Button();
            btnEditCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            tpTable = new TabPage();
            panel18 = new Panel();
            panel21 = new Panel();
            cbTableStatus = new ComboBox();
            label9 = new Label();
            panel19 = new Panel();
            label5 = new Label();
            txbTableName = new TextBox();
            panel20 = new Panel();
            label6 = new Label();
            txbTableID = new TextBox();
            panel15 = new Panel();
            dtgvTable = new DataGridView();
            panel14 = new Panel();
            btnShowTable = new Button();
            btnEditTable = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            tpAccount = new TabPage();
            panel24 = new Panel();
            btnResetPassword = new Button();
            panel26 = new Panel();
            cbAccountType = new ComboBox();
            label11 = new Label();
            panel27 = new Panel();
            label12 = new Label();
            txbDisplayName = new TextBox();
            panel28 = new Panel();
            label13 = new Label();
            txbUserName = new TextBox();
            panel23 = new Panel();
            dtgvAccount = new DataGridView();
            panel22 = new Panel();
            btnShowAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            tcAdmin.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            tpFoodCategory.SuspendLayout();
            panel13.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            panel11.SuspendLayout();
            tpTable.SuspendLayout();
            panel18.SuspendLayout();
            panel21.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            panel14.SuspendLayout();
            tpAccount.SuspendLayout();
            panel24.SuspendLayout();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            panel28.SuspendLayout();
            panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel22.SuspendLayout();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tpFoodCategory);
            tcAdmin.Controls.Add(tpTable);
            tcAdmin.Controls.Add(tpAccount);
            tcAdmin.Location = new Point(12, 12);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(803, 510);
            tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 29);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(795, 477);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh Thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnViewBill);
            panel2.Controls.Add(dtpkToDate);
            panel2.Controls.Add(dtpkFromDate);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 39);
            panel2.TabIndex = 1;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(337, 3);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(110, 32);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Thống kê";
            btnViewBill.UseVisualStyleBackColor = true;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(517, 3);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(263, 27);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(0, 3);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(263, 27);
            dtpkFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvBill);
            panel1.Location = new Point(6, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 420);
            panel1.TabIndex = 0;
            // 
            // dtgvBill
            // 
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(3, 3);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.Size = new Size(777, 414);
            dtgvBill.TabIndex = 0;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 29);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(795, 477);
            tpFood.TabIndex = 1;
            tpFood.Text = "Thức ăn";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(txbSearchFoodName);
            panel6.Controls.Add(btnSearchFood);
            panel6.Location = new Point(462, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(327, 58);
            panel6.TabIndex = 3;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Location = new Point(3, 13);
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(221, 27);
            txbSearchFoodName.TabIndex = 5;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(230, 3);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(94, 52);
            btnSearchFood.TabIndex = 4;
            btnSearchFood.Text = "Tìm kiếm";
            btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnShowFood);
            panel5.Controls.Add(btnEditFood);
            panel5.Controls.Add(btnDeleteFood);
            panel5.Controls.Add(btnAddFood);
            panel5.Location = new Point(6, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(450, 58);
            panel5.TabIndex = 2;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(353, 3);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(94, 52);
            btnShowFood.TabIndex = 3;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = true;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(235, 0);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(94, 52);
            btnEditFood.TabIndex = 2;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(116, 0);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(94, 52);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(3, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(94, 52);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Location = new Point(462, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(327, 401);
            panel4.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.Controls.Add(numFoodPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(3, 219);
            panel10.Name = "panel10";
            panel10.Size = new Size(321, 66);
            panel10.TabIndex = 6;
            // 
            // numFoodPrice
            // 
            numFoodPrice.Location = new Point(88, 16);
            numFoodPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numFoodPrice.Name = "numFoodPrice";
            numFoodPrice.Size = new Size(223, 27);
            numFoodPrice.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 3;
            label4.Text = "Giá:";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbxFoodCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 147);
            panel9.Name = "panel9";
            panel9.Size = new Size(321, 66);
            panel9.TabIndex = 4;
            // 
            // cbxFoodCategory
            // 
            cbxFoodCategory.FormattingEnabled = true;
            cbxFoodCategory.Location = new Point(88, 15);
            cbxFoodCategory.Name = "cbxFoodCategory";
            cbxFoodCategory.Size = new Size(223, 28);
            cbxFoodCategory.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Danh mục:";
            // 
            // panel8
            // 
            panel8.Controls.Add(label2);
            panel8.Controls.Add(txbFoodName);
            panel8.Location = new Point(3, 75);
            panel8.Name = "panel8";
            panel8.Size = new Size(321, 66);
            panel8.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 24);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên món:";
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(88, 17);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(223, 27);
            txbFoodName.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Controls.Add(txbFoodID);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(321, 66);
            panel7.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // txbFoodID
            // 
            txbFoodID.Location = new Point(88, 17);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(223, 27);
            txbFoodID.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvFood);
            panel3.Location = new Point(6, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 401);
            panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 3);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.Size = new Size(444, 395);
            dtgvFood.TabIndex = 0;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.Controls.Add(panel13);
            tpFoodCategory.Controls.Add(panel12);
            tpFoodCategory.Controls.Add(panel11);
            tpFoodCategory.Location = new Point(4, 29);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(3);
            tpFoodCategory.Size = new Size(795, 477);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Danh mục";
            tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel16);
            panel13.Controls.Add(panel17);
            panel13.Location = new Point(462, 67);
            panel13.Name = "panel13";
            panel13.Size = new Size(327, 401);
            panel13.TabIndex = 5;
            // 
            // panel16
            // 
            panel16.Controls.Add(label7);
            panel16.Controls.Add(txbCategoryName);
            panel16.Location = new Point(3, 75);
            panel16.Name = "panel16";
            panel16.Size = new Size(321, 66);
            panel16.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 24);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 3;
            label7.Text = "Tên danh mục:";
            // 
            // txbCategoryName
            // 
            txbCategoryName.Location = new Point(109, 17);
            txbCategoryName.Name = "txbCategoryName";
            txbCategoryName.Size = new Size(202, 27);
            txbCategoryName.TabIndex = 1;
            // 
            // panel17
            // 
            panel17.Controls.Add(label8);
            panel17.Controls.Add(txbCategory);
            panel17.Location = new Point(3, 3);
            panel17.Name = "panel17";
            panel17.Size = new Size(321, 66);
            panel17.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 24);
            label8.Name = "label8";
            label8.Size = new Size(27, 20);
            label8.TabIndex = 2;
            label8.Text = "ID:";
            // 
            // txbCategory
            // 
            txbCategory.Location = new Point(109, 17);
            txbCategory.Name = "txbCategory";
            txbCategory.ReadOnly = true;
            txbCategory.Size = new Size(202, 27);
            txbCategory.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.Controls.Add(dtgvCategory);
            panel12.Location = new Point(6, 67);
            panel12.Name = "panel12";
            panel12.Size = new Size(450, 401);
            panel12.TabIndex = 4;
            // 
            // dtgvCategory
            // 
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(3, 3);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersWidth = 51;
            dtgvCategory.Size = new Size(444, 395);
            dtgvCategory.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnShowCategory);
            panel11.Controls.Add(btnEditCategory);
            panel11.Controls.Add(btnDeleteCategory);
            panel11.Controls.Add(btnAddCategory);
            panel11.Location = new Point(6, 6);
            panel11.Name = "panel11";
            panel11.Size = new Size(450, 58);
            panel11.TabIndex = 3;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Location = new Point(353, 3);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(94, 52);
            btnShowCategory.TabIndex = 3;
            btnShowCategory.Text = "Xem";
            btnShowCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(235, 0);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(94, 52);
            btnEditCategory.TabIndex = 2;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(116, 0);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(94, 52);
            btnDeleteCategory.TabIndex = 1;
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(3, 3);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(94, 52);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel18);
            tpTable.Controls.Add(panel15);
            tpTable.Controls.Add(panel14);
            tpTable.Location = new Point(4, 29);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(795, 477);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn ăn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            panel18.Controls.Add(panel21);
            panel18.Controls.Add(panel19);
            panel18.Controls.Add(panel20);
            panel18.Location = new Point(462, 67);
            panel18.Name = "panel18";
            panel18.Size = new Size(327, 401);
            panel18.TabIndex = 6;
            // 
            // panel21
            // 
            panel21.Controls.Add(cbTableStatus);
            panel21.Controls.Add(label9);
            panel21.Location = new Point(3, 147);
            panel21.Name = "panel21";
            panel21.Size = new Size(321, 66);
            panel21.TabIndex = 4;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(109, 21);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(202, 28);
            cbTableStatus.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 24);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 3;
            label9.Text = "Trạng thái:";
            // 
            // panel19
            // 
            panel19.Controls.Add(label5);
            panel19.Controls.Add(txbTableName);
            panel19.Location = new Point(3, 75);
            panel19.Name = "panel19";
            panel19.Size = new Size(321, 66);
            panel19.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 24);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 3;
            label5.Text = "Tên bàn:";
            // 
            // txbTableName
            // 
            txbTableName.Location = new Point(109, 17);
            txbTableName.Name = "txbTableName";
            txbTableName.Size = new Size(202, 27);
            txbTableName.TabIndex = 1;
            // 
            // panel20
            // 
            panel20.Controls.Add(label6);
            panel20.Controls.Add(txbTableID);
            panel20.Location = new Point(3, 3);
            panel20.Name = "panel20";
            panel20.Size = new Size(321, 66);
            panel20.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 24);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 2;
            label6.Text = "ID:";
            // 
            // txbTableID
            // 
            txbTableID.Location = new Point(109, 17);
            txbTableID.Name = "txbTableID";
            txbTableID.ReadOnly = true;
            txbTableID.Size = new Size(202, 27);
            txbTableID.TabIndex = 1;
            // 
            // panel15
            // 
            panel15.Controls.Add(dtgvTable);
            panel15.Location = new Point(3, 67);
            panel15.Name = "panel15";
            panel15.Size = new Size(450, 401);
            panel15.TabIndex = 5;
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(3, 3);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowHeadersWidth = 51;
            dtgvTable.Size = new Size(444, 395);
            dtgvTable.TabIndex = 0;
            // 
            // panel14
            // 
            panel14.Controls.Add(btnShowTable);
            panel14.Controls.Add(btnEditTable);
            panel14.Controls.Add(btnDeleteTable);
            panel14.Controls.Add(btnAddTable);
            panel14.Location = new Point(6, 6);
            panel14.Name = "panel14";
            panel14.Size = new Size(450, 58);
            panel14.TabIndex = 4;
            // 
            // btnShowTable
            // 
            btnShowTable.Location = new Point(353, 3);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(94, 52);
            btnShowTable.TabIndex = 3;
            btnShowTable.Text = "Xem";
            btnShowTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(235, 0);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(94, 52);
            btnEditTable.TabIndex = 2;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(116, 0);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(94, 52);
            btnDeleteTable.TabIndex = 1;
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(3, 3);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(94, 52);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel24);
            tpAccount.Controls.Add(panel23);
            tpAccount.Controls.Add(panel22);
            tpAccount.Location = new Point(4, 29);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(795, 477);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Tài khoản";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            panel24.Controls.Add(btnResetPassword);
            panel24.Controls.Add(panel26);
            panel24.Controls.Add(panel27);
            panel24.Controls.Add(panel28);
            panel24.Location = new Point(462, 70);
            panel24.Name = "panel24";
            panel24.Size = new Size(327, 401);
            panel24.TabIndex = 5;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(220, 232);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(94, 52);
            btnResetPassword.TabIndex = 5;
            btnResetPassword.Text = "Đặt lại mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // panel26
            // 
            panel26.Controls.Add(cbAccountType);
            panel26.Controls.Add(label11);
            panel26.Location = new Point(3, 147);
            panel26.Name = "panel26";
            panel26.Size = new Size(321, 66);
            panel26.TabIndex = 4;
            // 
            // cbAccountType
            // 
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Location = new Point(112, 15);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(199, 28);
            cbAccountType.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 23);
            label11.Name = "label11";
            label11.Size = new Size(105, 20);
            label11.TabIndex = 3;
            label11.Text = "Loại tài khoản:";
            // 
            // panel27
            // 
            panel27.Controls.Add(label12);
            panel27.Controls.Add(txbDisplayName);
            panel27.Location = new Point(3, 75);
            panel27.Name = "panel27";
            panel27.Size = new Size(321, 66);
            panel27.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 24);
            label12.Name = "label12";
            label12.Size = new Size(88, 20);
            label12.TabIndex = 3;
            label12.Text = "Tên hiển thị:";
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(112, 17);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(199, 27);
            txbDisplayName.TabIndex = 1;
            // 
            // panel28
            // 
            panel28.Controls.Add(label13);
            panel28.Controls.Add(txbUserName);
            panel28.Location = new Point(3, 3);
            panel28.Name = "panel28";
            panel28.Size = new Size(321, 66);
            panel28.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 24);
            label13.Name = "label13";
            label13.Size = new Size(100, 20);
            label13.TabIndex = 2;
            label13.Text = "Tên tài khoản:";
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(112, 17);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(199, 27);
            txbUserName.TabIndex = 1;
            // 
            // panel23
            // 
            panel23.Controls.Add(dtgvAccount);
            panel23.Location = new Point(3, 70);
            panel23.Name = "panel23";
            panel23.Size = new Size(450, 401);
            panel23.TabIndex = 4;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 3);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(444, 395);
            dtgvAccount.TabIndex = 0;
            // 
            // panel22
            // 
            panel22.Controls.Add(btnShowAccount);
            panel22.Controls.Add(btnEditAccount);
            panel22.Controls.Add(btnDeleteAccount);
            panel22.Controls.Add(btnAddAccount);
            panel22.Location = new Point(3, 6);
            panel22.Name = "panel22";
            panel22.Size = new Size(450, 58);
            panel22.TabIndex = 3;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Location = new Point(353, 3);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(94, 52);
            btnShowAccount.TabIndex = 3;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(235, 0);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(94, 52);
            btnEditAccount.TabIndex = 2;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(116, 0);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(94, 52);
            btnDeleteAccount.TabIndex = 1;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(3, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(94, 52);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 534);
            Controls.Add(tcAdmin);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAdmin";
            tcAdmin.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            tpFoodCategory.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            panel11.ResumeLayout(false);
            tpTable.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            panel14.ResumeLayout(false);
            tpAccount.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel28.ResumeLayout(false);
            panel28.PerformLayout();
            panel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel22.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpBill;
        private TabPage tpFood;
        private TabPage tpTable;
        private TabPage tpAccount;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dtgvBill;
        private Button btnViewBill;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private DataGridView dtgvFood;
        private TextBox txbSearchFoodName;
        private Button btnSearchFood;
        private Button btnShowFood;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private Panel panel7;
        private Label label1;
        private TextBox txbFoodID;
        private Panel panel8;
        private TextBox txbFoodName;
        private Label label2;
        private Panel panel9;
        private Label label3;
        private Panel panel10;
        private NumericUpDown numFoodPrice;
        private Label label4;
        private ComboBox cbxFoodCategory;
        private TabPage tpFoodCategory;
        private Panel panel13;
        private Panel panel16;
        private Label label7;
        private TextBox txbCategoryName;
        private Panel panel17;
        private Label label8;
        private TextBox txbCategory;
        private Panel panel12;
        private DataGridView dtgvCategory;
        private Panel panel11;
        private Button btnShowCategory;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private Panel panel18;
        private Panel panel19;
        private Label label5;
        private TextBox txbTableName;
        private Panel panel20;
        private Label label6;
        private TextBox txbTableID;
        private Panel panel15;
        private DataGridView dtgvTable;
        private Panel panel14;
        private Button btnShowTable;
        private Button btnEditTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private Panel panel21;
        private Label label9;
        private ComboBox cbTableStatus;
        private Panel panel24;
        private Panel panel26;
        private ComboBox cbAccountType;
        private Label label11;
        private Panel panel27;
        private Label label12;
        private TextBox txbDisplayName;
        private Panel panel28;
        private Label label13;
        private TextBox txbUserName;
        private Panel panel23;
        private DataGridView dtgvAccount;
        private Panel panel22;
        private Button btnShowAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private Button btnResetPassword;
    }
}