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
using Newtonsoft.Json.Linq;


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

            cityNames.Add("�É���", "1");
            cityNames.Add("�����s", "2");
            cityNames.Add("��t��", "3");
            cityNames.Add("�L����", "4");


            // �R���{�{�b�N�X�ɓs���{����\��������
            foreach (KeyValuePair<string,string> data in cityNames)
            {
                areaBox.Items.Add(data.Key);
            }
        }


        private void CitySelected(object sender, EventArgs e)
        {
            // �V�C���T�[�r�X�ɃA�N�Z�X����i���҂��쐬�����_�~�[�̏��ł��j

            string cityCode = cityNames[areaBox.Text];
            string url =
                "https://and-idea.sbcr.jp/sp/90261/weatherCheck.php?city=" +
                cityCode;

            HttpClient client = new HttpClient();
            string result = client.GetStringAsync(url).Result;


            // �V�C��񂩂�A�C�R����URL�����o��

            JObject jobj = JObject.Parse(result);
            string todayWeatherIcon = (string)((jobj["url"] as JValue).Value);
            weatherIcon.ImageLocation = todayWeatherIcon;

        }
    }
}