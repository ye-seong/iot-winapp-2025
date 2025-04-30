using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using ToyProject;
using System.Text.Json;
using ToyProject.Properties;

namespace ToyProject
{
    public partial class TodoCalendar : Form
    {

        List<TodoItem> todoItems = new List<TodoItem>();
        private CategorySystem.CategoryManager _categoryManager;
        public TodoCalendar()
        {
            InitializeComponent();
            LoadData();
            _categoryManager = new CategorySystem.CategoryManager();
            _categoryManager.LoadCategories();
        }

        private void LoadData()
        {
            string filePath = Path.Combine(Application.StartupPath, "todoItem.json");

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                todoItems = JsonSerializer.Deserialize<List<TodoItem>>(json) ?? new List<TodoItem>();
                foreach (var item in todoItems)
                {
                    if (item.DueDate.Date == Calendar.TodayDate)
                    {
                        ListBox.Items.Add(item.Title);
                        ListBox.SetItemChecked(ListBox.Items.Count - 1, item.IsCompleted);
                    }
                }
            }
            else
            {
                todoItems = new List<TodoItem>();
            }
            UpdatePercentBar();
        }

        public List<TodoItem> GetTodoItems()
        {
            return todoItems;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ToDoDetailForm detailForm = new ToDoDetailForm();
            DialogResult result = detailForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                TodoItem newItem = detailForm.TodoItem;
                newItem.DueDate = Calendar.SelectionStart.Date;
                if (newItem != null)
                {
                    todoItems.Add(newItem);
                    ListBox.Items.Add(newItem.Title);
                    UpdatePercentBar();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(todoItems);
            File.WriteAllText("todoItem.json", json);
            MessageBox.Show("저장이 완료되었습니다.", "메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            ListBox.Items.Clear();
            foreach (var item in todoItems)
            {
                if (item.DueDate.Date == e.Start.Date)
                {
                    ListBox.Items.Add(item.Title);
                    ListBox.SetItemChecked(ListBox.Items.Count - 1, item.IsCompleted);
                }
            }
            UpdatePercentBar();
        }

        private void ListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int index = ListBox.SelectedIndex;
            int parIdx = GetIndexOfItem(index);
            if (parIdx >= 0)
            {
                todoItems[parIdx].SetCompleted(e.NewValue == CheckState.Checked);
            }
            UpdatePercentBar();
        }

        private void UpdatePercentBar()
        {
            int compCount = 0;
            foreach (var item in todoItems)
            {
                if (item.DueDate.Date == Calendar.SelectionStart.Date && item.IsCompleted == true)
                {
                    compCount += 1;
                }
            }

            if (compCount > 0)
            {
                double percent = ((double)compCount / ListBox.Items.Count * 100);
                if (percent <= 100)
                {
                    PercentBar.Value = (int)percent;
                }
            }
            else
            {
                PercentBar.Value = 0;
            }

            lblCurrPercent.Text = $"{compCount} / {ListBox.Items.Count}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int parIdx = GetIndexOfItem(ListBox.SelectedIndex);
            if (parIdx >= 0)
            {
                todoItems.RemoveAt(parIdx);
                ListBox.Items.RemoveAt(ListBox.SelectedIndex);
                UpdatePercentBar();
            }

        }

        private int GetIndexOfItem(int childIdx)
        {
            int index = 0;
            for (int i = 0; i < todoItems.Count(); i++)
            {
                if (todoItems[i].DueDate.Date == Calendar.SelectionStart.Date)
                {
                    if (childIdx == index)
                    {
                        return i;
                    }
                    index++;
                }
            }
            return -1;
        }

        private void btnReSave_Click(object sender, EventArgs e)
        {
            int index = ListBox.SelectedIndex;
            int parIdx = GetIndexOfItem(index);

            if (parIdx < 0)
            {
                return;
            }

            TodoItem selectedItem = todoItems[parIdx];
            ToDoDetailForm detailForm = new ToDoDetailForm(selectedItem);
            DialogResult result = detailForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                TodoItem newItem = detailForm.TodoItem;
                if (newItem != null)
                {
                    todoItems[parIdx] = newItem;
                    ListBox.Items[index] = newItem.Title;
                    UpdatePercentBar();
                }
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = GetIndexOfItem(ListBox.SelectedIndex);
            if (index >= 0)
            {
                txtInfo.Text = todoItems[index].Contents;
            }
            else
            {
                txtInfo.Text = string.Empty;
            }
        }

        private void btnSetUp_Click(object sender, EventArgs e)
        {
            ToDoSetUp detailForm = new ToDoSetUp(todoItems);
            DialogResult result = detailForm.ShowDialog();
        }
    }

    public class TodoItem
    {
        public DateTime DueDate { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public bool IsCompleted { get; set; }
        public CategorySystem.Category Category { get; set; }

        public TodoItem()
        {
            DueDate = DateTime.Now;
            Title = string.Empty;
            Contents = string.Empty;
            IsCompleted = false;
            Category = new CategorySystem.Category("없음", "#000000");
        }
        public void SetCompleted(bool isCheck)
        {
            IsCompleted = isCheck;
        }
        public void SetCategory(string name)
        {
            Category = new CategorySystem.Category(name);
        }
    }
}
