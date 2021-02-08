﻿using System;
using ProdutosTeste.Infra.CrossCutting.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace ProdutosTeste.Service.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
