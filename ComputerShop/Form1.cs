using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class Main_form : Form
    {

        ComputersShopContainer1 db;

        public Main_form()
        {
            InitializeComponent();

            this.Load += Main_form_Load;
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            db = new ComputersShopContainer1();


            FillData();
            

            mf_addCategoryBtn.Click += Mf_addCategoryBtn_Click;
        }

        /// <summary>
        /// Обработка нажатия кнопки Добавление категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mf_addCategoryBtn_Click(object sender, EventArgs e)
        {
            CategoryForm cf = new CategoryForm();

            if (cf.ShowDialog() == DialogResult.OK)
            {
                Category category = new Category();
                category.Title = cf.categoryName.Text;

                db.Category.Add(category);
                db.SaveChanges();

                MessageBox.Show("Новая категория добавлена");
            }
        }

        /// <summary>
        /// Отображение сообщения
        /// </summary>
        /// <param name="msg"></param>
        private void ShowMessage(string msg)
        {
            MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillData()
        {
            try
            {
                mf_data.DataSource = db.Category.Select(cat => new { ID = cat.Id, Наименование = cat.Title }).ToList();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }
    }
}
