namespace jp_app
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnFlashcardsClicked(object sender, EventArgs e)
        {
            // Navigate to the Flashcards page
            Navigation.PushAsync(new FlashcardsPage());

            // Save the starred flashcards to disk
            // Add your code here
        }
    }
}
