namespace ComputerShop
{
    partial class Main_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mf_sb_total_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.mf_sb_totalCoast = new System.Windows.Forms.ToolStripStatusLabel();
            this.mf_gr_func = new System.Windows.Forms.GroupBox();
            this.mf_creatSelling = new System.Windows.Forms.Button();
            this.mf_createComputer = new System.Windows.Forms.Button();
            this.mf_CreateComponent = new System.Windows.Forms.Button();
            this.mf_addCategoryBtn = new System.Windows.Forms.Button();
            this.mf_data = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mf_dtp_from = new System.Windows.Forms.DateTimePicker();
            this.mf_dtp_to = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mf_cb_period = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.mf_gr_func.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mf_data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mf_sb_total_label,
            this.mf_sb_totalCoast});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1058, 30);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mf_sb_total_label
            // 
            this.mf_sb_total_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mf_sb_total_label.Name = "mf_sb_total_label";
            this.mf_sb_total_label.Size = new System.Drawing.Size(171, 25);
            this.mf_sb_total_label.Text = "Общая сумма продаж:";
            // 
            // mf_sb_totalCoast
            // 
            this.mf_sb_totalCoast.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.mf_sb_totalCoast.ForeColor = System.Drawing.Color.DarkRed;
            this.mf_sb_totalCoast.Name = "mf_sb_totalCoast";
            this.mf_sb_totalCoast.Size = new System.Drawing.Size(50, 25);
            this.mf_sb_totalCoast.Text = "0.00";
            // 
            // mf_gr_func
            // 
            this.mf_gr_func.Controls.Add(this.groupBox1);
            this.mf_gr_func.Controls.Add(this.mf_creatSelling);
            this.mf_gr_func.Controls.Add(this.mf_createComputer);
            this.mf_gr_func.Controls.Add(this.mf_CreateComponent);
            this.mf_gr_func.Controls.Add(this.mf_addCategoryBtn);
            this.mf_gr_func.Dock = System.Windows.Forms.DockStyle.Right;
            this.mf_gr_func.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mf_gr_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mf_gr_func.Location = new System.Drawing.Point(806, 0);
            this.mf_gr_func.Name = "mf_gr_func";
            this.mf_gr_func.Size = new System.Drawing.Size(252, 456);
            this.mf_gr_func.TabIndex = 1;
            this.mf_gr_func.TabStop = false;
            this.mf_gr_func.Text = "Функционал";
            // 
            // mf_creatSelling
            // 
            this.mf_creatSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mf_creatSelling.Location = new System.Drawing.Point(6, 217);
            this.mf_creatSelling.Name = "mf_creatSelling";
            this.mf_creatSelling.Size = new System.Drawing.Size(240, 47);
            this.mf_creatSelling.TabIndex = 3;
            this.mf_creatSelling.Text = "Создать продажу";
            this.mf_creatSelling.UseVisualStyleBackColor = true;
            // 
            // mf_createComputer
            // 
            this.mf_createComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mf_createComputer.Location = new System.Drawing.Point(6, 153);
            this.mf_createComputer.Name = "mf_createComputer";
            this.mf_createComputer.Size = new System.Drawing.Size(240, 47);
            this.mf_createComputer.TabIndex = 2;
            this.mf_createComputer.Text = "Добавить компьютер";
            this.mf_createComputer.UseVisualStyleBackColor = true;
            // 
            // mf_CreateComponent
            // 
            this.mf_CreateComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mf_CreateComponent.Location = new System.Drawing.Point(6, 90);
            this.mf_CreateComponent.Name = "mf_CreateComponent";
            this.mf_CreateComponent.Size = new System.Drawing.Size(240, 47);
            this.mf_CreateComponent.TabIndex = 1;
            this.mf_CreateComponent.Text = "Добавить компонент";
            this.mf_CreateComponent.UseVisualStyleBackColor = true;
            // 
            // mf_addCategoryBtn
            // 
            this.mf_addCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mf_addCategoryBtn.Location = new System.Drawing.Point(6, 28);
            this.mf_addCategoryBtn.Name = "mf_addCategoryBtn";
            this.mf_addCategoryBtn.Size = new System.Drawing.Size(240, 47);
            this.mf_addCategoryBtn.TabIndex = 0;
            this.mf_addCategoryBtn.Text = "Добавить категорию";
            this.mf_addCategoryBtn.UseVisualStyleBackColor = true;
            // 
            // mf_data
            // 
            this.mf_data.AllowUserToAddRows = false;
            this.mf_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mf_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mf_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mf_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mf_data.DefaultCellStyle = dataGridViewCellStyle2;
            this.mf_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mf_data.Location = new System.Drawing.Point(0, 0);
            this.mf_data.MultiSelect = false;
            this.mf_data.Name = "mf_data";
            this.mf_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mf_data.Size = new System.Drawing.Size(806, 456);
            this.mf_data.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mf_cb_period);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mf_dtp_to);
            this.groupBox1.Controls.Add(this.mf_dtp_from);
            this.groupBox1.Location = new System.Drawing.Point(6, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтровать";
            // 
            // mf_dtp_from
            // 
            this.mf_dtp_from.Enabled = false;
            this.mf_dtp_from.Location = new System.Drawing.Point(6, 77);
            this.mf_dtp_from.Name = "mf_dtp_from";
            this.mf_dtp_from.Size = new System.Drawing.Size(228, 29);
            this.mf_dtp_from.TabIndex = 0;
            // 
            // mf_dtp_to
            // 
            this.mf_dtp_to.Enabled = false;
            this.mf_dtp_to.Location = new System.Drawing.Point(6, 136);
            this.mf_dtp_to.Name = "mf_dtp_to";
            this.mf_dtp_to.Size = new System.Drawing.Size(228, 29);
            this.mf_dtp_to.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "По";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "С";
            // 
            // mf_cb_period
            // 
            this.mf_cb_period.AutoSize = true;
            this.mf_cb_period.Location = new System.Drawing.Point(6, 26);
            this.mf_cb_period.Name = "mf_cb_period";
            this.mf_cb_period.Size = new System.Drawing.Size(179, 28);
            this.mf_cb_period.TabIndex = 4;
            this.mf_cb_period.Text = "Выбрать период";
            this.mf_cb_period.UseVisualStyleBackColor = true;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 486);
            this.Controls.Add(this.mf_data);
            this.Controls.Add(this.mf_gr_func);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Shop";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mf_gr_func.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mf_data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mf_sb_total_label;
        private System.Windows.Forms.ToolStripStatusLabel mf_sb_totalCoast;
        private System.Windows.Forms.GroupBox mf_gr_func;
        private System.Windows.Forms.Button mf_addCategoryBtn;
        private System.Windows.Forms.DataGridView mf_data;
        private System.Windows.Forms.Button mf_CreateComponent;
        private System.Windows.Forms.Button mf_createComputer;
        private System.Windows.Forms.Button mf_creatSelling;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox mf_cb_period;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker mf_dtp_to;
        private System.Windows.Forms.DateTimePicker mf_dtp_from;
    }
}

