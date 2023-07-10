using Xamarin.Forms;
using System.IO;

namespace jp_app
{
    public partial class FlashcardsPage : ContentPage
    {
        public FlashcardsPage()
        {
            InitializeComponent();
            LoadExampleWords();
        }

        private void OnStarClicked(object sender, EventArgs e)
        {
            // Handle star button click event
        }

        private void LoadExampleWords()
        {
            string exampleWordsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "ExampleWords.txt");
            // Load example words from the file and create flashcards
            // Add your code here
        }
    }
}
