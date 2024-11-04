using System.ComponentModel;
using Roman;

namespace Roman
{
    public partial class MainPage : ContentPage
    {
        public string Convert(string input)
        {
            if (int.TryParse(input, out int number))
            {
                return Converter.NumberToRoman(number);
            }
            else
            {
                return Converter.RomanToNumber(input).ToString();
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Convert_OnClicked(object sender, EventArgs e)
        {
            string input = txtPreConvert.Text;

            string result = Convert(input);

            lblPostConvert.Text = result;
        }
    }
}