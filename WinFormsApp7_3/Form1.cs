namespace WinFormsApp7_3
{
    public partial class Form1 : Form
    {

        //
        Dictionary<string, string> cityNames;

        public Form1()
        {
            InitializeComponent();


            // “s“¹•{Œ§‚Ì«‘‚ğì¬‚·‚é
            this.cityNames = new Dictionary<string, string>();

            this.cityNames.Add("Ã‰ªŒ§", "‚P");
            this.cityNames.Add("“Œ‹“s", "‚Q");
            this.cityNames.Add("ç—tŒ§", "‚R");
            this.cityNames.Add("L“‡Œ§", "‚S");


            // ƒRƒ“ƒ{ƒ{ƒbƒNƒX‚É“s“¹•{Œ§‚ğ•\¦‚³‚¹‚é
            foreach (KeyValuePair<string,string> data in this.cityNames)
            {
                areaBox.Items.Add(data.Key);
            }
        }


        private void CitySelected(object sender, EventArgs e)
        {

        }
    }
}