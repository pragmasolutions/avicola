using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Interfaces;

namespace Avicola.Sales.Entities
{
    public partial class Product : IEntity
    {
        public static readonly Guid EGG = new Guid("A4333894-8CCC-4CEE-9F9D-7A253D1076D3");
        public static readonly Guid BROKEN_EGG = new Guid("3D75E475-DF18-4D21-93A0-ABD90661652D");
        public static readonly Guid NO_SHELL_EGG = new Guid("8E2A2B2C-78D5-4BCB-BF22-BDC35A11B55B");
    }
}
