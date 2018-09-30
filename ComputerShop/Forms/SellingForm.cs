using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop.Forms
{
    public partial class SellingForm : Form
    {
        private ComputersShopContainer1 sf_db;
        private decimal totalPrice;

        public SellingForm()
        {
            InitializeComponent();

            this.Load += SellingForm_Load;
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            sf_db = new ComputersShopContainer1();
            totalPrice = 0;

            sf_cb_buyer.DataSource = sf_db.Buyer.ToList();
            sf_cb_buyer.ValueMember = "Id";
            sf_cb_buyer.DisplayMember = "LastName";

            GetSellingItems("component");
            GetComponentBalance(sf_cb_sellingItems);

            sf_rb_component.CheckedChanged += Sf_rb_component_CheckedChanged;
            sf_rb_computer.CheckedChanged += Sf_rb_computer_CheckedChanged;
            sf_cb_sellingItems.SelectedIndexChanged += Sf_cb_sellingItems_SelectedIndexChanged;
            sf_cb_category.CheckedChanged += Sf_cb_category_CheckedChanged;
            sf_cbf_category.SelectedIndexChanged += Sf_cbf_category_SelectedIndexChanged;
            sf_cb_title.CheckedChanged += Sf_cb_title_CheckedChanged;
            sf_tbf_title.TextChanged += Sf_tbf_title_TextChanged;
            sf_cb_vendorCode.CheckedChanged += Sf_cb_vendorCode_CheckedChanged;
            sf_tbf_vendorCode.TextChanged += Sf_tbf_title_TextChanged;
            sf_cb_price.CheckedChanged += Sf_cb_price_CheckedChanged;
            sf_num_priceFrom.ValueChanged += Sf_num_priceFrom_ValueChanged;
            sf_num_priceTo.ValueChanged += Sf_num_priceFrom_ValueChanged;
            sf_btn_add.Click += Sf_btn_add_Click;
            sf_lv_checkItems.SelectedIndexChanged += Sf_lv_checkItems_SelectedIndexChanged;
            sf_btn_cancel.Click += Sf_btn_cancel_Click;
            sf_lv_checkItems.MouseDoubleClick += Sf_lv_checkItems_MouseDoubleClick;
            sf_btn_createCheck.Click += Sf_btn_createCheck_Click;
        }

        private void Sf_btn_createCheck_Click(object sender, EventArgs e)
        {
            if (sf_cb_buyer.SelectedIndex != -1)
            {
                if (sf_lv_checkItems.Items.Count > 0)
                {
                    using (var transaction = sf_db.Database.BeginTransaction())
                    {
                        try
                        {
                            //Сохранение чека в БД
                            Check check = new Check();
                            check.BuyerId = (int)sf_cb_buyer.SelectedValue;
                            check.Date = DateTime.Now;
                            check.CheckCoast = Convert.ToDouble(string.Format("{0:0.00}", totalPrice.ToString()));
                            sf_db.Check.Add(check);
                            sf_db.SaveChanges();


                            //Сохранение компонентов в БД
                            foreach (ListViewItem item in sf_lv_checkItems.Items)
                            {
                                CheckItem ci = new CheckItem();
                                ci.CheckId = check.Id;
                              
                                if (item.Text != "N/A")
                                {
                                    int quantity = Convert.ToInt32(item.SubItems[1].Text);
                                    ci.ItemId = sf_db.Component.FirstOrDefault(tmp => tmp.Vendor_code == item.Text).Id;
                                    ci.ItemQuantity = quantity;
                                    ci.IsComputer = 0;

                                    Component cmpnt = sf_db.Component.FirstOrDefault(c => c.Id == ci.ItemId);
                                    quantity = cmpnt.Quantity - quantity;
                                    cmpnt.Quantity = (short)quantity;
                                    sf_db.SaveChanges();
                                }
                                else
                                {
                                    string title = item.SubItems[2].Text;
                                    Computer _tmp = sf_db.Computer.FirstOrDefault(tmp => tmp.Title == title);
                                    ci.ItemId = _tmp.Id;
                                    ci.IsComputer = 1;
                                }
                                sf_db.CheckItem.Add(ci);
                                sf_db.SaveChanges();

                               
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
                    ShowMessage("Вы не добавили в чек товар!");
                }
            }
            else
            {
                ShowMessage("Вы не выбрали покупателя");
            }

            
        }

        /// <summary>
        /// Удаление товара из списка чека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_lv_checkItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (sf_lv_checkItems.SelectedItems[0] != null)
            {
                if (MessageBox.Show("Удалить компонент?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    if (totalPrice != 0)
                    {
                        totalPrice -= (Convert.ToDecimal(sf_lv_checkItems.SelectedItems[0].SubItems[3].Text) * Convert.ToInt32(sf_lv_checkItems.SelectedItems[0].SubItems[1].Text));
                        sf_lbl_result.Text = totalPrice.ToString();
                    }

                    sf_lv_checkItems.Items.Remove(sf_lv_checkItems.SelectedItems[0]);
                    sf_tb_description.Text = "0";
                }
            }
        }

        /// <summary>
        /// Отмена создания чека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработка выбора элемента в лист вью
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_lv_checkItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sf_lv_checkItems.SelectedItems.Count > 0 && sf_lv_checkItems.SelectedItems[0] != null)
            {
                string vendorCode = sf_lv_checkItems.SelectedItems[0].Text;

                if (vendorCode != "N/A")
                {
                    Component cmpt = sf_db.Component.FirstOrDefault(c => c.Vendor_code == vendorCode);

                    if (cmpt != null)
                    {
                        sf_tb_description.Text = cmpt.Description;
                    }
                    else
                    {
                        sf_tb_description.Text = "";
                    }
                }
                else
                {
                    string title = sf_lv_checkItems.SelectedItems[0].SubItems[2].Text;
                    Computer comp = sf_db.Computer.FirstOrDefault(c => c.Title == title);

                    if (comp != null)
                    {
                        sf_tb_description.Text = comp.Title;
                    }
                    else
                    {
                        sf_tb_description.Text = "";
                    }
                }
            }
           
        }

        /// <summary>
        /// Добавление товара в чек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_btn_add_Click(object sender, EventArgs e)
        {
            if (sf_num_quantity.Value > 0)
            {
                if (sf_rb_component.Checked == true)
                {
                    AddComponentToCheck();
                }
                else
                {
                    AddComputerToCheck();
                }
                sf_num_quantity.Value = 0;
            }
        }

        #region Filters Controls
        /// <summary>
        /// Обработка изменения цены в фильтре
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_num_priceFrom_ValueChanged(object sender, EventArgs e)
        {
            if (sf_rb_component.Checked == true)
            {
                FilterItems("component");
            }
            else
            {
                FilterItems("computer");
            }
        }

        
        /// <summary>
        /// Обработка выбора чекбокса Цена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_cb_price_CheckedChanged(object sender, EventArgs e)
        {
            if (sf_cb_price.Checked == true)
            {
                sf_num_priceFrom.Enabled = true;
                sf_num_priceTo.Enabled = true;
            }
            else
            {
                sf_num_priceFrom.Value = 0;
                sf_num_priceTo.Value = 0;
                sf_num_priceFrom.Enabled = false;
                sf_num_priceTo.Enabled = false;
            }
        }

        /// <summary>
        /// Обработка выбора чекбокса Артикул
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_cb_vendorCode_CheckedChanged(object sender, EventArgs e)
        {
            if (sf_cb_vendorCode.Checked == true)
            {
                sf_tbf_vendorCode.Enabled = true;
            }
            else
            {
                sf_tbf_vendorCode.Text = "";
                sf_tbf_vendorCode.Enabled = false;
            }
        }

        /// <summary>
        /// Обработка ввода текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_tbf_title_TextChanged(object sender, EventArgs e)
        {
            if (sf_rb_component.Checked == true)
            {
                FilterItems("component");
            }
            else
            {
                FilterItems("computer");
            }
        }

        /// <summary>
        /// Обработка выбора чекбокса "Название"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_cb_title_CheckedChanged(object sender, EventArgs e)
        {
            if (sf_cb_title.Checked == true)
            {
                sf_tbf_title.Enabled = true;
            }
            else
            {
                sf_tbf_title.Text = "";
                sf_tbf_title.Enabled = false;
            }
        }

        /// <summary>
        /// Обработка смены категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_cbf_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sf_rb_component.Checked == true)
            {
                FilterItems("component");
            }
            else
            {
                FilterItems("computer");
            }
        }

        /// <summary>
        /// Обработка выбора фильтра чекбокса Категория
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_cb_category_CheckedChanged(object sender, EventArgs e)
        {
            if (sf_cb_category.Checked == true)
            {
                sf_cbf_category.DataSource = sf_db.Category.ToList();
                sf_cbf_category.ValueMember = "Id";
                sf_cbf_category.DisplayMember = "Title";
                sf_cbf_category.Enabled = true;
            }
            else
            {
                sf_cbf_category.Enabled = false;
                sf_cbf_category.DataSource = null;
            }
        }
        #endregion

        /// <summary>
        /// Обработка события изменения выбранного элемента для продажи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_cb_sellingItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (sf_rb_component.Checked == true)
            {
                GetComponentBalance(cb);
            }
            else
            {
                GetComputerBalance(cb);
            }
        }

        /// <summary>
        /// Обработка состояния радиокнопки Компьютер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_rb_computer_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton _this = sender as RadioButton;

            if (_this.Checked == true)
            {
                GetSellingItems("computer");
                sf_rg_items.Text = "Компьютеры";
                GetEnabledFilters(false);
            }
        }

        /// <summary>
        /// Обработка состояния радиокнопки Комплектующее
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sf_rb_component_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton _this = sender as RadioButton;

            if (_this.Checked == true)
            {
                GetSellingItems("component");
                sf_rg_items.Text = "Комплектующие";
                GetEnabledFilters(true);
            }
        }

        /// <summary>
        /// Взависимости от передаваемого параметра заполнение комбобокса элементами
        /// </summary>
        /// <param name="rb"></param>
        private void GetSellingItems(string rb)
        {
            switch(rb)
            {
                case "component":
                    sf_cb_sellingItems.DataSource = sf_db.Component.ToList();
                    break;
                case "computer":
                    sf_cb_sellingItems.DataSource = sf_db.Computer.ToList();
                    break;
            }
            
            sf_cb_sellingItems.ValueMember = "Id";
            sf_cb_sellingItems.DisplayMember = "Title";
        }

        /// <summary>
        /// Получение доступного колличества выбранного комплектующего
        /// </summary>
        private void GetComponentBalance(ComboBox cb)
        {
            Component cmpt = sf_db.Component.FirstOrDefault(c => c.Id == (int)cb.SelectedValue);
            if (cmpt != null)
            {
                sf_lbl_balance.Text = cmpt.Quantity.ToString();
                sf_num_quantity.Maximum = cmpt.Quantity; // установка максимального значения
            }
            else
            {
                sf_lbl_balance.Text = "0";
                sf_num_quantity.Maximum = 0;
            }
        }

        /// <summary>
        /// Получение количетсва доступных компьютеров
        /// </summary>
        /// <param name="cb"></param>
        private void GetComputerBalance(ComboBox cb)
        {
            Computer comp = sf_db.Computer.FirstOrDefault(c => c.Id == (int)cb.SelectedValue);
            if (comp != null)
            {
                int minBalance = 0; //для определения доступного колличества выбранного компьютера 

                foreach(ComputerItem c in comp.ComputerItem)
                {
                    Component cmpt = sf_db.Component.FirstOrDefault(item => item.Id == c.ComponentId);

                    if (cmpt != null)
                    {
                        if (minBalance == 0)
                        {
                            minBalance = cmpt.Quantity;
                        }
                    }
                    else
                    {
                        if (minBalance > cmpt.Quantity)
                        {
                            minBalance = cmpt.Quantity;
                        }
                    }
                
                }

                sf_lbl_balance.Text = minBalance.ToString();
                sf_num_quantity.Maximum = minBalance; // установка максимального значения
            }
            else
            {
                sf_lbl_balance.Text = "0";
                sf_num_quantity.Maximum = 0;
            }
        }

        /// <summary>
        /// Изменение доступности фильтров, взависимости от вібраной продажи
        /// </summary>
        /// <param name="status"></param>
        private void GetEnabledFilters(bool status)
        {
            foreach(var item in sf_gb_filters.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox tmp = item as CheckBox;
                    if (tmp.Text != "Цена" && tmp.Text != "Название")
                    {
                        tmp.Enabled = status;
                    }
                }
            }
        }

        /// <summary>
        /// Фильтрация товаров
        /// </summary>
        /// <param name="item"></param>
        private void FilterItems(string item)
        {
            switch (item)
            {
                case "component":
                    List<Component> cmpt = sf_db.Component.ToList();

                    if (sf_cb_category.Checked == true)
                    {
                        if (sf_cbf_category.SelectedValue is int)
                        {
                            cmpt = cmpt.Where(tmp => tmp.CategoryId == (int)sf_cbf_category.SelectedValue).ToList();
                        }
                    }

                    if (sf_cb_title.Checked == true)
                    {
                        cmpt = cmpt.Where(tmp => tmp.Title.ToLower().Contains(sf_tbf_title.Text.ToLower())).ToList();
                    }

                    if (sf_cb_vendorCode.Checked == true)
                    {
                        cmpt = cmpt.Where(tmp => tmp.Vendor_code.ToLower().Contains(sf_tbf_vendorCode.Text.ToLower())).ToList();
                    }

                    if (sf_cb_price.Checked == true)
                    {
                        cmpt = cmpt.Where(tmp => tmp.Price >= sf_num_priceFrom.Value && tmp.Price <= sf_num_priceTo.Value).ToList();
                    }

                    sf_cb_sellingItems.DataSource = cmpt;
                    sf_cb_sellingItems.ValueMember = "Id";
                    sf_cb_sellingItems.DisplayMember = "Title";
                    break;
                case "computer":
                    List<Computer> comp = sf_db.Computer.ToList();
                    if (sf_cb_title.Checked == true)
                    {
                        comp = comp.Where(tmp => tmp.Title.ToLower().Contains(sf_tbf_title.Text.ToLower())).ToList();
                    }

                    if (sf_cb_price.Checked == true)
                    {
                        comp = comp.Where(tmp => tmp.Price >= sf_num_priceFrom.Value && tmp.Price <= sf_num_priceTo.Value).ToList();
                    }

                    sf_cb_sellingItems.DataSource = comp;
                    sf_cb_sellingItems.ValueMember = "Id";
                    sf_cb_sellingItems.DisplayMember = "Title";
                    break;
            }


        }

        /// <summary>
        /// Добавление комплектующего в чек
        /// </summary>
        private void AddComponentToCheck()
        {
            Component cmpt = sf_db.Component.FirstOrDefault(c => c.Id == (int)sf_cb_sellingItems.SelectedValue);
            ListViewItem item = new ListViewItem(cmpt.Vendor_code.ToString());
            item.SubItems.Add(sf_num_quantity.Value.ToString());
            item.SubItems.Add(cmpt.Title);
            item.SubItems.Add(cmpt.Price.ToString());

            sf_lv_checkItems.Items.Add(item);

            totalPrice += sf_num_quantity.Value * cmpt.Price;
            sf_lbl_result.Text = totalPrice.ToString();
        }

        /// <summary>
        /// Добавление компьютера в чек
        /// </summary>
        private void AddComputerToCheck()
        {
            Computer comp = sf_db.Computer.FirstOrDefault(c => c.Id == (int)sf_cb_sellingItems.SelectedValue);
            ListViewItem item = new ListViewItem("N/A");
            item.SubItems.Add(sf_num_quantity.Value.ToString());
            item.SubItems.Add(comp.Title);
            item.SubItems.Add(comp.Price.ToString());

            sf_lv_checkItems.Items.Add(item);

            totalPrice += sf_num_quantity.Value * comp.Price;
            sf_lbl_result.Text = totalPrice.ToString();
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