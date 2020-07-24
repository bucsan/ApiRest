using Autofac;
using AutoMapper;
using RestApiEnquete.Application;
using RestApiEnquete.Application.Interfaces;
using RestApiEnquete.Application.Mappers;
using RestApiEnquete.Domain.Core.Interfaces.Repositorys;
using RestApiEnquete.Domain.Core.Interfaces.Services;
using RestApiEnquete.Domain.Services;
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
            builder.RegisterType<ServicePoll>().As<IServicePoll>();
            builder.RegisterType<ServiceOption>().As<IServiceOption>();
            builder.RegisterType<RepositoryPoll>().As<IRepositoryPoll>();
            builder.RegisterType<RepositoryOption>().As<IRepositoryOption>();
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingPoll());
                cfg.AddProfile(new ModelToDtoMappingPoll());
                cfg.AddProfile(new DtoToModelMappingOption());
                cfg.AddProfile(new ModelToDtoMappingOption());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }

        #endregion IOC
    }

}