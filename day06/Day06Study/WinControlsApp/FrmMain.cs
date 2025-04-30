namespace WinControlsApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // OS ��ü ��Ʈ ��������
            var Fonts = FontFamily.Families;
            //CboFonts.Items.AddRange(Fonts);
            foreach (var Font in Fonts)
            {
                CboFonts.Items.Add(Font.Name);
            }

            LblState.Text = "���� : ��Ʈ�б� �Ϸ�";

            toolTip1.SetToolTip(BtnModal, "���â ���� ��ư�Դϴ�.");
            toolTip1.SetToolTip(TxtYear, "�޷� ���� �⵵ ǥ�� �ؽ�Ʈ�ڽ��Դϴ�.");

        }

        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChangeFont()
        {
            if (CboFonts.SelectedIndex < 0) return; // ��Ʈ�� ���þ��� ���

            FontStyle style = FontStyle.Regular; // 0 ��ſ� Regular

            if (ChkBold.Checked) style |= FontStyle.Bold;  // FontStyle.Regular | FontStyle.Bold  => 0000 | 0001 = 0001
            if (ChkItalic.Checked) style |= FontStyle.Italic; // 0001 | 0010 => 0011

            // CboFonts���� ���õ� ���ڷ�, ����ũ��12, ����ü ��Ÿ�� ����
            TxtResult.Font = new Font((string)CboFonts.SelectedItem, 12, style);
        }

        private void TrbProcess_Scroll(object sender, EventArgs e)
        {
            PrgProcess.Value = TrbProcess.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frmModal = new Form();
            frmModal.Text = "���â";
            frmModal.Width = 300;
            frmModal.Height = 100;
            frmModal.BackColor = Color.Red;
            frmModal.StartPosition = FormStartPosition.CenterParent; // �θ�â�� ���߾�
            frmModal.ShowDialog(); // ���â ����
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            // �θ�â�� ���谡 ����
            Form frmModaless = new Form();
            frmModaless.Text = "��޸���â";
            frmModaless.Width = 300;
            frmModaless.Height = 100;
            frmModaless.BackColor = Color.Green;
            frmModaless.StartPosition = FormStartPosition.Manual;
            // ��޸���â�� ���âó�� ����â ���߾ӿ� ��ġ�Ϸ��� ����ʿ�
            frmModaless.Location = new Point(this.Location.X + (this.Width - frmModaless.Width) / 2,
                                             this.Location.Y + (this.Height - frmModaless.Height) / 2);
            frmModaless.Show(this); // ��޸���â ����
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            // �޽����ڽ� -> ���â
            MessageBox.Show(TxtResult.Text, "�ؽ�Ʈ�ڽ�����",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnRoot_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            TrvDummy.Nodes.Add(rand.Next().ToString());
            TreeToList();
        }

        private void BtnNode_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("��带 �����ϼ���.", "���", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(rand.Next().ToString());
            TrvDummy.SelectedNode.Expand(); // Ʈ��Ȯ�� Expand, Ʈ����� Collapse
            TreeToList();
        }

        private void TreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                TreeToList(node);
            }
        }

        private void TreeToList(TreeNode node)
        {
            ListViewItem item = new ListViewItem(new String[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() });
            item.ImageIndex = 0; // �������� �̹����ε����� ����
            LsvDummy.Items.Add(item);

            foreach (TreeNode subNode in node.Nodes)
            {
                TreeToList(subNode); // ���ȣ��(Recursive Call)
            }

        }

        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "�̹��� ����";
            DlgOpenImage.FileName = "";
            DlgOpenImage.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            if (DlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                PicImage.Image = Bitmap.FromFile(DlgOpenImage.FileName);
                PicImage.SizeMode = PictureBoxSizeMode.Zoom; //PictureBoxSizeMode.Zoom �̹��� ������� �� �� �ִ� ���
                // PictureBoxSizeMode.StretchImage �̹����� ����,���̸� ��ó�ڽ�ũ�⿡ ���缭 �̹����� �ϱ׷���
            }
        }

        private void CalSchedule_DateChanged(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show(CalSchedule.SelectionStart.ToString());
            TxtYear.Text = CalSchedule.SelectionStart.Year.ToString();
            TxtMonth.Text = CalSchedule.SelectionStart.Month.ToString();
            TxtDay.Text = CalSchedule.SelectionStart.Day.ToString();
        }

        private void DtpBirth_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(DtpBirth.Value.ToString(), "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DtpBirth.Value.ToString(), "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�����Ͻðڽ��ϱ�?", "���Ῡ��",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.FormClosing -= FrmMain_FormClosing; // ��Ŭ��¡ �̺�Ʈ�� ����
                Application.Exit(); // ���α׷� ���� ����
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("�����Ͻðڽ��ϱ�?", "���Ῡ��",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; // ���Ḧ �Ƚ�Ű�� ��
            }
        }

        private void LblUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.naver.com",
                UseShellExecute = true,
            });
        }
    }
}
