namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // �⺻ ������
            Person hugo = new Person();
            hugo.Name = TxtName.Text.Trim();
            hugo.Age = int.Parse(TxtAge.Text.Trim());
            
            hugo.Gender = char.Parse(TxtGender.Text.Trim());
            hugo.Phone = TxtPhone.Text.Trim();

            // �Ű����� ������
            Person ashely = new Person("�ֽ���", 42, 'F', "010-9839-7777");

            TxtResult.Text = hugo.ToString();
            hugo.GetUp();
            hugo.GoToSchool();
            
            // static�� ���� ��ü�� �������� ����
            Person.GetNumber();
        }
    }
}
