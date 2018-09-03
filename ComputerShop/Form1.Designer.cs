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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mf_sb_total_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.mf_sb_totalCoast = new System.Windows.Forms.ToolStripStatusLabel();
            this.mf_gr_func = new System.Windows.Forms.GroupBox();
            this.mf_CreateComponent = new System.Windows.Forms.Button();
            this.mf_addCategoryBtn = new System.Windows.Forms.Button();
            this.mf_data = new System.Windows.Forms.DataGridView();
            this.mf_createComputer = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.mf_gr_func.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mf_data)).BeginInit();
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
            this.mf_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mf_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mf_data.Location = new System.Drawing.Point(0, 0);
            this.mf_data.Name = "mf_data";
            this.mf_data.ReadOnly = true;
            this.mf_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mf_data.Size = new System.Drawing.Size(806, 456);
            this.mf_data.TabIndex = 2;
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
    }
}

