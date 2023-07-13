using System.Globalization;
using jp_app.Services;

namespace jp_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Get the user's system language
            ILanguageService languageService = new LanguageService();
            string systemLanguage = languageService.GetSystemLanguage();

            // Set the application's culture to the system language
            CultureInfo culture = new CultureInfo(systemLanguage);
            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;

            MainPage = new AppShell();
        }
    }
}
