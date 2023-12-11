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

        // メンバ変数の宣言
        Dictionary<string, string> cityNames;

        public Form1()
        {
            InitializeComponent();


            // 都道府県の辞書を作成する
            var cityNames = new Dictionary<string, string>();

            cityNames.Add("静岡県", "１");
            cityNames.Add("東京都", "２");
            cityNames.Add("千葉県", "３");
            cityNames.Add("広島県", "４");


            // コンボボックスに都道府県を表示させる
            foreach (KeyValuePair<string,string> data in cityNames)
            {
                areaBox.Items.Add(data.Key);
            }
        }


        private void CitySelected(object sender, EventArgs e)
        {
            // 天気情報サービスにアクセスする（著者が作成したダミーの情報です）

            string cityCode = cityNames[areaBox.Text];
            string url =
                "https://and-idea.sbcr.jp/sp/90261/weatherCheck.php?city=" +
                cityCode;

            HttpClient client = new HttpClient();
            string result = client.GetStringAsync(url).Result;


        }
    }
}