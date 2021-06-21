﻿using System.Reflection;
using FluentPOS.Shared.Core.Extensions;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace FluentPOS.Modules.Identity.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddIdentityCore(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddExtendedAttributeHandlersFromAssembly(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}