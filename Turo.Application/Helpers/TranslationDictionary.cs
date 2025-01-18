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
                    { "Deleted", "Entity successfully deleted." },
                    { "InvalidCarData", "Invalid car data provided." },
                    { "RequiredField", "{PropertyName} is required." },
                      { "MakeRequired", "Make is required." },
            { "MakeMaxLength", "Make cannot exceed 50 characters." },
            { "ModelRequired", "Model is required." },
            { "ModelMaxLength", "Model cannot exceed 50 characters." },
            { "VINRequired", "VIN is required." },
            { "VINFormat", "VIN must be exactly 17 characters and contain only letters and numbers." },
            { "YearRequired", "Year is required." },
            { "YearRange", "Year must be between 1886 and {0}." },
            { "LicensePlateRequired", "License plate is required." },
            { "LicensePlateMaxLength", "License plate cannot exceed 10 characters." },
            { "PricePerDayMin", "Price per day must be greater than zero." },
            { "MileageMin", "Mileage cannot be negative." },
            { "SeatsRange", "Seats must be between 1 and 10." },
            { "LatitudeRange", "Latitude must be between -90 and 90." },
            { "LongitudeRange", "Longitude must be between -180 and 180." }
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
                    { "Deleted", "Entité supprimée avec succès." },
                    { "InvalidCarData", "Données de voiture invalides." },
                    { "RequiredField", "{PropertyName} est requis." },
                     { "MakeRequired", "La marque est obligatoire." },
            { "MakeMaxLength", "La marque ne peut pas dépasser 50 caractères." },
            { "ModelRequired", "Le modèle est obligatoire." },
            { "ModelMaxLength", "Le modèle ne peut pas dépasser 50 caractères." },
            { "VINRequired", "Le VIN est obligatoire." },
            { "VINFormat", "Le VIN doit contenir exactement 17 caractères et ne contenir que des lettres et des chiffres." },
            { "YearRequired", "L'année est obligatoire." },
            { "YearRange", "L'année doit être comprise entre 1886 et {0}." },
            { "LicensePlateRequired", "La plaque d'immatriculation est obligatoire." },
            { "LicensePlateMaxLength", "La plaque d'immatriculation ne peut pas dépasser 10 caractères." },
            { "PricePerDayMin", "Le prix par jour doit être supérieur à zéro." },
            { "MileageMin", "Le kilométrage ne peut pas être négatif." },
            { "SeatsRange", "Le nombre de sièges doit être compris entre 1 et 10." },
            { "LatitudeRange", "La latitude doit être comprise entre -90 et 90." },
            { "LongitudeRange", "La longitude doit être comprise entre -180 et 180." }
                }
            },
                {
                "es", new Dictionary<string, string>
                {
                    { "Success", "Solicitud exitosa." },
                    { "Error", "Error en la solicitud." },
                    { "NotFound", "Entidad no encontrada." },
                    { "Created", "Entidad creada con éxito." },
                    { "Updated", "Entidad actualizada con éxito." },
                    { "Deleted", "Entidad eliminada con éxito." },
                    { "InvalidCarData", "Datos de coche no válidos." },
                    { "RequiredField", "{PropertyName} es obligatorio." },
                     { "MakeRequired", "La marca es obligatoria." },
            { "MakeMaxLength", "La marca no puede exceder los 50 caracteres." },
            { "ModelRequired", "El modelo es obligatorio." },
            { "ModelMaxLength", "El modelo no puede exceder los 50 caracteres." },
            { "VINRequired", "VIN es obligatorio." },
            { "VINFormat", "VIN debe tener exactamente 17 caracteres y contener solo letras y números." },
            { "YearRequired", "El año es obligatorio." },
            { "YearRange", "El año debe estar entre 1886 y {0}." },
            { "LicensePlateRequired", "La matrícula es obligatoria." },
            { "LicensePlateMaxLength", "La matrícula no puede exceder los 10 caracteres." },
            { "PricePerDayMin", "El precio por día debe ser mayor que cero." },
            { "MileageMin", "El kilometraje no puede ser negativo." },
            { "SeatsRange", "Los asientos deben estar entre 1 y 10." },
            { "LatitudeRange", "La latitud debe estar entre -90 y 90." },
            { "LongitudeRange", "La longitud debe estar entre -180 y 180." }
                }
            },
                {
           "ar", new Dictionary<string, string>
        {
            { "MakeRequired", "الماركة مطلوبة." },
            { "MakeMaxLength", "الماركة لا يمكن أن تتجاوز 50 حرفًا." },
            { "ModelRequired", "الموديل مطلوب." },
            { "ModelMaxLength", "الموديل لا يمكن أن يتجاوز 50 حرفًا." },
            { "VINRequired", "رقم VIN مطلوب." },
            { "VINFormat", "يجب أن يحتوي رقم VIN على 17 حرفًا فقط ويتكون من أحرف وأرقام فقط." },
            { "YearRequired", "السنة مطلوبة." },
            { "YearRange", "يجب أن تكون السنة بين 1886 و {0}." },
            { "LicensePlateRequired", "رقم اللوحة مطلوب." },
            { "LicensePlateMaxLength", "رقم اللوحة لا يمكن أن يتجاوز 10 أحرف." },
            { "PricePerDayMin", "يجب أن يكون السعر اليومي أكبر من صفر." },
            { "MileageMin", "لا يمكن أن يكون عدد الكيلومترات سالبًا." },
            { "SeatsRange", "يجب أن يكون عدد المقاعد بين 1 و 10." },
            { "LatitudeRange", "يجب أن تكون دائرة العرض بين -90 و 90." },
            { "LongitudeRange", "يجب أن تكون خط الطول بين -180 و 180." }
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
