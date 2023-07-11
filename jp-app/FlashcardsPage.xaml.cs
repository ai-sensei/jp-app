using Xamarin.Forms;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace jp_app
{
    public partial class FlashcardsPage : ContentPage
    {
        private List<Flashcard> flashcards;

        public FlashcardsPage()
        {
            InitializeComponent();

            // Load the example words from the Flashcards.json file
            var words = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("Resources/Flashcards.json"));

            // Create a list of flashcards
            flashcards = words.Select(word => new Flashcard { Word = word.Key, Definition = word.Value }).ToList();
        }

        private void OnStarClicked(object sender, EventArgs e)
        {
            // Get the clicked flashcard
            var flashcard = (Flashcard)sender;

            // Add the starred flashcard to the StarredFlashcards.json file
            var starredFlashcards = JsonConvert.DeserializeObject<List<Flashcard>>(File.ReadAllText("Resources/StarredFlashcards.json"));
            starredFlashcards.Add(flashcard);
            File.WriteAllText("Resources/StarredFlashcards.json", JsonConvert.SerializeObject(starredFlashcards));
        }
    }
}
