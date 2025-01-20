using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Application.Interfaces
{
    public interface IBaseService<TEntity, TCreate, TUpdate, TViewModel>
        where TCreate : IBaseCreateDTO
        where TUpdate : IBaseUpdateDTO
        where TViewModel : IBaseViewModel
        where TEntity : class
    {
        Task<TViewModel> GetByIdAsync(string id);
        Task<IEnumerable<TViewModel>> GetAllAsync();
        Task<bool> CreateAsync(TCreate dto);
        Task<bool> UpdateAsync(TUpdate dto);
        Task<bool> DeleteAsync(string id);
    }
}
