namespace SyntaxWinApp04
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
            LblName = new Label();
            TxtName = new TextBox();
            LblAge = new Label();
            TxtAge = new TextBox();
            LblGender = new Label();
            RdoMale = new RadioButton();
            RdoFemale = new RadioButton();
            BtnOk = new Button();
            LblResult = new Label();
            TxtResult = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(12, 15);
            LblName.Name = "LblName";
            LblName.Size = new Size(62, 15);
            LblName.TabIndex = 0;
            LblName.Text = "이름입력 :";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(80, 12);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(152, 23);
            TxtName.TabIndex = 1;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(12, 44);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(62, 15);
            LblAge.TabIndex = 0;
            LblAge.Text = "생년월일 :";
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(80, 41);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(152, 23);
            TxtAge.TabIndex = 2;
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Location = new Point(12, 73);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(62, 15);
            LblGender.TabIndex = 0;
            LblGender.Text = "성별입력 :";
            // 
            // RdoMale
            // 
            RdoMale.AutoSize = true;
            RdoMale.Checked = true;
            RdoMale.Location = new Point(80, 71);
            RdoMale.Name = "RdoMale";
            RdoMale.Size = new Size(49, 19);
            RdoMale.TabIndex = 3;
            RdoMale.TabStop = true;
            RdoMale.Text = "남성";
            RdoMale.UseVisualStyleBackColor = true;
            // 
            // RdoFemale
            // 
            RdoFemale.AutoSize = true;
            RdoFemale.Location = new Point(135, 71);
            RdoFemale.Name = "RdoFemale";
            RdoFemale.Size = new Size(49, 19);
            RdoFemale.TabIndex = 4;
            RdoFemale.Text = "여성";
            RdoFemale.UseVisualStyleBackColor = true;
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
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(12, 136);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(62, 15);
            LblResult.TabIndex = 0;
            LblResult.Text = "결      과 :";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(80, 133);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(492, 23);
            TxtResult.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(80, 12);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(152, 23);
            maskedTextBox1.TabIndex = 1;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(80, 41);
            maskedTextBox2.Mask = "0000-00-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(152, 23);
            maskedTextBox2.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(BtnOk);
            Controls.Add(RdoFemale);
            Controls.Add(RdoMale);
            Controls.Add(LblGender);
            Controls.Add(TxtResult);
            Controls.Add(LblResult);
            Controls.Add(TxtAge);
            Controls.Add(LblAge);
            Controls.Add(TxtName);
            Controls.Add(LblName);
            Name = "FrmMain";
            Text = "문법연습 윈앱04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox TxtName;
        private Label LblAge;
        private TextBox TxtAge;
        private Label LblGender;
        private RadioButton RdoMale;
        private RadioButton RdoFemale;
        private Button BtnOk;
        private Label LblResult;
        private TextBox TxtResult;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
    }
}
