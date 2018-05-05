using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using SM.Infrastructure.EF;
using SM.Infrastructure.Extensions;
using SM.Infrastructure.Settings;

namespace SM.Infrastructure.IoC.Modules
{
    public class SettingsModule : Autofac.Module
    {
        private readonly IConfiguration _configuration;

        public SettingsModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(_configuration.GetSettings<GeneralSettings>())
                    .SingleInstance();
            builder.RegisterInstance(_configuration.GetSettings<SqlSettings>())
                    .SingleInstance();
        }
    }
}
