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

namespace ComputerShop.Forms
{
    public partial class ComputerForm : Form
    {
        private const double assemblyPersent = 1.15; //константа для расчета стоимости (15% за сборку)
        private const string regText = @"(?m)^.[a-zA-Zа-яА-Я0-9 -]{2,30}(?=\r?$)";
        private ComputersShopContainer1 cf_db;
        private double totalPrice;

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
            cf_btn_addComputer.Click += Cf_btn_addComputer_Click;
            cf_lv_components.MouseDoubleClick += Cf_lv_components_MouseDoubleClick;
        }

        private void Cf_lv_components_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (cf_lv_components.SelectedItems[0] != null)
            {
                if (MessageBox.Show("Удалить компонент?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    if (totalPrice != 0)
                    {
                        totalPrice -= (Convert.ToDouble(cf_lv_components.SelectedItems[0].SubItems[2].Text) * assemblyPersent);
                        cf_l_totalPrice.Text = totalPrice.ToString();
                    }

                    cf_lv_components.Items.Remove(cf_lv_components.SelectedItems[0]);
                }
            }
        }


        /// <summary>
        /// Добавление компьютера в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cf_btn_addComputer_Click(object sender, EventArgs e)
        {
            if (cf_tb_computerName.Text != "")
            {
                if (cf_lv_components.Items.Count != 0)
                {
                    if (Regex.IsMatch(cf_tb_computerName.Text, regText))
                    {
                        using (var transaction = cf_db.Database.BeginTransaction())
                        {
                            try
                            {
                                //Сохранение компьютера в БД
                                Computer comp = new Computer();
                                comp.Title = cf_tb_computerName.Text;
                                comp.Price = Convert.ToDecimal(string.Format("{0:0.00}", totalPrice.ToString()));
                                cf_db.Computer.Add(comp);
                                cf_db.SaveChanges();


                                //Сохранение компонентов в БД
                                foreach (ListViewItem item in cf_lv_components.Items)
                                {
                                    ComputerItem ci = new ComputerItem();
                                    ci.ComputerId = comp.Id;
                                    ci.ComponentId = Convert.ToInt32(item.Text.ToString());

                                    cf_db.ComputerItem.Add(ci);
                                    cf_db.SaveChanges();
                                }
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                ShowMessage(ex.Message);
                                transaction.Rollback();
                            }
                        }
                    }
                    else
                    {
                        ShowMessage("Ошибка в названии компьютера");
                        this.DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    ShowMessage("Компоненты не добавлены!");
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                ShowMessage("Введите название компьютера!");
                this.DialogResult = DialogResult.None;
            }
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

            totalPrice += ((double)cmpt.Price * assemblyPersent);
            cf_l_totalPrice.Text = totalPrice.ToString();
        }

        /// <summary>
        /// Событие изменения выбранного компонента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Событие изменения выбранной категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cf_cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComponentsByCategory(Convert.ToInt32(cf_cb_category.SelectedValue.ToString()));
        }

        /// <summary>
        /// Заполнение комбобокса с компонентами по айди категории
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
