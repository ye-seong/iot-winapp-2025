namespace ToyProject.Properties
{
    partial class ToDoSetUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            btnSave = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnAdd = new Button();
            boxCategoryList = new CheckedListBox();
            groupBox2 = new GroupBox();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "글꼴 :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "a" });
            comboBox1.Location = new Point(54, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 54);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "모드 :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "화이트모드", "다크모드" });
            comboBox2.Location = new Point(54, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 23);
            comboBox2.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(409, 403);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 35);
            btnSave.TabIndex = 3;
            btnSave.Text = "저장";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.Location = new Point(305, 403);
            button2.Name = "button2";
            button2.Size = new Size(98, 35);
            button2.TabIndex = 4;
            button2.Text = "복구";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(boxCategoryList);
            groupBox1.Location = new Point(12, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 292);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "카테고리";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(86, 140);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(50, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(142, 140);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(50, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // boxCategoryList
            // 
            boxCategoryList.BackColor = SystemColors.ButtonHighlight;
            boxCategoryList.FormattingEnabled = true;
            boxCategoryList.Location = new Point(10, 22);
            boxCategoryList.Name = "boxCategoryList";
            boxCategoryList.Size = new Size(182, 112);
            boxCategoryList.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(202, 87);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "디자이너";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ToDoSetUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(btnSave);
            Name = "ToDoSetUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TODO SetUp";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Button btnSave;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private OpenFileDialog openFileDialog1;
        private CheckedListBox boxCategoryList;
        private Button btnDelete;
        private Button btnAdd;
    }
}