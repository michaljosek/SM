using Autofac;
using Microsoft.Extensions.Configuration;
using SM.Infrastructure.IoC.Mapper;
using SM.Infrastructure.IoC.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Infrastructure.IoC
{
    public class ContainerModule : Autofac.Module
    {
        private readonly IConfiguration _configuration;

        public ContainerModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(AutoMapperConfig.Initialize())
                .SingleInstance();
            //builder.RegisterModule<CommandModule>();
            builder.RegisterModule<RepositoryModule>();
            builder.RegisterModule<ServiceModule>();
            builder.RegisterModule(new SettingsModule(_configuration));
        }
    }
}
