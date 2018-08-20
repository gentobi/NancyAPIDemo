using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.Configuration;
using Nancy.Conventions;
using Nancy.TinyIoc;

namespace NancyDemo.API
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        private readonly IServiceProvider _serviceProvider;

        public Bootstrapper(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public override void Configure(INancyEnvironment environment)
        {
            base.Configure(environment);
        }

        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);
        }

        protected override void ConfigureRequestContainer(TinyIoCContainer container, NancyContext context)
        {
            base.ConfigureRequestContainer(container, context);
        }
    }
}
