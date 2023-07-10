using Xamarin.Forms;

namespace jp_app
{
    public partial class FlashcardsPage : ContentPage
    {
public partial class FlashcardsPage : ContentPage
{
    private List<Flashcard> flashcards;

    public FlashcardsPage()
    {
        InitializeComponent();

        // Load the example words from the JSON file
        var exampleWords = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("Resources/ExampleWords.json"));

        // Create a list of flashcard objects
        flashcards = exampleWords.Select(word => new Flashcard { Word = word.Key, Definition = word.Value }).ToList();
    }

    private void OnStarClicked(object sender, EventArgs e)
    {
        // Get the flashcard that was clicked
        var flashcard = (Flashcard)sender;

        // Toggle the starred property
        flashcard.IsStarred = !flashcard.IsStarred;

        // Save the starred flashcards to disk
        File.WriteAllText("StarredFlashcards.json", JsonConvert.SerializeObject(flashcards.Where(f => f.IsStarred)));
    }
}
    }
}
