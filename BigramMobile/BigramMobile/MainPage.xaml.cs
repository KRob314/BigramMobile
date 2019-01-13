using BigramAndHistogram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BigramMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            BigramService bigramService = new BigramService();
            var words = bigramService.SplitWords(txtInput.Text);
            List<Bigram> bigrams = bigramService.GetSequence(words);

            lblOutput.Text = bigramService.GetOutput(bigrams);
        }
    }
}
