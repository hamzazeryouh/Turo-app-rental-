﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Application.Interfaces
{
    public interface IBaseService<TCreate, TUpdate, TViewModel>
        where TCreate : IBaseCreateDTO
        where TUpdate : IBaseUpdateDTO
        where TViewModel : IBaseViewModel
    {
        Task<TViewModel> GetByIdAsync(int id);
        Task<IEnumerable<TViewModel>> GetAllAsync();
        Task<int> CreateAsync(TCreate dto);
        Task<bool> UpdateAsync(TUpdate dto);
        Task<bool> DeleteAsync(int id);
    }
}