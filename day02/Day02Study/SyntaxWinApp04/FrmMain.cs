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
                MessageBox.Show("값을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                LblResult.Text = "처리결과 : ";
                TxtResult.Text = "뭔가 처리될 예정";
            }    
        }
    }
}
