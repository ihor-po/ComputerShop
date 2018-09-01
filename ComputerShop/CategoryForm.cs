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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();

            this.Load += CategoryForm_Load;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            cf_canselBtn.Click += Cf_canselBtn_Click;
        }

        private void Cf_canselBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
