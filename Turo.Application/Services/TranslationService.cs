using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Application.Services
{
    using Microsoft.AspNetCore.Http;
    using Turo.Application.Helpers;



    public class TranslationService : ITranslationService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TranslationService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetTranslation(string key)
        {
            var request = _httpContextAccessor.HttpContext.Request;
            string language = request.Headers["Accept-Language"].ToString().Split(',')[0] ?? "en"; // Default to English
            return TranslationDictionary.Translate(key, language);
        }
    }

}
