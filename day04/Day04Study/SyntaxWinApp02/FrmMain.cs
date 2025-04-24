namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // ������ DB���� �����ͷε� �� �Ʒ��� �۾����� ����
            // �迭 ����
            string[] fruits = { "���", "�ٳ���", "����", "����", "��纣��" };
            CboArray.Items.AddRange(fruits);   // �迭�� �޺��ڽ��� �Ҵ� 
            //CboArray.SelectedIndex = 0;

            // ����Ʈ ���� - ���� ��� ����̵� ��밡��
            List<string> lFruits = ["���", "����ƾ", "���ø���", "�ڸ�", "�θ���"];
            //List<string> lFruits = new List<string>();
            //lFruits.Add("���");
            //lFruits.Add("����ƾ");
            //lFruits.Add("���ø���");
            //lFruits.Add("�ڸ�");
            CboList.DataSource = lFruits;

            // ��ųʸ� ���� - DB �ڵ鸵�� ���� ���� ���Ǵ� ���
            Dictionary<string, string> dCountry = new Dictionary<string, string>()
            {
                { "KR", "���ѹα�" },
                { "US", "�̱�" },
                { "JP", "�Ϻ�" },
                { "CN", "�߱�" },
                { "IN", "�ε�" },
                { "PH", "�ʸ���" },
            };
            CboDictionary.DataSource = new BindingSource(dCountry, null);
            CboDictionary.DisplayMember = "Value"; // ����ڿ��� ���̴� �̸�
            CboDictionary.ValueMember = "Key";  // ���������� ���õǴ� ��

            // foreach�� �ݺ� ó��
            string result = "";
            foreach (var item in dCountry)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private void CboArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SelectedItem �� object?
            string selected = CboArray.SelectedItem.ToString();
            MessageBox.Show($"������ ������ {selected}�Դϴ�", "�����ϴ°���", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = CboList.SelectedItem.ToString();
            MessageBox.Show(selected, "���õȰ���", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CboDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kvp = (KeyValuePair<string, string>)CboDictionary.SelectedItem;
            string key = kvp.Key;
            string value = kvp.Value;

            MessageBox.Show($"���õ� Ű�� {key}, ���� {value}", "���õȱ���", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
