namespace SyntaxWinApp03
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
            BtnMsg = new Button();
            LblPain = new Label();
            TxtPain = new TextBox();
            LblPain2 = new Label();
            CboPainPoint = new ComboBox();
            TxtResult = new TextBox();
            BtnDisplay = new Button();
            BtnWhile = new Button();
            SuspendLayout();
            // 
            // BtnMsg
            // 
            BtnMsg.Location = new Point(472, 259);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(100, 40);
            BtnMsg.TabIndex = 6;
            BtnMsg.Text = "메시지";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // LblPain
            // 
            LblPain.AutoSize = true;
            LblPain.Location = new Point(12, 9);
            LblPain.Name = "LblPain";
            LblPain.Size = new Size(64, 15);
            LblPain.TabIndex = 1;
            LblPain.Text = "통증여부 -";
            // 
            // TxtPain
            // 
            TxtPain.Location = new Point(82, 6);
            TxtPain.MaxLength = 3;
            TxtPain.Name = "TxtPain";
            TxtPain.PlaceholderText = "네 또는 아니오";
            TxtPain.Size = new Size(100, 23);
            TxtPain.TabIndex = 1;
            TxtPain.KeyPress += TxtPain_KeyPress;
            // 
            // LblPain2
            // 
            LblPain2.AutoSize = true;
            LblPain2.Location = new Point(12, 36);
            LblPain2.Name = "LblPain2";
            LblPain2.Size = new Size(64, 15);
            LblPain2.TabIndex = 3;
            LblPain2.Text = "통증부위 -";
            // 
            // CboPainPoint
            // 
            CboPainPoint.FormattingEnabled = true;
            CboPainPoint.Items.AddRange(new object[] { "머리", "눈", "코", "목", "가슴", "배" });
            CboPainPoint.Location = new Point(82, 33);
            CboPainPoint.Name = "CboPainPoint";
            CboPainPoint.Size = new Size(121, 23);
            CboPainPoint.TabIndex = 2;
            CboPainPoint.Text = "부위선택";
            CboPainPoint.SelectedIndexChanged += CboPainPoint_SelectedIndexChanged;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(12, 62);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(560, 191);
            TxtResult.TabIndex = 3;
            // 
            // BtnDisplay
            // 
            BtnDisplay.Location = new Point(366, 259);
            BtnDisplay.Name = "BtnDisplay";
            BtnDisplay.Size = new Size(100, 40);
            BtnDisplay.TabIndex = 5;
            BtnDisplay.Text = "구구단";
            BtnDisplay.UseVisualStyleBackColor = true;
            BtnDisplay.Click += BtnDisplay_Click;
            // 
            // BtnWhile
            // 
            BtnWhile.Location = new Point(260, 259);
            BtnWhile.Name = "BtnWhile";
            BtnWhile.Size = new Size(100, 40);
            BtnWhile.TabIndex = 4;
            BtnWhile.Text = "반복";
            BtnWhile.UseVisualStyleBackColor = true;
            BtnWhile.Click += BtnWhile_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(BtnWhile);
            Controls.Add(BtnDisplay);
            Controls.Add(TxtResult);
            Controls.Add(CboPainPoint);
            Controls.Add(LblPain2);
            Controls.Add(TxtPain);
            Controls.Add(LblPain);
            Controls.Add(BtnMsg);
            Name = "FrmMain";
            Text = "문법학습 윈앱03";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMsg;
        private Label LblPain;
        private TextBox TxtPain;
        private Label LblPain2;
        private ComboBox CboPainPoint;
        private TextBox TxtResult;
        private Button BtnDisplay;
        private Button BtnWhile;
    }
}
