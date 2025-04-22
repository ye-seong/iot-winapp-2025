namespace SyntaxWinApp02
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            BtnCheck = new Button();
            ImgFrm = new ImageList(components);
            label1 = new Label();
            PicComputer = new PictureBox();
            CboDivision = new ComboBox();
            BtnCopy = new Button();
            ((System.ComponentModel.ISupportInitialize)PicComputer).BeginInit();
            SuspendLayout();
            // 
            // BtnCheck
            // 
            BtnCheck.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCheck.ImageKey = "Check.png";
            BtnCheck.ImageList = ImgFrm;
            BtnCheck.Location = new Point(472, 259);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(100, 40);
            BtnCheck.TabIndex = 0;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // ImgFrm
            // 
            ImgFrm.ColorDepth = ColorDepth.Depth32Bit;
            ImgFrm.ImageStream = (ImageListStreamer)resources.GetObject("ImgFrm.ImageStream");
            ImgFrm.TransparentColor = Color.Transparent;
            ImgFrm.Images.SetKeyName(0, "Check.png");
            ImgFrm.Images.SetKeyName(1, "Plus.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(407, 15);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "종류 :";
            // 
            // PicComputer
            // 
            PicComputer.BackColor = SystemColors.ControlLight;
            PicComputer.Location = new Point(12, 12);
            PicComputer.Name = "PicComputer";
            PicComputer.Size = new Size(280, 280);
            PicComputer.SizeMode = PictureBoxSizeMode.StretchImage;
            PicComputer.TabIndex = 3;
            PicComputer.TabStop = false;
            // 
            // CboDivision
            // 
            CboDivision.FormattingEnabled = true;
            CboDivision.Items.AddRange(new object[] { "Computer", "Notebook", "Server" });
            CboDivision.Location = new Point(451, 12);
            CboDivision.Name = "CboDivision";
            CboDivision.Size = new Size(121, 23);
            CboDivision.TabIndex = 4;
            // 
            // BtnCopy
            // 
            BtnCopy.BackgroundImageLayout = ImageLayout.Center;
            BtnCopy.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCopy.ImageKey = "Plus.png";
            BtnCopy.ImageList = ImgFrm;
            BtnCopy.Location = new Point(366, 259);
            BtnCopy.Name = "BtnCopy";
            BtnCopy.Size = new Size(100, 40);
            BtnCopy.TabIndex = 5;
            BtnCopy.Text = "복사";
            BtnCopy.UseVisualStyleBackColor = true;
            BtnCopy.Click += BtnCopy_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(BtnCopy);
            Controls.Add(CboDivision);
            Controls.Add(PicComputer);
            Controls.Add(label1);
            Controls.Add(BtnCheck);
            Name = "FrmMain";
            Text = "문법학습 윈앱02";
            ((System.ComponentModel.ISupportInitialize)PicComputer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCheck;
        private ImageList ImgFrm;
        private Label label1;
        private PictureBox PicComputer;
        private ComboBox CboDivision;
        private Button BtnCopy;
    }
}
