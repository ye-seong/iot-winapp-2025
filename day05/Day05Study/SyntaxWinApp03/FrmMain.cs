namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // async �񵿱�� �����ϴ� �޼����� ����
        // async, await�� �׻� ���� ���
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            // * : UI�����尡 ����
            LblCurrState.Text = "������� : ����"; // *
            BtnStart.Text = "������";              // *
            BtnStart.Enabled = false;              // *

            long MaxVal = 200;
            long total = 0;
            PrgProcess.Minimum = 0;                 // *
            PrgProcess.Maximum = 100;               // *

            // await�� �񵿱� ���
            await Task.Run(() =>
            {
                for (int i = 0; i < MaxVal; i++)
                {
                    total += i % 3;

                    int progress = (int)((i * 100) / MaxVal) + 1;
                    Console.WriteLine(progress.ToString());
                    // Task.Run �� ���� UIó�� ������
                    this.Invoke(new Action(() =>
                    {
                        TxtLog.Text += i.ToString() + "\r\n";
                        TxtLog.SelectionStart = TxtLog.Text.Length;
                        TxtLog.ScrollToCaret();  // ��ũ���� ���� ������
                        PrgProcess.Value = progress;        // *
                        // PrgProcess2.Value = progress;
                    }));

                    Thread.Sleep(50);
                    // Application.DoEvents(); // �� ����
                }
            });


            LblCurrState.Text = "������� : ����"; // *
            BtnStart.Text = "����";                // *
            BtnStart.Enabled = true;               // *
        }
    }
}
