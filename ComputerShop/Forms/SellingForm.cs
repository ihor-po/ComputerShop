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
    public partial class SellingForm : Form
    {
        private ComputersShopContainer1 sf_db;

        public SellingForm()
        {
            InitializeComponent();

            this.Load += SellingForm_Load;
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            sf_db = new ComputersShopContainer1();

            GetSellingItems("component");
            GetComponentBalance(sf_cb_sellingItems);

            sf_rb_component.CheckedChanged += Sf_rb_component_CheckedChanged;
            sf_rb_computer.CheckedChanged += Sf_rb_computer_CheckedChanged;
            sf_cb_sellingItems.SelectedIndexChanged += Sf_cb_sellingItems_SelectedIndexChanged;
        }

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
            MessageBox.Show(cb.SelectedValue.ToString());
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
    }
}
