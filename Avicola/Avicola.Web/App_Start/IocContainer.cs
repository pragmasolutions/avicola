using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Framework.Ioc;

namespace Avicola.Web
{
    public class IocContainer
    {
        private static IIocContainer _iocContainer;

        public static void Initialize(IIocContainer iocContainer)
        {
            _iocContainer = iocContainer;
        }

        /// <summary>
        /// Creates a new instance of the 
        /// </summary>
        /// <returns></returns>
        public static IIocContainer GetContainer()
        {
            return _iocContainer;
        }
    }
}