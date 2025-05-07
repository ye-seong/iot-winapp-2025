using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToyProject
{
    public class CategorySystem
    {
        public class Category
        {
            public string Name { get; set; }
            public string Color { get; set; }

            public Category(string name, string color = "#000000")
            {
                Name = name;
                Color = color;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public class CategoryManager
        {
            private List<Category> _categories;
            public bool IsAdd = false;

            public CategoryManager()
            {
                _categories = new List<Category>();
                AddDefaultCategories();
            }

            private void AddDefaultCategories()
            {
                LoadCategories();
            }

            public void Add(string name, string color = "#000000")
            {
                if (_categories.Any(category => category.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show($"{name}은 이미 존재하는 카테고리 입니다.");
                    IsAdd = false;
                    return;
                }

                var category = new Category(name, color);
                _categories.Add(category);
                IsAdd = true;
                SaveCategories();
            }

            public bool Remove(string name)
            {
                var category = _categories.FirstOrDefault(c =>
                    c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (category != null)
                {
                    _categories.Remove(category);
                    SaveCategories();
                    return true;
                }
                return false;
            }

            public List<Category> GetCategories()
            {
                return _categories;
            }

            public Category GetByName(string name)
            {
                return _categories.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            }

            // 카테고리 저장 (JSON 파일 사용)
            private void SaveCategories()
            {
                string json = System.Text.Json.JsonSerializer.Serialize(_categories);

                File.WriteAllText("categories.json", json);
            }

            // 카테고리 불러오기
            public void LoadCategories()
            {
                if (File.Exists("categories.json"))
                {
                    string json = File.ReadAllText("categories.json");
                    var loadedCategories = System.Text.Json.JsonSerializer.Deserialize<List<Category>>(json);

                    if (loadedCategories != null && loadedCategories.Count > 0)
                    {
                        _categories = loadedCategories;
                    }
                }
            }

            public List<String> GetCategoryName()
            {
                return _categories.Select(c => c.Name).ToList();
            }

            public int GetCategoryIndex(string name)
            {
                foreach (var category in _categories)
                {
                    if (category.Name == name)
                    {
                        return _categories.IndexOf(category);
                    }
                }
                return -1;
            }
        }
    }
}