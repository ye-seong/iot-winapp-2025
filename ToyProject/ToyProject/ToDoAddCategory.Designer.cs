namespace ToyProject
{
    partial class ToDoAddCategory
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
            txtCategory = new TextBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(12, 12);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(212, 23);
            txtCategory.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(230, 11);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(57, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "확인";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // ToDoAddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 44);
            Controls.Add(btnOk);
            Controls.Add(txtCategory);
            Name = "ToDoAddCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategory;
        private Button btnOk;
    }
}