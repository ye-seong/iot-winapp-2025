namespace ToyProject
{
    partial class ToDoDetailForm
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
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtContents = new TextBox();
            btnSet = new Button();
            label3 = new Label();
            cobCategory = new ComboBox();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(83, 23);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(226, 23);
            txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 26);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "제목 : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 81);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "세부내용 :";
            // 
            // txtContents
            // 
            txtContents.Location = new Point(83, 81);
            txtContents.Multiline = true;
            txtContents.Name = "txtContents";
            txtContents.Size = new Size(226, 229);
            txtContents.TabIndex = 3;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(223, 316);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(86, 32);
            btnSet.TabIndex = 4;
            btnSet.Text = "적용";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 55);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 1;
            label3.Text = "카테고리 : ";
            // 
            // cobCategory
            // 
            cobCategory.FormattingEnabled = true;
            cobCategory.Items.AddRange(new object[] { "없음" });
            cobCategory.Location = new Point(83, 52);
            cobCategory.Name = "cobCategory";
            cobCategory.Size = new Size(226, 23);
            cobCategory.TabIndex = 5;
            cobCategory.SelectedIndexChanged += cobCategory_SelectedIndexChanged;
            // 
            // ToDoDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 363);
            Controls.Add(cobCategory);
            Controls.Add(btnSet);
            Controls.Add(txtContents);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Name = "ToDoDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TODO Calendar Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private TextBox txtContents;
        private Button btnSet;
        private Label label3;
        private ComboBox cobCategory;
    }
}