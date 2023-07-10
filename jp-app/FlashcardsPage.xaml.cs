using Xamarin.Forms;
using System.IO;
using Newtonsoft.Json;

namespace jp_app
{
    public partial class FlashcardsPage : ContentPage
    {
        private List<Flashcard> flashcards;
        private List<Flashcard> starredFlashcards;
        public FlashcardsPage()
        {
            InitializeComponent();
            LoadFlashcards();
        }
        private void LoadFlashcards()
        {
            // Read the Flashcards.json file
            var json = File.ReadAllText("Resources/Flashcards.json");
            // Parse the JSON and store the flashcards in a list
            flashcards = JsonConvert.DeserializeObject<List<Flashcard>>(json);
        }

        private void OnStarClicked(object sender, EventArgs e)
        {
            // Handle star button click event
        }
    }
}
