using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.IO;

namespace jp_app
{
    public partial class FlashcardsPage : ContentPage
    {
        private List<Flashcard> flashcards;

        public FlashcardsPage()
        {
            InitializeComponent();
            LoadExampleWords();
        }

        private void OnStarClicked(object sender, EventArgs e)
        {
            // Handle star button click event
            // Save the starred flashcards to disk
            SaveStarredFlashcards();
        }

        private void LoadExampleWords()
        {
            // Load the example word file and create a list of flashcards
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExampleWords.txt");
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                flashcards = new List<Flashcard>();
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string word = parts[0].Trim();
                        string definition = parts[1].Trim();
                        flashcards.Add(new Flashcard(word, definition));
                    }
                }
            }
        }
        
        private void SaveStarredFlashcards()
        {
            // Save the starred flashcards to disk
            // Implement the logic to save the starred flashcards to disk
            // TODO: Implement the logic to save the starred flashcards to disk
            // For example, you can use the following code to save the flashcards to a file:
            // string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "StarredFlashcards.txt");
            // using (StreamWriter writer = new StreamWriter(filePath))
            // {
            //     foreach (Flashcard flashcard in flashcards)
            //     {
            //         if (flashcard.IsStarred)
            //         {
            //             writer.WriteLine($"{flashcard.Word}:{flashcard.Definition}");
            //         }
            //     }
            // }
        }
    }
}
