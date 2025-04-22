using SyntaxWinApp02.Properties;

namespace SyntaxWinApp02
{
    // sealed ���̻� �ڽ� Ŭ������ ����� ���� ������
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //Computer computer = new Computer();
            //Notebook notebook = new Notebook();
            //Server server = new Server();

            //Computer youCom = new Notebook();   // �θ�Ŭ������ �ڽ� ��ü�� �Ҵ�
            switch (CboDivision.SelectedIndex)
            {
                case 0: // Computer
                    Computer myCom = new Computer();
                    PicComputer.Image = Resources.laptop;

                    myCom.Reset();
                    myCom.ShutDown();
                    myCom.Boot();
                    break;

                case 1: // Notebook
                    Notebook myBook = new Notebook();
                    PicComputer.Image = Resources.laptop;

                    myBook.Reset();
                    myBook.ShutDown();  // �θ�� �ٸ��� ����

                    //Computer sCom = myBook;
                    // �θ�Ŭ������ �ڽ�Ŭ������ ����ȯ�ϸ鼭 �����߻� ����
                    //Notebook myBook2 = (Notebook)new Computer();
                    Computer myComputer = new Notebook();

                    if (myComputer is Notebook)
                    {
                        Console.WriteLine("myComputer�� Notebook�Դϴ�.");
                        Notebook myBook2 = myComputer as Notebook;
                        Console.WriteLine("MyComputer�� Notebook���� ����!");
                    }

                    // �����ν�Ȯ��
                    bool hasFinger = myBook.HasFingerScanDevice();
                    Console.WriteLine($"���������νĿ��� : {hasFinger}");
                    // �޼��� �����ε�
                    hasFinger = myBook.HasFingerScanDevice(true);
                    Console.WriteLine($"���������νĿ��� : {hasFinger}");
                    break;

                case 2: // Server
                    Server yourServ = new Server();
                    PicComputer.Image = Resources.server;
                    break;

                default:
                    break;
            }
        }

        private void CboDivision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Server server1 = new Server();
            server1.Name = "HP����";

            Server server2 = server1;   // ���� ���� : ���� ���� ����
            server2.Name = "DELL����";

            bool isSame = server1.Equals(server2);
            Console.WriteLine(isSame);

            MessageBox.Show($"{server1.Name}\r\n{server2.Name}", "������");

            Server server3 = server1.DeepCopy();
            server3.Name = "INTEL����";

            isSame = server2.Equals(server3);
            Console.WriteLine(isSame);

            MessageBox.Show($"{server1.Name}\r\n{server3.Name}", "������");

        }
    }
}
