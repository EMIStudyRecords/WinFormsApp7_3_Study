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

        // ƒƒ“ƒo•Ï”‚ÌéŒ¾
        Dictionary<string, string> cityNames;

        public Form1()
        {
            InitializeComponent();


            // “s“¹•{Œ§‚Ì«‘‚ğì¬‚·‚é
            var cityNames = new Dictionary<string, string>();

            cityNames.Add("Ã‰ªŒ§", "‚P");
            cityNames.Add("“Œ‹“s", "‚Q");
            cityNames.Add("ç—tŒ§", "‚R");
            cityNames.Add("L“‡Œ§", "‚S");


            // ƒRƒ“ƒ{ƒ{ƒbƒNƒX‚É“s“¹•{Œ§‚ğ•\¦‚³‚¹‚é
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