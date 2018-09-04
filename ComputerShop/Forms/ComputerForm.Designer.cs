namespace ComputerShop.Forms
{
    partial class ComputerForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cf_btn_addItem = new System.Windows.Forms.Button();
            this.cf_tb_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cf_cb_component = new System.Windows.Forms.ComboBox();
            this.cf_cb_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cf_lv_components = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.cf_btn_cancel = new System.Windows.Forms.Button();
            this.cf_btn_addComputer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 26);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cf_btn_addItem);
            this.groupBox1.Controls.Add(this.cf_tb_description);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cf_cb_component);
            this.groupBox1.Controls.Add(this.cf_cb_category);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 306);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Состовляющие";
            // 
            // cf_btn_addItem
            // 
            this.cf_btn_addItem.Location = new System.Drawing.Point(229, 258);
            this.cf_btn_addItem.Name = "cf_btn_addItem";
            this.cf_btn_addItem.Size = new System.Drawing.Size(185, 39);
            this.cf_btn_addItem.TabIndex = 5;
            this.cf_btn_addItem.Text = "Добавить компонент";
            this.cf_btn_addItem.UseVisualStyleBackColor = true;
            // 
            // cf_tb_description
            // 
            this.cf_tb_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cf_tb_description.Location = new System.Drawing.Point(11, 119);
            this.cf_tb_description.Multiline = true;
            this.cf_tb_description.Name = "cf_tb_description";
            this.cf_tb_description.ReadOnly = true;
            this.cf_tb_description.Size = new System.Drawing.Size(403, 132);
            this.cf_tb_description.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Компонент";
            // 
            // cf_cb_component
            // 
            this.cf_cb_component.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cf_cb_component.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cf_cb_component.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cf_cb_component.FormattingEnabled = true;
            this.cf_cb_component.Location = new System.Drawing.Point(110, 75);
            this.cf_cb_component.Name = "cf_cb_component";
            this.cf_cb_component.Size = new System.Drawing.Size(304, 28);
            this.cf_cb_component.TabIndex = 2;
            // 
            // cf_cb_category
            // 
            this.cf_cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cf_cb_category.FormattingEnabled = true;
            this.cf_cb_category.Location = new System.Drawing.Point(110, 27);
            this.cf_cb_category.Name = "cf_cb_category";
            this.cf_cb_category.Size = new System.Drawing.Size(304, 28);
            this.cf_cb_category.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Категория";
            // 
            // cf_lv_components
            // 
            this.cf_lv_components.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cf_lv_components.FullRowSelect = true;
            this.cf_lv_components.GridLines = true;
            this.cf_lv_components.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.cf_lv_components.Location = new System.Drawing.Point(469, 47);
            this.cf_lv_components.Name = "cf_lv_components";
            this.cf_lv_components.Size = new System.Drawing.Size(378, 314);
            this.cf_lv_components.TabIndex = 3;
            this.cf_lv_components.UseCompatibleStateImageBehavior = false;
            this.cf_lv_components.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Компоненты";
            // 
            // cf_btn_cancel
            // 
            this.cf_btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cf_btn_cancel.Location = new System.Drawing.Point(469, 377);
            this.cf_btn_cancel.Name = "cf_btn_cancel";
            this.cf_btn_cancel.Size = new System.Drawing.Size(152, 34);
            this.cf_btn_cancel.TabIndex = 5;
            this.cf_btn_cancel.Text = "Отмена";
            this.cf_btn_cancel.UseVisualStyleBackColor = true;
            // 
            // cf_btn_addComputer
            // 
            this.cf_btn_addComputer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cf_btn_addComputer.Location = new System.Drawing.Point(650, 377);
            this.cf_btn_addComputer.Name = "cf_btn_addComputer";
            this.cf_btn_addComputer.Size = new System.Drawing.Size(198, 34);
            this.cf_btn_addComputer.TabIndex = 6;
            this.cf_btn_addComputer.Text = "Добавить компьютер";
            this.cf_btn_addComputer.UseVisualStyleBackColor = true;
            // 
            // ComputerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 427);
            this.Controls.Add(this.cf_btn_addComputer);
            this.Controls.Add(this.cf_btn_cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cf_lv_components);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ComputerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление компьютера";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView cf_lv_components;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cf_btn_cancel;
        private System.Windows.Forms.Button cf_btn_addComputer;
        protected internal System.Windows.Forms.ComboBox cf_cb_category;
        protected internal System.Windows.Forms.ComboBox cf_cb_component;
        protected internal System.Windows.Forms.Button cf_btn_addItem;
        protected internal System.Windows.Forms.TextBox cf_tb_description;
    }
}