namespace SyntaxWinApp04
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
    

    private void BtnOk_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("���� �Է��ϼ���.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                LblResult.Text = "ó����� : ";
                TxtResult.Text = "���� ó���� ����";
            }    
        }
    }
}
