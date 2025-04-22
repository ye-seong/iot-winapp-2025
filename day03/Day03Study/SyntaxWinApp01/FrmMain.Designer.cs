namespace SyntaxWinApp01
{
    partial class FrmMain
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
            groupBox1 = new GroupBox();
            TxtPhone = new TextBox();
            label3 = new Label();
            TxtGender = new TextBox();
            label2 = new Label();
            TxtAge = new TextBox();
            label1 = new Label();
            TxtName = new TextBox();
            LblName = new Label();
            BtnOk = new Button();
            TxtResult = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtPhone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtGender);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtAge);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(LblName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "사람 정보 입력";
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(75, 115);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(150, 23);
            TxtPhone.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 118);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 6;
            label3.Text = "핸드폰 :";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtGender
            // 
            TxtGender.Location = new Point(75, 86);
            TxtGender.Name = "TxtGender";
            TxtGender.Size = new Size(150, 23);
            TxtGender.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 89);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "성별 :";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(75, 57);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(150, 23);
            TxtAge.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 60);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "나이 :";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(75, 28);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(150, 23);
            TxtName.TabIndex = 1;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(29, 31);
            LblName.Name = "LblName";
            LblName.Size = new Size(38, 15);
            LblName.TabIndex = 0;
            LblName.Text = "이름 :";
            LblName.TextAlign = ContentAlignment.TopRight;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(472, 259);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(100, 40);
            BtnOk.TabIndex = 6;
            BtnOk.Text = "확인";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(313, 40);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.ReadOnly = true;
            TxtResult.Size = new Size(259, 213);
            TxtResult.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(313, 22);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 0;
            label5.Text = "결과";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(TxtResult);
            Controls.Add(BtnOk);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법학습 윈앱1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnOk;
        private TextBox TxtPhone;
        private Label label3;
        private TextBox TxtGender;
        private Label label2;
        private TextBox TxtAge;
        private Label label1;
        private TextBox TxtName;
        private Label LblName;
        private TextBox TxtResult;
        private Label label5;
    }
}
