namespace Магазин_автозапчастей
{
    partial class Main
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
            this.menu = new System.Windows.Forms.TabControl();
            this.Details = new System.Windows.Forms.TabPage();
            this.price_up = new System.Windows.Forms.CheckBox();
            this.price_down = new System.Windows.Forms.CheckBox();
            this.alpha_sortirovka = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.detail_list = new System.Windows.Forms.DataGridView();
            this.History = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.history_list = new System.Windows.Forms.DataGridView();
            this.Providers = new System.Windows.Forms.TabPage();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.provider_list = new System.Windows.Forms.DataGridView();
            this.Shipments = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.delete_ship = new System.Windows.Forms.Button();
            this.update_ship = new System.Windows.Forms.Button();
            this.add_ship = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.shipment_list = new System.Windows.Forms.DataGridView();
            this.Customers = new System.Windows.Forms.TabPage();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.customer_list = new System.Windows.Forms.DataGridView();
            this.Sales = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sale_list = new System.Windows.Forms.DataGridView();
            this.menu.SuspendLayout();
            this.Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detail_list)).BeginInit();
            this.History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.history_list)).BeginInit();
            this.Providers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provider_list)).BeginInit();
            this.Shipments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipment_list)).BeginInit();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_list)).BeginInit();
            this.Sales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sale_list)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Controls.Add(this.Details);
            this.menu.Controls.Add(this.History);
            this.menu.Controls.Add(this.Providers);
            this.menu.Controls.Add(this.Shipments);
            this.menu.Controls.Add(this.Customers);
            this.menu.Controls.Add(this.Sales);
            this.menu.Location = new System.Drawing.Point(-1, -1);
            this.menu.Name = "menu";
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(879, 531);
            this.menu.TabIndex = 0;
            this.menu.Selected += new System.Windows.Forms.TabControlEventHandler(this.menu_Selected);
            // 
            // Details
            // 
            this.Details.Controls.Add(this.price_up);
            this.Details.Controls.Add(this.price_down);
            this.Details.Controls.Add(this.alpha_sortirovka);
            this.Details.Controls.Add(this.label12);
            this.Details.Controls.Add(this.textBox2);
            this.Details.Controls.Add(this.label6);
            this.Details.Controls.Add(this.detail_list);
            this.Details.Location = new System.Drawing.Point(4, 28);
            this.Details.Name = "Details";
            this.Details.Padding = new System.Windows.Forms.Padding(3);
            this.Details.Size = new System.Drawing.Size(871, 499);
            this.Details.TabIndex = 0;
            this.Details.Text = "Детали";
            this.Details.UseVisualStyleBackColor = true;
            // 
            // price_up
            // 
            this.price_up.AutoSize = true;
            this.price_up.Location = new System.Drawing.Point(663, 215);
            this.price_up.Name = "price_up";
            this.price_up.Size = new System.Drawing.Size(187, 23);
            this.price_up.TabIndex = 7;
            this.price_up.Text = "по возрастанию цены";
            this.price_up.UseVisualStyleBackColor = true;
            this.price_up.CheckedChanged += new System.EventHandler(this.price_up_CheckedChanged);
            // 
            // price_down
            // 
            this.price_down.AutoSize = true;
            this.price_down.Location = new System.Drawing.Point(663, 185);
            this.price_down.Name = "price_down";
            this.price_down.Size = new System.Drawing.Size(167, 23);
            this.price_down.TabIndex = 6;
            this.price_down.Text = "по убыванию цены";
            this.price_down.UseVisualStyleBackColor = true;
            this.price_down.CheckedChanged += new System.EventHandler(this.price_down_CheckedChanged);
            // 
            // alpha_sortirovka
            // 
            this.alpha_sortirovka.AutoSize = true;
            this.alpha_sortirovka.Location = new System.Drawing.Point(663, 155);
            this.alpha_sortirovka.Name = "alpha_sortirovka";
            this.alpha_sortirovka.Size = new System.Drawing.Size(121, 23);
            this.alpha_sortirovka.TabIndex = 5;
            this.alpha_sortirovka.Text = "по алфавиту";
            this.alpha_sortirovka.UseVisualStyleBackColor = true;
            this.alpha_sortirovka.CheckedChanged += new System.EventHandler(this.alpha_sortirovka_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(695, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Сортировка";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(636, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 27);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Поиск";
            // 
            // detail_list
            // 
            this.detail_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detail_list.Location = new System.Drawing.Point(9, 6);
            this.detail_list.Name = "detail_list";
            this.detail_list.Size = new System.Drawing.Size(621, 484);
            this.detail_list.TabIndex = 0;
            // 
            // History
            // 
            this.History.Controls.Add(this.checkBox1);
            this.History.Controls.Add(this.checkBox4);
            this.History.Controls.Add(this.label13);
            this.History.Controls.Add(this.textBox3);
            this.History.Controls.Add(this.label7);
            this.History.Controls.Add(this.history_list);
            this.History.Location = new System.Drawing.Point(4, 28);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(3);
            this.History.Size = new System.Drawing.Size(871, 499);
            this.History.TabIndex = 1;
            this.History.Text = "История цен";
            this.History.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(664, 208);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(187, 23);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "по возрастанию цены";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(664, 179);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(167, 23);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "по убыванию цены";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(701, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "Сортировка";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(636, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 27);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(717, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Поиск";
            // 
            // history_list
            // 
            this.history_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.history_list.Location = new System.Drawing.Point(9, 6);
            this.history_list.Name = "history_list";
            this.history_list.Size = new System.Drawing.Size(621, 484);
            this.history_list.TabIndex = 1;
            // 
            // Providers
            // 
            this.Providers.Controls.Add(this.checkBox5);
            this.Providers.Controls.Add(this.label14);
            this.Providers.Controls.Add(this.textBox4);
            this.Providers.Controls.Add(this.label8);
            this.Providers.Controls.Add(this.provider_list);
            this.Providers.Location = new System.Drawing.Point(4, 28);
            this.Providers.Name = "Providers";
            this.Providers.Size = new System.Drawing.Size(871, 499);
            this.Providers.TabIndex = 2;
            this.Providers.Text = "Поставщики";
            this.Providers.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(693, 172);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(121, 23);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "по алфавиту";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(699, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 19);
            this.label14.TabIndex = 6;
            this.label14.Text = "Сортировка";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(638, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 27);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(719, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Поиск";
            // 
            // provider_list
            // 
            this.provider_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provider_list.Location = new System.Drawing.Point(9, 6);
            this.provider_list.Name = "provider_list";
            this.provider_list.Size = new System.Drawing.Size(621, 484);
            this.provider_list.TabIndex = 1;
            // 
            // Shipments
            // 
            this.Shipments.Controls.Add(this.comboBox3);
            this.Shipments.Controls.Add(this.label16);
            this.Shipments.Controls.Add(this.button7);
            this.Shipments.Controls.Add(this.checkBox6);
            this.Shipments.Controls.Add(this.label15);
            this.Shipments.Controls.Add(this.delete_ship);
            this.Shipments.Controls.Add(this.update_ship);
            this.Shipments.Controls.Add(this.add_ship);
            this.Shipments.Controls.Add(this.textBox5);
            this.Shipments.Controls.Add(this.label9);
            this.Shipments.Controls.Add(this.shipment_list);
            this.Shipments.Location = new System.Drawing.Point(4, 28);
            this.Shipments.Name = "Shipments";
            this.Shipments.Size = new System.Drawing.Size(871, 499);
            this.Shipments.TabIndex = 3;
            this.Shipments.Text = "Поставки";
            this.Shipments.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(637, 233);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(224, 27);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.SelectedValueChanged += new System.EventHandler(this.comboBox3_SelectedValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(698, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 19);
            this.label16.TabIndex = 13;
            this.label16.Text = "Фильтрация";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(686, 266);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 39);
            this.button7.TabIndex = 12;
            this.button7.Text = "Выбрать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(686, 118);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(134, 23);
            this.checkBox6.TabIndex = 10;
            this.checkBox6.Text = "по количеству";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(698, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 19);
            this.label15.TabIndex = 9;
            this.label15.Text = "Сортировка";
            // 
            // delete_ship
            // 
            this.delete_ship.Location = new System.Drawing.Point(637, 428);
            this.delete_ship.Name = "delete_ship";
            this.delete_ship.Size = new System.Drawing.Size(224, 39);
            this.delete_ship.TabIndex = 8;
            this.delete_ship.Text = "Удалить";
            this.delete_ship.UseVisualStyleBackColor = true;
            this.delete_ship.Click += new System.EventHandler(this.delete_ship_Click);
            // 
            // update_ship
            // 
            this.update_ship.Location = new System.Drawing.Point(637, 383);
            this.update_ship.Name = "update_ship";
            this.update_ship.Size = new System.Drawing.Size(224, 39);
            this.update_ship.TabIndex = 7;
            this.update_ship.Text = "Редактировать";
            this.update_ship.UseVisualStyleBackColor = true;
            this.update_ship.Click += new System.EventHandler(this.update_ship_Click);
            // 
            // add_ship
            // 
            this.add_ship.Location = new System.Drawing.Point(637, 338);
            this.add_ship.Name = "add_ship";
            this.add_ship.Size = new System.Drawing.Size(224, 39);
            this.add_ship.TabIndex = 6;
            this.add_ship.Text = "Добавить";
            this.add_ship.UseVisualStyleBackColor = true;
            this.add_ship.Click += new System.EventHandler(this.add_ship_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(637, 28);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(225, 27);
            this.textBox5.TabIndex = 5;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(718, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Поиск";
            // 
            // shipment_list
            // 
            this.shipment_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipment_list.Location = new System.Drawing.Point(9, 6);
            this.shipment_list.Name = "shipment_list";
            this.shipment_list.Size = new System.Drawing.Size(621, 484);
            this.shipment_list.TabIndex = 1;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.checkBox10);
            this.Customers.Controls.Add(this.checkBox9);
            this.Customers.Controls.Add(this.checkBox8);
            this.Customers.Controls.Add(this.label17);
            this.Customers.Controls.Add(this.button1);
            this.Customers.Controls.Add(this.button2);
            this.Customers.Controls.Add(this.button3);
            this.Customers.Controls.Add(this.textBox6);
            this.Customers.Controls.Add(this.label10);
            this.Customers.Controls.Add(this.customer_list);
            this.Customers.Location = new System.Drawing.Point(4, 28);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(871, 499);
            this.Customers.TabIndex = 4;
            this.Customers.Text = "Заказчики";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(684, 241);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(117, 23);
            this.checkBox10.TabIndex = 15;
            this.checkBox10.Text = "по фамилии";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(684, 211);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(116, 23);
            this.checkBox9.TabIndex = 14;
            this.checkBox9.Text = "по отчеству";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(684, 181);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(96, 23);
            this.checkBox8.TabIndex = 13;
            this.checkBox8.Text = "по имени";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(702, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 19);
            this.label17.TabIndex = 12;
            this.label17.Text = "Сортировка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(636, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(636, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 39);
            this.button3.TabIndex = 9;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(638, 28);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(225, 27);
            this.textBox6.TabIndex = 5;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(719, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Поиск";
            // 
            // customer_list
            // 
            this.customer_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_list.Location = new System.Drawing.Point(9, 6);
            this.customer_list.Name = "customer_list";
            this.customer_list.Size = new System.Drawing.Size(621, 484);
            this.customer_list.TabIndex = 1;
            // 
            // Sales
            // 
            this.Sales.Controls.Add(this.button4);
            this.Sales.Controls.Add(this.button5);
            this.Sales.Controls.Add(this.button6);
            this.Sales.Controls.Add(this.textBox7);
            this.Sales.Controls.Add(this.label11);
            this.Sales.Controls.Add(this.sale_list);
            this.Sales.Location = new System.Drawing.Point(4, 28);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(871, 499);
            this.Sales.TabIndex = 5;
            this.Sales.Text = "Продажи";
            this.Sales.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(636, 451);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 39);
            this.button4.TabIndex = 11;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(636, 406);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(225, 39);
            this.button5.TabIndex = 10;
            this.button5.Text = "Редактировать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(636, 361);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(225, 39);
            this.button6.TabIndex = 9;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(636, 28);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(225, 27);
            this.textBox7.TabIndex = 5;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(721, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "Поиск";
            // 
            // sale_list
            // 
            this.sale_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sale_list.Location = new System.Drawing.Point(9, 6);
            this.sale_list.Name = "sale_list";
            this.sale_list.Size = new System.Drawing.Size(621, 484);
            this.sale_list.TabIndex = 1;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(876, 529);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Main";
            this.Text = "Главное меню";
            this.menu.ResumeLayout(false);
            this.Details.ResumeLayout(false);
            this.Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detail_list)).EndInit();
            this.History.ResumeLayout(false);
            this.History.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.history_list)).EndInit();
            this.Providers.ResumeLayout(false);
            this.Providers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provider_list)).EndInit();
            this.Shipments.ResumeLayout(false);
            this.Shipments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipment_list)).EndInit();
            this.Customers.ResumeLayout(false);
            this.Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_list)).EndInit();
            this.Sales.ResumeLayout(false);
            this.Sales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sale_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox alpha_sort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl menu;
        private System.Windows.Forms.TabPage Details;
        private System.Windows.Forms.DataGridView detail_list;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.DataGridView history_list;
        private System.Windows.Forms.TabPage Providers;
        private System.Windows.Forms.DataGridView provider_list;
        private System.Windows.Forms.TabPage Shipments;
        private System.Windows.Forms.DataGridView shipment_list;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.DataGridView customer_list;
        private System.Windows.Forms.TabPage Sales;
        private System.Windows.Forms.DataGridView sale_list;
        private System.Windows.Forms.CheckBox price_up;
        private System.Windows.Forms.CheckBox price_down;
        private System.Windows.Forms.CheckBox alpha_sortirovka;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button delete_ship;
        private System.Windows.Forms.Button update_ship;
        private System.Windows.Forms.Button add_ship;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
    }
}