using Xamarin.Forms;

namespace jp_app
{
    public partial class FlashcardsPage : ContentPage
    {
        private Dictionary<string, string> words;
        public FlashcardsPage()
        {
            InitializeComponent();
            words = LoadWords();
            CreateFlashcards(words);
        }
        private Dictionary<string, string> LoadWords()
        {
            var json = File.ReadAllText("Resources/ExampleWords.json");
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
        private void CreateFlashcards(Dictionary<string, string> words)
        {
            // Code to create flashcards from words
        }

        private void OnStarClicked(object sender, EventArgs e)
        {
            // Handle star button click event
        }
    }
}
