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
                    { "NotFound", "Entity not found." },
                    { "Created", "Entity successfully created." },
                    { "Updated", "Entity successfully updated." },
                    { "Deleted", "Entity successfully deleted." }
                }
            },
            {
                "fr", new Dictionary<string, string>
                {
                    { "Success", "Requête réussie." },
                    { "Error", "Échec de la requête." },
                    { "NotFound", "Entité non trouvée." },
                    { "Created", "Entité créée avec succès." },
                    { "Updated", "Entité mise à jour avec succès." },
                    { "Deleted", "Entité supprimée avec succès." }
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
