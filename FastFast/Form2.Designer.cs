namespace FastFast
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Num = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_MenuPrice = new System.Windows.Forms.TextBox();
            this.textBox_MenuName = new System.Windows.Forms.TextBox();
            this.comboBox_Select = new System.Windows.Forms.ComboBox();
            this.label_MenuSelect = new System.Windows.Forms.Label();
            this.label_MenuPrice = new System.Windows.Forms.Label();
            this.label_MenuName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Noodle = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Rice = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Cooking = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView_SetMenu = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.service_drink = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView_service = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_Drink = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Noodle)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rice)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cooking)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SetMenu)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.service_drink.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_service)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Drink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Num);
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.button_Modify);
            this.groupBox1.Controls.Add(this.button_Add);
            this.groupBox1.Controls.Add(this.textBox_MenuPrice);
            this.groupBox1.Controls.Add(this.textBox_MenuName);
            this.groupBox1.Controls.Add(this.comboBox_Select);
            this.groupBox1.Controls.Add(this.label_MenuSelect);
            this.groupBox1.Controls.Add(this.label_MenuPrice);
            this.groupBox1.Controls.Add(this.label_MenuName);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "메뉴 추가/수정/삭제";
            // 
            // textBox_Num
            // 
            this.textBox_Num.Location = new System.Drawing.Point(257, 8);
            this.textBox_Num.Name = "textBox_Num";
            this.textBox_Num.Size = new System.Drawing.Size(38, 26);
            this.textBox_Num.TabIndex = 9;
            this.textBox_Num.Visible = false;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(207, 139);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(88, 35);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.Text = "삭제";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(113, 139);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(88, 35);
            this.button_Modify.TabIndex = 7;
            this.button_Modify.Text = "수정";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(19, 139);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(88, 35);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "추가";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_MenuPrice
            // 
            this.textBox_MenuPrice.Location = new System.Drawing.Point(92, 65);
            this.textBox_MenuPrice.Multiline = true;
            this.textBox_MenuPrice.Name = "textBox_MenuPrice";
            this.textBox_MenuPrice.Size = new System.Drawing.Size(203, 25);
            this.textBox_MenuPrice.TabIndex = 5;
            // 
            // textBox_MenuName
            // 
            this.textBox_MenuName.Location = new System.Drawing.Point(92, 35);
            this.textBox_MenuName.Multiline = true;
            this.textBox_MenuName.Name = "textBox_MenuName";
            this.textBox_MenuName.Size = new System.Drawing.Size(203, 25);
            this.textBox_MenuName.TabIndex = 4;
            // 
            // comboBox_Select
            // 
            this.comboBox_Select.DropDownHeight = 110;
            this.comboBox_Select.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_Select.FormattingEnabled = true;
            this.comboBox_Select.IntegralHeight = false;
            this.comboBox_Select.ItemHeight = 17;
            this.comboBox_Select.Items.AddRange(new object[] {
            "면류",
            "밥류",
            "요리류",
            "세트메뉴",
            "서비스",
            "주류"});
            this.comboBox_Select.Location = new System.Drawing.Point(92, 95);
            this.comboBox_Select.Name = "comboBox_Select";
            this.comboBox_Select.Size = new System.Drawing.Size(203, 25);
            this.comboBox_Select.TabIndex = 3;
            // 
            // label_MenuSelect
            // 
            this.label_MenuSelect.AutoSize = true;
            this.label_MenuSelect.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_MenuSelect.Location = new System.Drawing.Point(17, 99);
            this.label_MenuSelect.Name = "label_MenuSelect";
            this.label_MenuSelect.Size = new System.Drawing.Size(67, 15);
            this.label_MenuSelect.TabIndex = 2;
            this.label_MenuSelect.Text = "메뉴분류";
            // 
            // label_MenuPrice
            // 
            this.label_MenuPrice.AutoSize = true;
            this.label_MenuPrice.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_MenuPrice.Location = new System.Drawing.Point(17, 69);
            this.label_MenuPrice.Name = "label_MenuPrice";
            this.label_MenuPrice.Size = new System.Drawing.Size(67, 15);
            this.label_MenuPrice.TabIndex = 1;
            this.label_MenuPrice.Text = "메뉴가격";
            // 
            // label_MenuName
            // 
            this.label_MenuName.AutoSize = true;
            this.label_MenuName.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_MenuName.Location = new System.Drawing.Point(17, 39);
            this.label_MenuName.Name = "label_MenuName";
            this.label_MenuName.Size = new System.Drawing.Size(67, 15);
            this.label_MenuName.TabIndex = 0;
            this.label_MenuName.Text = "메뉴이름";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_Noodle);
            this.groupBox2.Location = new System.Drawing.Point(13, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 396);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "면류";
            // 
            // dataGridView_Noodle
            // 
            this.dataGridView_Noodle.AllowUserToAddRows = false;
            this.dataGridView_Noodle.AllowUserToDeleteRows = false;
            this.dataGridView_Noodle.AutoGenerateColumns = false;
            this.dataGridView_Noodle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Noodle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView_Noodle.DataSource = this.productBindingSource;
            this.dataGridView_Noodle.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_Noodle.Name = "dataGridView_Noodle";
            this.dataGridView_Noodle.ReadOnly = true;
            this.dataGridView_Noodle.RowTemplate.Height = 23;
            this.dataGridView_Noodle.Size = new System.Drawing.Size(304, 369);
            this.dataGridView_Noodle.TabIndex = 0;
            this.dataGridView_Noodle.CurrentCellChanged += new System.EventHandler(this.dataGridView_Noodle_CurrentCellChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_Rice);
            this.groupBox3.Location = new System.Drawing.Point(336, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 396);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "밥류";
            // 
            // dataGridView_Rice
            // 
            this.dataGridView_Rice.AllowUserToAddRows = false;
            this.dataGridView_Rice.AllowUserToDeleteRows = false;
            this.dataGridView_Rice.AutoGenerateColumns = false;
            this.dataGridView_Rice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Rice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.dataGridView_Rice.DataSource = this.productBindingSource;
            this.dataGridView_Rice.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_Rice.Name = "dataGridView_Rice";
            this.dataGridView_Rice.ReadOnly = true;
            this.dataGridView_Rice.RowTemplate.Height = 23;
            this.dataGridView_Rice.Size = new System.Drawing.Size(304, 369);
            this.dataGridView_Rice.TabIndex = 1;
            this.dataGridView_Rice.CurrentCellChanged += new System.EventHandler(this.dataGridView_Rice_CurrentCellChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_Cooking);
            this.groupBox4.Location = new System.Drawing.Point(659, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 396);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "요리류";
            // 
            // dataGridView_Cooking
            // 
            this.dataGridView_Cooking.AllowUserToAddRows = false;
            this.dataGridView_Cooking.AllowUserToDeleteRows = false;
            this.dataGridView_Cooking.AutoGenerateColumns = false;
            this.dataGridView_Cooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.priceDataGridViewTextBoxColumn2});
            this.dataGridView_Cooking.DataSource = this.productBindingSource;
            this.dataGridView_Cooking.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_Cooking.Name = "dataGridView_Cooking";
            this.dataGridView_Cooking.ReadOnly = true;
            this.dataGridView_Cooking.RowTemplate.Height = 23;
            this.dataGridView_Cooking.Size = new System.Drawing.Size(304, 369);
            this.dataGridView_Cooking.TabIndex = 2;
            this.dataGridView_Cooking.CurrentCellChanged += new System.EventHandler(this.dataGridView_Cooking_CurrentCellChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView_SetMenu);
            this.groupBox5.Location = new System.Drawing.Point(982, 232);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 396);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "세트메뉴";
            // 
            // dataGridView_SetMenu
            // 
            this.dataGridView_SetMenu.AllowUserToAddRows = false;
            this.dataGridView_SetMenu.AllowUserToDeleteRows = false;
            this.dataGridView_SetMenu.AutoGenerateColumns = false;
            this.dataGridView_SetMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SetMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn3,
            this.priceDataGridViewTextBoxColumn3});
            this.dataGridView_SetMenu.DataSource = this.productBindingSource;
            this.dataGridView_SetMenu.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_SetMenu.Name = "dataGridView_SetMenu";
            this.dataGridView_SetMenu.ReadOnly = true;
            this.dataGridView_SetMenu.RowTemplate.Height = 23;
            this.dataGridView_SetMenu.Size = new System.Drawing.Size(304, 369);
            this.dataGridView_SetMenu.TabIndex = 3;
            this.dataGridView_SetMenu.CurrentCellChanged += new System.EventHandler(this.dataGridView_SetMenu_CurrentCellChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.service_drink);
            this.groupBox6.Location = new System.Drawing.Point(1305, 232);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(317, 396);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "서비스/주류";
            // 
            // service_drink
            // 
            this.service_drink.Controls.Add(this.tabPage1);
            this.service_drink.Controls.Add(this.tabPage2);
            this.service_drink.Location = new System.Drawing.Point(7, 21);
            this.service_drink.Name = "service_drink";
            this.service_drink.SelectedIndex = 0;
            this.service_drink.Size = new System.Drawing.Size(310, 369);
            this.service_drink.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_service);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(302, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "서비스";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_service
            // 
            this.dataGridView_service.AllowUserToAddRows = false;
            this.dataGridView_service.AllowUserToDeleteRows = false;
            this.dataGridView_service.AutoGenerateColumns = false;
            this.dataGridView_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn4,
            this.priceDataGridViewTextBoxColumn4});
            this.dataGridView_service.DataSource = this.productBindingSource;
            this.dataGridView_service.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_service.Name = "dataGridView_service";
            this.dataGridView_service.ReadOnly = true;
            this.dataGridView_service.RowTemplate.Height = 23;
            this.dataGridView_service.Size = new System.Drawing.Size(301, 343);
            this.dataGridView_service.TabIndex = 4;
            this.dataGridView_service.CurrentCellChanged += new System.EventHandler(this.dataGridView_service_CurrentCellChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_Drink);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(302, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "주류";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Drink
            // 
            this.dataGridView_Drink.AllowUserToAddRows = false;
            this.dataGridView_Drink.AllowUserToDeleteRows = false;
            this.dataGridView_Drink.AutoGenerateColumns = false;
            this.dataGridView_Drink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Drink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn5,
            this.priceDataGridViewTextBoxColumn5});
            this.dataGridView_Drink.DataSource = this.productBindingSource;
            this.dataGridView_Drink.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Drink.Name = "dataGridView_Drink";
            this.dataGridView_Drink.ReadOnly = true;
            this.dataGridView_Drink.RowTemplate.Height = 23;
            this.dataGridView_Drink.Size = new System.Drawing.Size(301, 343);
            this.dataGridView_Drink.TabIndex = 5;
            this.dataGridView_Drink.CurrentCellChanged += new System.EventHandler(this.dataGridView_Drink_CurrentCellChanged);
            // 
            // nameDataGridViewTextBoxColumn4
            // 
            this.nameDataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn4.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn4.Name = "nameDataGridViewTextBoxColumn4";
            this.nameDataGridViewTextBoxColumn4.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn4.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn4
            // 
            this.priceDataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn4.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn4.Name = "priceDataGridViewTextBoxColumn4";
            this.priceDataGridViewTextBoxColumn4.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.priceDataGridViewTextBoxColumn4.Width = 110;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(FastFast.Product);
            // 
            // nameDataGridViewTextBoxColumn5
            // 
            this.nameDataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn5.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn5.Name = "nameDataGridViewTextBoxColumn5";
            this.nameDataGridViewTextBoxColumn5.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameDataGridViewTextBoxColumn5.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn5
            // 
            this.priceDataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn5.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn5.Name = "priceDataGridViewTextBoxColumn5";
            this.priceDataGridViewTextBoxColumn5.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.priceDataGridViewTextBoxColumn5.Width = 110;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn3.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn3
            // 
            this.priceDataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn3.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn3.Name = "priceDataGridViewTextBoxColumn3";
            this.priceDataGridViewTextBoxColumn3.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.priceDataGridViewTextBoxColumn3.Width = 110;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameDataGridViewTextBoxColumn2.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn2
            // 
            this.priceDataGridViewTextBoxColumn2.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn2.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn2.Name = "priceDataGridViewTextBoxColumn2";
            this.priceDataGridViewTextBoxColumn2.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn2.Width = 110;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn1.Width = 110;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 110;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1629, 668);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Noodle)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rice)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cooking)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SetMenu)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.service_drink.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_service)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Drink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_MenuSelect;
        private System.Windows.Forms.Label label_MenuPrice;
        private System.Windows.Forms.Label label_MenuName;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_MenuPrice;
        private System.Windows.Forms.TextBox textBox_MenuName;
        private System.Windows.Forms.ComboBox comboBox_Select;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView_Noodle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView_Rice;
        private System.Windows.Forms.DataGridView dataGridView_Cooking;
        private System.Windows.Forms.DataGridView dataGridView_SetMenu;
        private System.Windows.Forms.TabControl service_drink;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView_service;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView_Drink;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox textBox_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn2;
    }
}