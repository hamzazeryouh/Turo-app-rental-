namespace Turo.Application.Helpers
{
    using System.Collections.Generic;

    public static class TranslationDictionary
    {
        public static readonly Dictionary<string, Dictionary<string, string>> Translations =
            new Dictionary<string, Dictionary<string, string>>
            {
            {
                "en", new Dictionary<string, string>
                {
                    { "Success", "Request successful." },
                    { "Error", "Request failed." },
                    { "UserNotFound", "User not found." },
                    { "Welcome", "Welcome to our API!" }
                }
            },
            {
                "fr", new Dictionary<string, string>
                {
                    { "Success", "Requête réussie." },
                    { "Error", "Échec de la requête." },
                    { "UserNotFound", "Utilisateur non trouvé." },
                    { "Welcome", "Bienvenue sur notre API!" }
                }
            }
            };

        public static string Translate(string key, string language)
        {
            if (Translations.TryGetValue(language, out var langDictionary) &&
                langDictionary.TryGetValue(key, out var translation))
            {
                return translation;
            }

            // Fallback to English if translation is missing
            return Translations["en"].ContainsKey(key) ? Translations["en"][key] : key;
        }
    }

}
