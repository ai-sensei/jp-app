using Xamarin.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace jp_app
{
    public partial class FlashcardsPage : ContentPage
    {
        private List<Flashcard> flashcards;
        private List<Flashcard> starredFlashcards;

        public FlashcardsPage()
        {
            InitializeComponent();

            var json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Resources/Flashcards.json"));
            flashcards = JsonConvert.DeserializeObject<List<Flashcard>>(json);
            starredFlashcards = new List<Flashcard>();
        }

        private void OnStarClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var flashcard = button.BindingContext as Flashcard;

            starredFlashcards.Add(flashcard);

            var starredJson = JsonConvert.SerializeObject(starredFlashcards);
            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "StarredFlashcards.json"), starredJson);
        }
    }
}
