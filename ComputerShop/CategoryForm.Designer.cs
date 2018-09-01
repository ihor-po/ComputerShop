namespace ComputerShop
{
    partial class CategoryForm
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
            this.cf_canselBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cf_canselBtn
            // 
            this.cf_canselBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cf_canselBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cf_canselBtn.Location = new System.Drawing.Point(13, 94);
            this.cf_canselBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cf_canselBtn.Name = "cf_canselBtn";
            this.cf_canselBtn.Size = new System.Drawing.Size(112, 35);
            this.cf_canselBtn.TabIndex = 0;
            this.cf_canselBtn.Text = "Отмена";
            this.cf_canselBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(248, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // categoryName
            // 
            this.categoryName.Location = new System.Drawing.Point(98, 29);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(262, 26);
            this.categoryName.TabIndex = 3;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 140);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cf_canselBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление категории";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cf_canselBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox categoryName;
    }
}