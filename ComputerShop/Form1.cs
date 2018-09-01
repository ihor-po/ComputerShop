using ComputerShop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class Main_form : Form
    {

        ComputersShopContainer1 db;

        protected const string regText = @"(?m)^.[a-zA-Zа-яА-Я0-9 -]{2,30}(?=\r?$)";
        protected const string regCode = @"(?m)^[A-Z0-9]{13}$";

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
            mf_CreateComponent.Click += Mf_CreateComponent_Click;
        }
        /// <summary>
        /// Обработка нажатия кнопки добавить компонент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mf_CreateComponent_Click(object sender, EventArgs e)
        {
            ComponentForm cf = new ComponentForm();

            cf.c_cb_category.DataSource = db.Category.ToList();
            cf.c_cb_category.ValueMember = "Id";
            cf.c_cb_category.DisplayMember = "Title";

            //cf.c_cb_category.Items.AddRange(db.Category.Select(c => c.Title).ToArray());

            if (cf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (cf.c_cb_category.SelectedIndex == -1)
                    {
                        throw new Exception("Вы не выбрали категорию");
                    }

                    int categoryId = Convert.ToInt32(cf.c_cb_category.SelectedValue);

                    if (!Regex.IsMatch(cf.c_tb_title.Text, regText))
                    {
                        throw new Exception("Ошибка в наименовании!");
                    }

                    if (!Regex.IsMatch(cf.c_tb_code.Text, regCode))
                    {
                        throw new Exception("Ошибка в артикуле!\n" +
                            "Только заглавные английские буквы\n" +
                            "Только цифры!\nДлина 13 символов");
                    }

                    decimal price = (decimal)(Convert.ToDouble(cf.c_tb_price.Text));
                    int quantity = Convert.ToInt32(cf.c_nud_quantity.Value);

                    Component component = new Component();
                    component.Title = cf.c_tb_title.Text;
                    component.CategoryId = categoryId;
                    component.Vendor_code = cf.c_tb_code.Text;
                    component.Price = price;
                    component.Quantity = (short)quantity;
                    component.Description = cf.cf_tb_description.Text;
                    db.Component.Add(component);
                    db.SaveChanges();

                    MessageBox.Show("Новая категория добавлена");
                }
                catch (Exception ex)
                {
                    ShowMessage(ex.Message);
                }
            }
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
                try
                {
                    if (Regex.IsMatch(cf.categoryName.Text, regText))
                    {
                        Category category = new Category();
                        category.Title = cf.categoryName.Text;
                        db.Category.Add(category);
                        db.SaveChanges();

                        MessageBox.Show("Новая категория добавлена");
                    }
                    else
                    {
                        throw new Exception("Ошибка в названии категории");
                    }
                    
                }
                catch (Exception ex)
                {
                    ShowMessage(ex.Message);
                }
                
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

        /// <summary>
        /// Заполнение данными DataGridView
        /// </summary>
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
