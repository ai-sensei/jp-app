using Xamarin.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace jp_app
{
    public partial class FlashcardsPage : ContentPage
    {
        private List<Flashcard> flashcards;
        public FlashcardsPage()
        {
            InitializeComponent();
            var words = LoadWords();
            flashcards = words.Select(w => new Flashcard(w.Key, w.Value)).ToList();
        }
        private Dictionary<string, string> LoadWords()
        {
            var wordsJson = File.ReadAllText("Resources/ExampleWords.json");
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(wordsJson);
        }

        private void OnStarClicked(object sender, EventArgs e)
        {
            // Handle star button click event
        }
    }
}
