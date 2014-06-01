using System;
using Nancy;
using Nancy.TinyIoc;
using Nancy.Bootstrapper;

namespace GlimpseConsole
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        public Bootstrapper()
        {

        }

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            StaticConfiguration.DisableErrorTraces = false;
        }
    }
}

