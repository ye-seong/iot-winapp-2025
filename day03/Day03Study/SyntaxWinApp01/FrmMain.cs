namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            // �⺻ ������
            Person jys = new Person();
            jys.Name = TxtName.Text.Trim();
            jys.Age = int.Parse(TxtAge.Text.Trim());
            jys.Gender = char.Parse(TxtGender.Text.Trim());
            jys.Phone = TxtPhone.Text.Trim();

            // �Ű����� ������
            Person kju = new Person("���ؿ�", 30, 'M', "010-9876-5432");

            TxtResult.Text += jys.ToString();
            jys.GetUp();
            jys.GoToSchool();

            // static�� ���� ��ü�� �������� ����
            Person.GetNumber();
        }
    }
}
