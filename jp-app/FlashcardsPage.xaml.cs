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
            // Load the example words and definitions from the JSON file
            var wordsAndDefinitions = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("Resources/ExampleWords.json"));
            // Create the list of flashcards
            flashcards = wordsAndDefinitions.Select(kvp => new Flashcard(kvp.Key, kvp.Value)).ToList();
        }

        private void OnStarClicked(object sender, EventArgs e)
        {
            // Handle star button click event
        }
    }
}
