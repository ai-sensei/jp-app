using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace jp_app
{
    public partial class FlashcardPage : ContentPage
    {
        private List&lt;Flashcard&gt; flashcards;
        private int currentFlashcardIndex;

        public FlashcardPage()
        {
            InitializeComponent();

            flashcards = new List&lt;Flashcard&gt;();
            currentFlashcardIndex = 0;

            // TODO: Add flashcards to the list
        }

        private void OnPreviousButtonClicked(object sender, System.EventArgs e)
        {
            if (currentFlashcardIndex > 0)
            {
                currentFlashcardIndex--;
                BindingContext = flashcards[currentFlashcardIndex];
            }
        }

        private void OnNextButtonClicked(object sender, System.EventArgs e)
        {
            if (currentFlashcardIndex < flashcards.Count - 1)
            {
                currentFlashcardIndex++;
                BindingContext = flashcards[currentFlashcardIndex];
            }
        }
    }
}

