﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProductApi.Application.ViewModels;
using FluentValidation.Results;

namespace ProductApi.Application.Interfaces
{
    public interface IProductAppService : IDisposable
    {
        Task<IEnumerable<ProductViewModel>> GetAll();
        Task<ProductViewModel> GetById(Guid id);

        Task<ValidationResult> Register(ProductViewModel productViewModel);
        Task<ValidationResult> Update(ProductViewModel productViewModel);
        Task<ValidationResult> Remove(Guid id);
    }
}
