namespace WinFormsApp7_3
{
    public partial class Form1 : Form
    {

        //
        Dictionary<string, string> cityNames;

        public Form1()
        {
            InitializeComponent();


            // �s���{���̎������쐬����
            this.cityNames = new Dictionary<string, string>();

            this.cityNames.Add("�É���","�P");
            this.cityNames.Add("�����s","�Q");
            this.cityNames.Add("��t��","�R");
            this.cityNames.Add("�L����","�S");

        }

        private void CitySelected(object sender, EventArgs e)
        {

        }
    }
}