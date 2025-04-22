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
            // 기본 생성자
            Person jys = new Person();
            jys.Name = TxtName.Text.Trim();
            jys.Age = int.Parse(TxtAge.Text.Trim());
            jys.Gender = char.Parse(TxtGender.Text.Trim());
            jys.Phone = TxtPhone.Text.Trim();

            // 매개변수 생성자
            Person kju = new Person("김준우", 30, 'M', "010-9876-5432");

            TxtResult.Text += jys.ToString();
            jys.GetUp();
            jys.GoToSchool();

            // static일 경우는 객체를 생성하지 않음
            Person.GetNumber();
        }
    }
}
