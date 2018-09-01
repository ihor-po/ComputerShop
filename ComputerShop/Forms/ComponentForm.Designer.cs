namespace ComputerShop.Forms
{
    partial class ComponentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.c_tb_title = new System.Windows.Forms.TextBox();
            this.c_cb_category = new System.Windows.Forms.ComboBox();
            this.c_tb_code = new System.Windows.Forms.TextBox();
            this.c_tb_price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.c_nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.cf_tb_description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.c_nud_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Артикул";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Описание";
            // 
            // c_tb_title
            // 
            this.c_tb_title.Location = new System.Drawing.Point(152, 20);
            this.c_tb_title.Name = "c_tb_title";
            this.c_tb_title.Size = new System.Drawing.Size(305, 26);
            this.c_tb_title.TabIndex = 6;
            // 
            // c_cb_category
            // 
            this.c_cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_cb_category.FormattingEnabled = true;
            this.c_cb_category.Location = new System.Drawing.Point(152, 56);
            this.c_cb_category.Name = "c_cb_category";
            this.c_cb_category.Size = new System.Drawing.Size(305, 28);
            this.c_cb_category.TabIndex = 7;
            // 
            // c_tb_code
            // 
            this.c_tb_code.Location = new System.Drawing.Point(152, 94);
            this.c_tb_code.Name = "c_tb_code";
            this.c_tb_code.Size = new System.Drawing.Size(305, 26);
            this.c_tb_code.TabIndex = 8;
            // 
            // c_tb_price
            // 
            this.c_tb_price.Location = new System.Drawing.Point(152, 129);
            this.c_tb_price.Name = "c_tb_price";
            this.c_tb_price.Size = new System.Drawing.Size(305, 26);
            this.c_tb_price.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(16, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(354, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // c_nud_quantity
            // 
            this.c_nud_quantity.Location = new System.Drawing.Point(152, 164);
            this.c_nud_quantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.c_nud_quantity.Name = "c_nud_quantity";
            this.c_nud_quantity.Size = new System.Drawing.Size(305, 26);
            this.c_nud_quantity.TabIndex = 14;
            // 
            // cf_tb_description
            // 
            this.cf_tb_description.Location = new System.Drawing.Point(152, 202);
            this.cf_tb_description.Multiline = true;
            this.cf_tb_description.Name = "cf_tb_description";
            this.cf_tb_description.Size = new System.Drawing.Size(305, 93);
            this.cf_tb_description.TabIndex = 15;
            // 
            // ComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 356);
            this.Controls.Add(this.cf_tb_description);
            this.Controls.Add(this.c_nud_quantity);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c_tb_price);
            this.Controls.Add(this.c_tb_code);
            this.Controls.Add(this.c_cb_category);
            this.Controls.Add(this.c_tb_title);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ComponentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компонент";
            ((System.ComponentModel.ISupportInitialize)(this.c_nud_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        protected internal System.Windows.Forms.TextBox c_tb_title;
        protected internal System.Windows.Forms.ComboBox c_cb_category;
        protected internal System.Windows.Forms.TextBox c_tb_code;
        protected internal System.Windows.Forms.TextBox c_tb_price;
        protected internal System.Windows.Forms.NumericUpDown c_nud_quantity;
        protected internal System.Windows.Forms.TextBox cf_tb_description;
    }
}