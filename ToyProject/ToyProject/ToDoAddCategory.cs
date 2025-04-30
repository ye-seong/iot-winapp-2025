using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyProject
{
    public partial class ToDoAddCategory : Form
    {
        private CategorySystem.CategoryManager _categoryManager;
        public bool IsAdd = false;
        public ToDoAddCategory()
        {
            InitializeComponent();
            GetCategory();
        }
        private void GetCategory()
        {
            if (_categoryManager == null)
            {
                _categoryManager = new CategorySystem.CategoryManager();
                _categoryManager.LoadCategories();
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            _categoryManager.Add(txtCategory.Text, "#FF5733");
            if (_categoryManager.IsAdd)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
