using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;


namespace WinFormsApp7_3
{
    public partial class Form1 : Form
    {

        // �����o�ϐ��̐錾
        Dictionary<string, string> cityNames;

        public Form1()
        {
            InitializeComponent();


            // �s���{���̎������쐬����
            var cityNames = new Dictionary<string, string>();

            cityNames.Add("�É���", "�P");
            cityNames.Add("�����s", "�Q");
            cityNames.Add("��t��", "�R");
            cityNames.Add("�L����", "�S");


            // �R���{�{�b�N�X�ɓs���{����\��������
            foreach (KeyValuePair<string,string> data in cityNames)
            {
                areaBox.Items.Add(data.Key);
            }
        }


        private void CitySelected(object sender, EventArgs e)
        {

        }
    }
}