using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyProject;
using static ToyProject.CategorySystem;

namespace ToyProject
{
    public partial class ToDoDetailForm : Form
    {
        private TodoItem _todoItem;
        public TodoItem TodoItem => _todoItem;
        private CategorySystem.CategoryManager _categoryManager;
        private List<Category> _categories;

        public ToDoDetailForm()
        {
            InitializeComponent();
            _todoItem = new TodoItem();
            GetCategory();
        }

        public ToDoDetailForm(TodoItem item)
        {
            InitializeComponent();
            _todoItem = item;
            txtTitle.Text = item.Title;
            txtContents.Text = item.Contents;
            GetCategory();
        }

        private void GetCategory()
        {
            if (_categoryManager == null)
            {
                _categoryManager = new CategorySystem.CategoryManager();
                _categoryManager.LoadCategories();
            }
            _categories = _categoryManager.GetCategories();
            cobCategory.DataSource = _categories;
            cobCategory.SelectedIndex = _categoryManager.GetCategoryIndex(_todoItem.Category.Name);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("제목을 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }
            if (_todoItem == null)
            {
                _todoItem = new TodoItem();
            }
            _todoItem.Title = txtTitle.Text;
            _todoItem.Contents = txtContents.Text;
            _todoItem.Category = cobCategory.SelectedItem as Category;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cobCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
