using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ToyProject.CategorySystem;
using static System.Windows.Forms.CheckedListBox;
using System.Globalization;
using System.Reflection;

namespace ToyProject.Properties
{
    public partial class ToDoSetUp : Form
    {
        private List<TodoItem> _todoItems;
        public List<TodoItem> TodoItem => _todoItems;
        private CategorySystem.CategoryManager _categoryManager;
        public ToDoSetUp(List<TodoItem>items)
        {
            InitializeComponent();
            GetCategory();
            _todoItems = items;
        }
        private void GetCategory()
        {
            if (_categoryManager == null)
            {
                _categoryManager = new CategorySystem.CategoryManager();
            }
            _categoryManager.LoadCategories();
            boxCategoryList.Items.Clear();
            foreach (var category in _categoryManager.GetCategoryName())
            {
                boxCategoryList.Items.Add(category);
            }
        }

        public class AppSettings
        {
            public List<CategorySystem.Category> Categories { get; set; } = new List<CategorySystem.Category>();
            public bool EnableReminders { get; set; } = true;
            public string DefaultView { get; set; } = "월별";
            public string ThemeName { get; set; } = "기본";
            public bool ShowCompletedTasks { get; set; } = true;
            // 기타 설정들...
        }

        // 설정 관리 클래스
        public class SettingsManager
        {
            private static SettingsManager _instance;
            private AppSettings _settings;
            private const string SettingsFile = "settings.json";

            // 싱글톤 인스턴스
            public static SettingsManager Instance
            {
                get
                {
                    if (_instance == null)
                        _instance = new SettingsManager();
                    return _instance;
                }
            }

            private SettingsManager()
            {
                LoadSettings();
            }

            // 설정 속성
            public AppSettings Settings => _settings;

            // 카테고리 접근용 속성
            public List<CategorySystem.Category> Categories => _settings.Categories;

            // 설정 저장
            public void SaveSettings()
            {
                string json = System.Text.Json.JsonSerializer.Serialize(_settings);
                File.WriteAllText(SettingsFile, json);
            }

            // 설정 로드
            private void LoadSettings()
            {
                if (File.Exists(SettingsFile))
                {
                    try
                    {
                        string json = File.ReadAllText(SettingsFile);
                        _settings = System.Text.Json.JsonSerializer.Deserialize<AppSettings>(json);
                    }
                    catch (Exception)
                    {
                        // 파일 로드 실패 시 기본 설정 사용
                        _settings = new AppSettings();
                    }
                }
                else
                {
                    // 파일이 없으면 기본 설정으로 시작
                    _settings = new AppSettings();

                    // 설정 파일 생성
                    SaveSettings();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (boxCategoryList.SelectedItem == null)
            {
                MessageBox.Show("삭제할 카테고리를 선택해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CheckedItemCollection items = boxCategoryList.CheckedItems;
            for (int i = items.Count - 1; i >= 0; i--)
            {
                if (items[i].ToString() == "없음")
                {
                    MessageBox.Show("기본 카테고리는 삭제할 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (GetItemsAsCategory(items[i].ToString()))
                {
                    DialogResult result = MessageBox.Show("현재 해당 카테고리를 사용하고 있습니다. 삭제하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    switch(result)
                    {
                        case DialogResult.Yes:
                            break;
                        case DialogResult.No:
                            return;
                        default:
                            return;
                    }
                    FindAndChangeCategory(items[i].ToString());
                }
                _categoryManager.Remove(items[i].ToString());
                boxCategoryList.Items.Remove(items[i]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SettingsManager.Instance.SaveSettings();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ToDoAddCategory CategoryForm = new ToDoAddCategory();
            DialogResult result = CategoryForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                List<Category> category = _categoryManager.GetCategories();
                GetCategory();
            }
        }

        private bool GetItemsAsCategory(string name)
        {
            foreach (var item in _todoItems)
            {
                if (item.Category.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        private void FindAndChangeCategory(string name)
        {
            foreach (var item in _todoItems)
            {
                if (item.Category.Name == name)
                {
                    item.Category = _categoryManager.GetByName("없음");
                }
            }
            TodoCalendar todoCalendar = new TodoCalendar();
        }
    }

}
