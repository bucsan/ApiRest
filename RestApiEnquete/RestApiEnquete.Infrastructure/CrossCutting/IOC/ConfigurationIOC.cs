﻿using Autofac;
using RestApiEnquete.Application;
using RestApiEnquete.Application.Interfaces;
using RestApiEnquete.Application.Interfaces.Mappers;
using RestApiEnquete.Application.Mappers;
using RestApiEnquete.Domain.Core.Interfaces.Repositorys;
using RestApiEnquete.Domain.Core.Interfaces.Services;
using RestApiEnquete.Infrastructure.Data.Repositorys;

namespace RestApiEnquete.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServicePoll>().As<IApplicationServicePoll>();
            builder.RegisterType<ApplicationServiceOption>().As<IApplicationServiceOption>();

            builder.RegisterType<ApplicationServicePoll>().As<IServicePoll>();
            builder.RegisterType<ApplicationServiceOption>().As<IServiceOption>();

            builder.RegisterType<RepositoryPoll>().As<IRepositoryPoll>();
            builder.RegisterType<RepositoryOption>().As<IRepositoryOption>();

            builder.RegisterType<MapperPoll>().As<IMapperPoll>();
            builder.RegisterType<MapperOption>().As<IMapperOption>();

            #endregion IOC
        }
    }
}