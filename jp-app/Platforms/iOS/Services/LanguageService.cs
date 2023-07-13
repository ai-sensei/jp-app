using Foundation;
using jp_app.Services;

namespace jp_app.Platforms.iOS.Services
{
    public class LanguageService : ILanguageService
    {
        public string GetSystemLanguage()
        {
            var language = NSLocale.PreferredLanguages[0];
            return language;
        }
    }
}