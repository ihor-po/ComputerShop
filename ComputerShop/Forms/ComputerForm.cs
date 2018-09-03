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
        List<Category> categories;
        List<Component> items;
        public ComputerForm(List<Category> _cat, List<Component> _comps)
        {
            InitializeComponent();

            categories = _cat;
            items = _comps;

            this.Load += ComputerForm_Load;
        }

        private void ComputerForm_Load(object sender, EventArgs e)
        {
            cf_cb_component.Enabled = false;
            cf_btn_addItem.Enabled = false;
        }
    }
}
