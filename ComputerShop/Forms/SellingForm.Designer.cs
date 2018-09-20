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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sf_gb_filters = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sf_cb_price = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sf_cb_vendorCode = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sf_cb_title = new System.Windows.Forms.CheckBox();
            this.sf_cb_category = new System.Windows.Forms.CheckBox();
            this.sf_rg_items = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.sf_lbl_balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sf_num_quantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.sf_cb_sellingItems = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.sf_gb_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
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
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Location = new System.Drawing.Point(367, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(448, 369);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(685, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sf_gb_filters
            // 
            this.sf_gb_filters.Controls.Add(this.numericUpDown3);
            this.sf_gb_filters.Controls.Add(this.numericUpDown2);
            this.sf_gb_filters.Controls.Add(this.label5);
            this.sf_gb_filters.Controls.Add(this.label4);
            this.sf_gb_filters.Controls.Add(this.sf_cb_price);
            this.sf_gb_filters.Controls.Add(this.textBox2);
            this.sf_gb_filters.Controls.Add(this.sf_cb_vendorCode);
            this.sf_gb_filters.Controls.Add(this.textBox1);
            this.sf_gb_filters.Controls.Add(this.sf_cb_title);
            this.sf_gb_filters.Controls.Add(this.sf_cb_category);
            this.sf_gb_filters.Controls.Add(this.sf_cbf_category);
            this.sf_gb_filters.Location = new System.Drawing.Point(12, 270);
            this.sf_gb_filters.Name = "sf_gb_filters";
            this.sf_gb_filters.Size = new System.Drawing.Size(339, 293);
            this.sf_gb_filters.TabIndex = 6;
            this.sf_gb_filters.TabStop = false;
            this.sf_gb_filters.Text = "Фильтрация";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new System.Drawing.Point(206, 257);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(126, 26);
            this.numericUpDown3.TabIndex = 16;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(37, 257);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(125, 26);
            this.numericUpDown2.TabIndex = 15;
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
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(6, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(327, 26);
            this.textBox2.TabIndex = 4;
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
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(5, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 26);
            this.textBox1.TabIndex = 2;
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
            this.sf_rg_items.Controls.Add(this.button3);
            this.sf_rg_items.Controls.Add(this.sf_lbl_balance);
            this.sf_rg_items.Controls.Add(this.label2);
            this.sf_rg_items.Controls.Add(this.sf_num_quantity);
            this.sf_rg_items.Controls.Add(this.label1);
            this.sf_rg_items.Controls.Add(this.sf_cb_sellingItems);
            this.sf_rg_items.Location = new System.Drawing.Point(12, 119);
            this.sf_rg_items.Name = "sf_rg_items";
            this.sf_rg_items.Size = new System.Drawing.Size(339, 145);
            this.sf_rg_items.TabIndex = 7;
            this.sf_rg_items.TabStop = false;
            this.sf_rg_items.Text = "Комплектующие";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 60);
            this.button3.TabIndex = 12;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
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
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(367, 398);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(448, 116);
            this.textBox4.TabIndex = 8;
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 571);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.sf_rg_items);
            this.Controls.Add(this.sf_gb_filters);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox sf_gb_filters;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox sf_cb_price;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox sf_cb_vendorCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox sf_cb_title;
        private System.Windows.Forms.CheckBox sf_cb_category;
        private System.Windows.Forms.GroupBox sf_rg_items;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label sf_lbl_balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sf_num_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sf_cb_sellingItems;
        private System.Windows.Forms.TextBox textBox4;
    }
}