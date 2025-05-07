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
            boxText = new ComboBox();
            label2 = new Label();
            boxMode = new ComboBox();
            btnSettingSave = new Button();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnAdd = new Button();
            boxCategoryList = new CheckedListBox();
            groupBox2 = new GroupBox();
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
            // boxText
            // 
            boxText.FormattingEnabled = true;
            boxText.Items.AddRange(new object[] { "Microsoft Sans Serif", "Segoe UI", "Tahoma", "Arial", "Times New Roman", "Verdana", "Courier New", "Comic Sans MS", "Georgia", "Lucida Console", "Lucida Sans Unicode", "Palatino Linotype", "Trebuchet MS", "Calibri", "Cambria" });
            boxText.Location = new Point(54, 22);
            boxText.Name = "boxText";
            boxText.Size = new Size(138, 23);
            boxText.TabIndex = 1;
            boxText.SelectedIndexChanged += boxText_SelectedIndexChanged;
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
            // boxMode
            // 
            boxMode.FormattingEnabled = true;
            boxMode.Items.AddRange(new object[] { "화이트모드", "다크모드", "블루모드", "핑크모드" });
            boxMode.Location = new Point(54, 51);
            boxMode.Name = "boxMode";
            boxMode.Size = new Size(138, 23);
            boxMode.TabIndex = 1;
            boxMode.SelectedIndexChanged += boxMode_SelectedIndexChanged;
            // 
            // btnSettingSave
            // 
            btnSettingSave.Location = new Point(305, 403);
            btnSettingSave.Name = "btnSettingSave";
            btnSettingSave.Size = new Size(98, 35);
            btnSettingSave.TabIndex = 4;
            btnSettingSave.Text = "확인";
            btnSettingSave.UseVisualStyleBackColor = true;
            btnSettingSave.Click += btnSettingSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(boxCategoryList);
            groupBox1.Location = new Point(12, 204);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 190);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "카테고리";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(87, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(50, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(143, 158);
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
            boxCategoryList.Size = new Size(182, 130);
            boxCategoryList.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(boxMode);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(boxText);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(202, 186);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "디자이너";
            // 
            // ToDoSetUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSettingSave);
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
        private ComboBox boxText;
        private Label label2;
        private ComboBox boxMode;
        private Button btnSettingSave;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckedListBox boxCategoryList;
        private Button btnDelete;
        private Button btnAdd;
    }
}