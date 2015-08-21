﻿using Framework.Data.Repository;
using Framework.Ioc;

namespace Avicola.Data.Common
{
    public class UowFactory : IUowFactory
    {
        private readonly IIocContainer _container;

        public UowFactory(IIocContainer container)
        {
            _container = container;
        }

        public T Create<T>()
        {
            return _container.Get<T>();
        }
    }
}
