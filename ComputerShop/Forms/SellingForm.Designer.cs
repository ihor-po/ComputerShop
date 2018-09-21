namespace ComputerShop.Forms
{
    partial class SellingForm
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
            this.sf_cbf_category = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sf_rb_computer = new System.Windows.Forms.RadioButton();
            this.sf_rb_component = new System.Windows.Forms.RadioButton();
            this.sf_lv_checkItems = new System.Windows.Forms.ListView();
            this.sf_btn_cancel = new System.Windows.Forms.Button();
            this.sf_btn_createCheck = new System.Windows.Forms.Button();
            this.sf_gb_filters = new System.Windows.Forms.GroupBox();
            this.sf_num_priceTo = new System.Windows.Forms.NumericUpDown();
            this.sf_num_priceFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sf_cb_price = new System.Windows.Forms.CheckBox();
            this.sf_tbf_vendorCode = new System.Windows.Forms.TextBox();
            this.sf_cb_vendorCode = new System.Windows.Forms.CheckBox();
            this.sf_tbf_title = new System.Windows.Forms.TextBox();
            this.sf_cb_title = new System.Windows.Forms.CheckBox();
            this.sf_cb_category = new System.Windows.Forms.CheckBox();
            this.sf_rg_items = new System.Windows.Forms.GroupBox();
            this.sf_btn_add = new System.Windows.Forms.Button();
            this.sf_lbl_balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sf_num_quantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.sf_cb_sellingItems = new System.Windows.Forms.ComboBox();
            this.sf_tb_description = new System.Windows.Forms.TextBox();
            this.colVendCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.sf_lbl_result = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sf_cb_buyer = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.sf_gb_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sf_num_priceTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sf_num_priceFrom)).BeginInit();
            this.sf_rg_items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sf_num_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // sf_cbf_category
            // 
            this.sf_cbf_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sf_cbf_category.Enabled = false;
            this.sf_cbf_category.FormattingEnabled = true;
            this.sf_cbf_category.Location = new System.Drawing.Point(5, 61);
            this.sf_cbf_category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sf_cbf_category.Name = "sf_cbf_category";
            this.sf_cbf_category.Size = new System.Drawing.Size(327, 28);
            this.sf_cbf_category.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sf_rb_computer);
            this.groupBox1.Controls.Add(this.sf_rb_component);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Продажа";
            // 
            // sf_rb_computer
            // 
            this.sf_rb_computer.AutoSize = true;
            this.sf_rb_computer.Location = new System.Drawing.Point(7, 66);
            this.sf_rb_computer.Name = "sf_rb_computer";
            this.sf_rb_computer.Size = new System.Drawing.Size(114, 24);
            this.sf_rb_computer.TabIndex = 1;
            this.sf_rb_computer.Text = "Компьютер";
            this.sf_rb_computer.UseVisualStyleBackColor = true;
            // 
            // sf_rb_component
            // 
            this.sf_rb_component.AutoSize = true;
            this.sf_rb_component.Checked = true;
            this.sf_rb_component.Location = new System.Drawing.Point(7, 31);
            this.sf_rb_component.Name = "sf_rb_component";
            this.sf_rb_component.Size = new System.Drawing.Size(152, 24);
            this.sf_rb_component.TabIndex = 0;
            this.sf_rb_component.TabStop = true;
            this.sf_rb_component.Text = "Комплектующее";
            this.sf_rb_component.UseVisualStyleBackColor = true;
            // 
            // sf_lv_checkItems
            // 
            this.sf_lv_checkItems.BackColor = System.Drawing.SystemColors.Window;
            this.sf_lv_checkItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sf_lv_checkItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colVendCode,
            this.colQuantity,
            this.colName,
            this.colPrice});
            this.sf_lv_checkItems.FullRowSelect = true;
            this.sf_lv_checkItems.GridLines = true;
            this.sf_lv_checkItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.sf_lv_checkItems.Location = new System.Drawing.Point(367, 12);
            this.sf_lv_checkItems.MultiSelect = false;
            this.sf_lv_checkItems.Name = "sf_lv_checkItems";
            this.sf_lv_checkItems.Size = new System.Drawing.Size(560, 422);
            this.sf_lv_checkItems.TabIndex = 2;
            this.sf_lv_checkItems.UseCompatibleStateImageBehavior = false;
            this.sf_lv_checkItems.View = System.Windows.Forms.View.Details;
            // 
            // sf_btn_cancel
            // 
            this.sf_btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sf_btn_cancel.Location = new System.Drawing.Point(367, 575);
            this.sf_btn_cancel.Name = "sf_btn_cancel";
            this.sf_btn_cancel.Size = new System.Drawing.Size(130, 43);
            this.sf_btn_cancel.TabIndex = 3;
            this.sf_btn_cancel.Text = "Отменить";
            this.sf_btn_cancel.UseVisualStyleBackColor = true;
            // 
            // sf_btn_createCheck
            // 
            this.sf_btn_createCheck.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sf_btn_createCheck.Location = new System.Drawing.Point(797, 576);
            this.sf_btn_createCheck.Name = "sf_btn_createCheck";
            this.sf_btn_createCheck.Size = new System.Drawing.Size(130, 43);
            this.sf_btn_createCheck.TabIndex = 4;
            this.sf_btn_createCheck.Text = "Создать";
            this.sf_btn_createCheck.UseVisualStyleBackColor = true;
            // 
            // sf_gb_filters
            // 
            this.sf_gb_filters.Controls.Add(this.sf_num_priceTo);
            this.sf_gb_filters.Controls.Add(this.sf_num_priceFrom);
            this.sf_gb_filters.Controls.Add(this.label5);
            this.sf_gb_filters.Controls.Add(this.label4);
            this.sf_gb_filters.Controls.Add(this.sf_cb_price);
            this.sf_gb_filters.Controls.Add(this.sf_tbf_vendorCode);
            this.sf_gb_filters.Controls.Add(this.sf_cb_vendorCode);
            this.sf_gb_filters.Controls.Add(this.sf_tbf_title);
            this.sf_gb_filters.Controls.Add(this.sf_cb_title);
            this.sf_gb_filters.Controls.Add(this.sf_cb_category);
            this.sf_gb_filters.Controls.Add(this.sf_cbf_category);
            this.sf_gb_filters.Location = new System.Drawing.Point(12, 329);
            this.sf_gb_filters.Name = "sf_gb_filters";
            this.sf_gb_filters.Size = new System.Drawing.Size(339, 293);
            this.sf_gb_filters.TabIndex = 6;
            this.sf_gb_filters.TabStop = false;
            this.sf_gb_filters.Text = "Фильтрация";
            // 
            // sf_num_priceTo
            // 
            this.sf_num_priceTo.Enabled = false;
            this.sf_num_priceTo.Location = new System.Drawing.Point(206, 257);
            this.sf_num_priceTo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.sf_num_priceTo.Name = "sf_num_priceTo";
            this.sf_num_priceTo.Size = new System.Drawing.Size(126, 26);
            this.sf_num_priceTo.TabIndex = 16;
            // 
            // sf_num_priceFrom
            // 
            this.sf_num_priceFrom.Enabled = false;
            this.sf_num_priceFrom.Location = new System.Drawing.Point(37, 257);
            this.sf_num_priceFrom.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.sf_num_priceFrom.Name = "sf_num_priceFrom";
            this.sf_num_priceFrom.Size = new System.Drawing.Size(125, 26);
            this.sf_num_priceFrom.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "До";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "От";
            // 
            // sf_cb_price
            // 
            this.sf_cb_price.AutoSize = true;
            this.sf_cb_price.Location = new System.Drawing.Point(7, 224);
            this.sf_cb_price.Name = "sf_cb_price";
            this.sf_cb_price.Size = new System.Drawing.Size(67, 24);
            this.sf_cb_price.TabIndex = 5;
            this.sf_cb_price.Text = "Цена";
            this.sf_cb_price.UseVisualStyleBackColor = true;
            // 
            // sf_tbf_vendorCode
            // 
            this.sf_tbf_vendorCode.Enabled = false;
            this.sf_tbf_vendorCode.Location = new System.Drawing.Point(6, 191);
            this.sf_tbf_vendorCode.Name = "sf_tbf_vendorCode";
            this.sf_tbf_vendorCode.Size = new System.Drawing.Size(327, 26);
            this.sf_tbf_vendorCode.TabIndex = 4;
            // 
            // sf_cb_vendorCode
            // 
            this.sf_cb_vendorCode.AutoSize = true;
            this.sf_cb_vendorCode.Location = new System.Drawing.Point(6, 160);
            this.sf_cb_vendorCode.Name = "sf_cb_vendorCode";
            this.sf_cb_vendorCode.Size = new System.Drawing.Size(91, 24);
            this.sf_cb_vendorCode.TabIndex = 3;
            this.sf_cb_vendorCode.Text = "Артикул";
            this.sf_cb_vendorCode.UseVisualStyleBackColor = true;
            // 
            // sf_tbf_title
            // 
            this.sf_tbf_title.Enabled = false;
            this.sf_tbf_title.Location = new System.Drawing.Point(5, 128);
            this.sf_tbf_title.Name = "sf_tbf_title";
            this.sf_tbf_title.Size = new System.Drawing.Size(327, 26);
            this.sf_tbf_title.TabIndex = 2;
            // 
            // sf_cb_title
            // 
            this.sf_cb_title.AutoSize = true;
            this.sf_cb_title.Location = new System.Drawing.Point(5, 97);
            this.sf_cb_title.Name = "sf_cb_title";
            this.sf_cb_title.Size = new System.Drawing.Size(102, 24);
            this.sf_cb_title.TabIndex = 1;
            this.sf_cb_title.Text = "Название";
            this.sf_cb_title.UseVisualStyleBackColor = true;
            // 
            // sf_cb_category
            // 
            this.sf_cb_category.AutoSize = true;
            this.sf_cb_category.Location = new System.Drawing.Point(7, 29);
            this.sf_cb_category.Name = "sf_cb_category";
            this.sf_cb_category.Size = new System.Drawing.Size(108, 24);
            this.sf_cb_category.TabIndex = 0;
            this.sf_cb_category.Text = "Категория";
            this.sf_cb_category.UseVisualStyleBackColor = true;
            // 
            // sf_rg_items
            // 
            this.sf_rg_items.Controls.Add(this.sf_btn_add);
            this.sf_rg_items.Controls.Add(this.sf_lbl_balance);
            this.sf_rg_items.Controls.Add(this.label2);
            this.sf_rg_items.Controls.Add(this.sf_num_quantity);
            this.sf_rg_items.Controls.Add(this.label1);
            this.sf_rg_items.Controls.Add(this.sf_cb_sellingItems);
            this.sf_rg_items.Location = new System.Drawing.Point(12, 178);
            this.sf_rg_items.Name = "sf_rg_items";
            this.sf_rg_items.Size = new System.Drawing.Size(339, 145);
            this.sf_rg_items.TabIndex = 7;
            this.sf_rg_items.TabStop = false;
            this.sf_rg_items.Text = "Комплектующие";
            // 
            // sf_btn_add
            // 
            this.sf_btn_add.Location = new System.Drawing.Point(224, 79);
            this.sf_btn_add.Name = "sf_btn_add";
            this.sf_btn_add.Size = new System.Drawing.Size(108, 60);
            this.sf_btn_add.TabIndex = 12;
            this.sf_btn_add.Text = "Добавить";
            this.sf_btn_add.UseVisualStyleBackColor = true;
            // 
            // sf_lbl_balance
            // 
            this.sf_lbl_balance.AutoSize = true;
            this.sf_lbl_balance.Location = new System.Drawing.Point(117, 114);
            this.sf_lbl_balance.Name = "sf_lbl_balance";
            this.sf_lbl_balance.Size = new System.Drawing.Size(18, 20);
            this.sf_lbl_balance.TabIndex = 11;
            this.sf_lbl_balance.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Остаток";
            // 
            // sf_num_quantity
            // 
            this.sf_num_quantity.Location = new System.Drawing.Point(119, 79);
            this.sf_num_quantity.Name = "sf_num_quantity";
            this.sf_num_quantity.Size = new System.Drawing.Size(99, 26);
            this.sf_num_quantity.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Колличество";
            // 
            // sf_cb_sellingItems
            // 
            this.sf_cb_sellingItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sf_cb_sellingItems.FormattingEnabled = true;
            this.sf_cb_sellingItems.Location = new System.Drawing.Point(5, 37);
            this.sf_cb_sellingItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sf_cb_sellingItems.Name = "sf_cb_sellingItems";
            this.sf_cb_sellingItems.Size = new System.Drawing.Size(327, 28);
            this.sf_cb_sellingItems.TabIndex = 7;
            // 
            // sf_tb_description
            // 
            this.sf_tb_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sf_tb_description.Enabled = false;
            this.sf_tb_description.Location = new System.Drawing.Point(367, 450);
            this.sf_tb_description.Multiline = true;
            this.sf_tb_description.Name = "sf_tb_description";
            this.sf_tb_description.ReadOnly = true;
            this.sf_tb_description.Size = new System.Drawing.Size(560, 116);
            this.sf_tb_description.TabIndex = 8;
            // 
            // colVendCode
            // 
            this.colVendCode.Text = "Артикул";
            this.colVendCode.Width = 120;
            // 
            // colName
            // 
            this.colName.DisplayIndex = 1;
            this.colName.Text = "Наименование";
            this.colName.Width = 210;
            // 
            // colQuantity
            // 
            this.colQuantity.DisplayIndex = 2;
            this.colQuantity.Text = "Количество";
            this.colQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colQuantity.Width = 105;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Цена";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPrice.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(503, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Общая сумма";
            // 
            // sf_lbl_result
            // 
            this.sf_lbl_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sf_lbl_result.AutoSize = true;
            this.sf_lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sf_lbl_result.ForeColor = System.Drawing.Color.Maroon;
            this.sf_lbl_result.Location = new System.Drawing.Point(638, 583);
            this.sf_lbl_result.Name = "sf_lbl_result";
            this.sf_lbl_result.Size = new System.Drawing.Size(27, 29);
            this.sf_lbl_result.TabIndex = 10;
            this.sf_lbl_result.Text = "0";
            this.sf_lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Покупатель";
            // 
            // sf_cb_buyer
            // 
            this.sf_cb_buyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sf_cb_buyer.FormattingEnabled = true;
            this.sf_cb_buyer.Location = new System.Drawing.Point(17, 38);
            this.sf_cb_buyer.Name = "sf_cb_buyer";
            this.sf_cb_buyer.Size = new System.Drawing.Size(334, 28);
            this.sf_cb_buyer.TabIndex = 11;
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 632);
            this.Controls.Add(this.sf_cb_buyer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sf_lbl_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sf_tb_description);
            this.Controls.Add(this.sf_rg_items);
            this.Controls.Add(this.sf_gb_filters);
            this.Controls.Add(this.sf_btn_createCheck);
            this.Controls.Add(this.sf_btn_cancel);
            this.Controls.Add(this.sf_lv_checkItems);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажа";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sf_gb_filters.ResumeLayout(false);
            this.sf_gb_filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sf_num_priceTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sf_num_priceFrom)).EndInit();
            this.sf_rg_items.ResumeLayout(false);
            this.sf_rg_items.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sf_num_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sf_cbf_category;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sf_rb_computer;
        private System.Windows.Forms.RadioButton sf_rb_component;
        private System.Windows.Forms.ListView sf_lv_checkItems;
        private System.Windows.Forms.Button sf_btn_cancel;
        private System.Windows.Forms.Button sf_btn_createCheck;
        private System.Windows.Forms.GroupBox sf_gb_filters;
        private System.Windows.Forms.NumericUpDown sf_num_priceTo;
        private System.Windows.Forms.NumericUpDown sf_num_priceFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox sf_cb_price;
        private System.Windows.Forms.TextBox sf_tbf_vendorCode;
        private System.Windows.Forms.CheckBox sf_cb_vendorCode;
        private System.Windows.Forms.TextBox sf_tbf_title;
        private System.Windows.Forms.CheckBox sf_cb_title;
        private System.Windows.Forms.CheckBox sf_cb_category;
        private System.Windows.Forms.GroupBox sf_rg_items;
        private System.Windows.Forms.Button sf_btn_add;
        private System.Windows.Forms.Label sf_lbl_balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sf_num_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sf_cb_sellingItems;
        private System.Windows.Forms.TextBox sf_tb_description;
        private System.Windows.Forms.ColumnHeader colVendCode;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sf_lbl_result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sf_cb_buyer;
    }
}