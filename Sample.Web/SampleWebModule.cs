using Autofac;
using Sample.Core.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Web
{
    public class SampleWebModule : ILamaWebModule
    {
        public void Initialize(ContainerBuilder builder)
        {
            //test push
            //test push1
            //test diff
        }

        public void PostInitialize(ILifetimeScope container) { }
    }
}