using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Application.Services
{
    public interface ITranslationService
    {
        string GetTranslation(string key);
    }
}
