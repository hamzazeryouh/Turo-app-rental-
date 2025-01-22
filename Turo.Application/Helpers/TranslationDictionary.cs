namespace Turo.Application.Helpers
{
    using System.Collections.Generic;
    using System.Text.Json;

    public static class TranslationDictionary
    {
        private static Dictionary<string, Dictionary<string, string>> _translations;

        static TranslationDictionary()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Helpers/Translations.json");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Translation file not found at {filePath}. Ensure the file exists.");
            }
            var json = File.ReadAllText(filePath);
            _translations = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
        }

        public static string Translate(string key, string language)
        {
            if (_translations.TryGetValue(language, out var langDictionary) &&
                langDictionary.TryGetValue(key, out var translation))
            {
                return translation;
            }

            // Fallback to English if translation is missing
            return _translations["en"].ContainsKey(key) ? _translations["en"][key] : key;
        }
    }

}
