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
using static System.Net.Mime.MediaTypeNames;


namespace WinFormsApp7_3
{
    public partial class Form1 : Form
    {

        // メンバ変数の宣言
        Dictionary<string, string> cityNames;

        public Form1()
        {
            InitializeComponent();


            cityNames = new Dictionary<string, string>();

            cityNames.Add("静岡県", "1");
            cityNames.Add("東京都", "2");
            cityNames.Add("千葉県", "3");
            cityNames.Add("広島県", "4");


            // コンボボックスに都道府県を表示させる
            foreach (KeyValuePair<string, string> data in cityNames)
            {
                areaBox.Items.Add(data.Key);
            }

        }

        private void CitySelected(object sender, EventArgs e)
        {
            // 天気情報サービスにアクセスする（著者が作成したダミーの情報です）


            string cityCode = cityNames[areaBox.Text];

            string url = "https://and-idea.sbcr.jp/sp/90261/weatherCheck.php?city=" +
                          cityCode;

            HttpClient client = new HttpClient();
            string result = client.GetStringAsync(url).Result;


            // 天気情報からアイコンのURLを取り出す

            JObject jobj = JObject.Parse(result);
            string todayWeatherIcon = (string)((jobj["url"] as JValue).Value);
            weatherIcon.ImageLocation = todayWeatherIcon;


        }

        private void ExitMenuClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}