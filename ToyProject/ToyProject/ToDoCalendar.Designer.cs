namespace ToyProject
{
    partial class TodoCalendar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Calendar = new MonthCalendar();
            ListBox = new CheckedListBox();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            lblCurrPercent = new Label();
            label2 = new Label();
            PercentBar = new ProgressBar();
            btnSave = new Button();
            btnDelete = new Button();
            btnReSave = new Button();
            btnSetUp = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Calendar
            // 
            Calendar.Location = new Point(10, 6);
            Calendar.MaxSelectionCount = 1;
            Calendar.Name = "Calendar";
            Calendar.TabIndex = 0;
            Calendar.DateChanged += Calendar_DateChanged;
            // 
            // ListBox
            // 
            ListBox.FormattingEnabled = true;
            ListBox.Location = new Point(10, 202);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(220, 166);
            ListBox.TabIndex = 1;
            ListBox.ItemCheck += ListBox_ItemCheck;
            ListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(98, 171);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(40, 25);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Location = new Point(236, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 362);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "세부내용";
            // 
            // txtInfo
            // 
            txtInfo.BackColor = SystemColors.Menu;
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(6, 22);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(194, 334);
            txtInfo.TabIndex = 0;
            // 
            // lblCurrPercent
            // 
            lblCurrPercent.AutoSize = true;
            lblCurrPercent.Location = new Point(196, 397);
            lblCurrPercent.Name = "lblCurrPercent";
            lblCurrPercent.Size = new Size(34, 15);
            lblCurrPercent.TabIndex = 2;
            lblCurrPercent.Text = "0 / 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 397);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "진행률  :";
            // 
            // PercentBar
            // 
            PercentBar.Location = new Point(36, 374);
            PercentBar.Name = "PercentBar";
            PercentBar.Size = new Size(194, 17);
            PercentBar.Style = ProgressBarStyle.Continuous;
            PercentBar.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(355, 374);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 36);
            btnSave.TabIndex = 6;
            btnSave.Text = "저장";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(190, 171);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(40, 25);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReSave
            // 
            btnReSave.Location = new Point(144, 171);
            btnReSave.Name = "btnReSave";
            btnReSave.Size = new Size(40, 25);
            btnReSave.TabIndex = 8;
            btnReSave.Text = "수정";
            btnReSave.UseVisualStyleBackColor = true;
            btnReSave.Click += btnReSave_Click;
            // 
            // btnSetUp
            // 
            btnSetUp.Location = new Point(264, 374);
            btnSetUp.Name = "btnSetUp";
            btnSetUp.Size = new Size(85, 36);
            btnSetUp.TabIndex = 9;
            btnSetUp.Text = "설정";
            btnSetUp.UseVisualStyleBackColor = true;
            btnSetUp.Click += btnSetUp_Click;
            // 
            // TodoCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 422);
            Controls.Add(btnSetUp);
            Controls.Add(lblCurrPercent);
            Controls.Add(label2);
            Controls.Add(btnReSave);
            Controls.Add(btnDelete);
            Controls.Add(PercentBar);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(btnAdd);
            Controls.Add(ListBox);
            Controls.Add(Calendar);
            Name = "TodoCalendar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TODO Calendar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar Calendar;
        private CheckedListBox ListBox;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Button btnSave;
        private PictureBox pictureBox1;
        private Label lblCurrPercent;
        private Label label2;
        private ProgressBar PercentBar;
        private Button btnDelete;
        private Button btnReSave;
        private TextBox txtInfo;
        private Button btnSetUp;
    }
}
