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
    public partial class ComponentForm : Form
    {
        string previousInput = "";

        public ComponentForm()
        {
            InitializeComponent();

            this.Load += ComponentForm_Load;
        }

        private void ComponentForm_Load(object sender, EventArgs e)
        {
            c_tb_price.Text = "0";
        }
        
    }
}
