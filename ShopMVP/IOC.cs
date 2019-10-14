﻿using Autofac;

namespace ShopMVP
{
    public static class IoC
    {
        private static IContainer container;
        private static ContainerBuilder builder;

        static IoC()
        {
            builder = new ContainerBuilder();
        }

        public static void Register<TImplementation, TInterface>()
        {
            builder.RegisterType<TImplementation>()
                .As<TInterface>();
        }

        public static void Register<TImplementation>()
        {
            builder.RegisterType<TImplementation>();
        }

        public static void Build()
        {
            container = builder.Build();
        }

        public static T Resolve<T>()
        {
            return container.Resolve<T>();
        }
    }
}
