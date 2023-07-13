using Android.Content.Res;
using Android.OS;
using jp_app.Services;

namespace jp_app.Platforms.Android.Services
{
    public class LanguageService : ILanguageService
    {
        public string GetSystemLanguage()
        {
            var locale = Resources.System.Configuration.Locale;
            return locale.ToString();
        }
    }
}