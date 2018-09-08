using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop.Forms
{
    public partial class ComputerForm : Form
    {
        ComputersShopContainer1 cf_db;
        double totalPrice;

        public ComputerForm()
        {
            InitializeComponent();

            cf_db = new ComputersShopContainer1();

            this.Load += ComputerForm_Load;
        }

        private void ComputerForm_Load(object sender, EventArgs e)
        {
            totalPrice = 0.00;

            cf_cb_category.DataSource = cf_db.Category.ToList();
            cf_cb_category.ValueMember = "Id";
            cf_cb_category.DisplayMember = "Title";

            cf_cb_category.SelectedIndex = -1;

            cf_cb_component.Enabled = false;
            cf_btn_addItem.Enabled = false;

            cf_cb_category.SelectedIndexChanged += Cf_cb_category_SelectedIndexChanged;
            cf_cb_component.SelectedIndexChanged += Cf_cb_component_SelectedIndexChanged;
            cf_btn_addItem.Click += Cf_btn_addItem_Click;
        }

        /// <summary>
        /// Добавление компонента в список составляющих компьютера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cf_btn_addItem_Click(object sender, EventArgs e)
        {
            if (cf_lv_components.Columns.Count == 0)
            {
                cf_lv_components.Columns.Add("ID");
                cf_lv_components.Columns[0].Width = 40;
                cf_lv_components.Columns.Add("Наименование");
                cf_lv_components.Columns[1].Width = 250;
                cf_lv_components.Columns.Add("Цена");
                cf_lv_components.Columns[2].Width = 87;
            }
            Component cmpt = cf_db.Component.FirstOrDefault(c => c.Id == (int)cf_cb_component.SelectedValue);
            ListViewItem item = new ListViewItem(cmpt.Id.ToString());
            item.SubItems.Add(cmpt.Title);
            item.SubItems.Add(cmpt.Price.ToString());

            cf_lv_components.Items.Add(item);

            totalPrice += ((double)cmpt.Price * 1.15);
            cf_l_totalPrice.Text = totalPrice.ToString();
        }

        private void Cf_cb_component_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem.ToString().Substring(0, 1) != cb.SelectedValue.ToString().Substring(0, 1))
            {
                int id = Convert.ToInt32(cb.SelectedValue.ToString());

                Component ct = cf_db.Component.FirstOrDefault(c => c.Id == id);
                cf_tb_description.Text = ct.Description;
                cf_btn_addItem.Enabled = true;
            }
        }

        private void Cf_cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComponentsByCategory(Convert.ToInt32(cf_cb_category.SelectedValue.ToString()));
        }

        /// <summary>
        /// Заполнение нужного комбобокса с компонентами по айди категории
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="categoryId"></param>
        private void FillComponentsByCategory(int categoryId)
        {
            try
            {
                List<Component> cmps = cf_db.Component.Where(c => c.CategoryId == categoryId).ToList();
                
                cf_cb_component.DataSource = cmps;
                cf_cb_component.ValueMember = "Id";
                cf_cb_component.DisplayMember = "Title";

                if (cmps.Count > 0)
                {
                    cf_cb_component.Enabled = true;
                }
                else
                {
                    cf_tb_description.Text = "";
                    cf_cb_component.Enabled = false;
                }
                
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
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

    }
}
