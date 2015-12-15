using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Interfaces;

namespace Avicola.Sales.Entities
{
    public partial class EggEquivalence : IEntity
    {
        public static readonly Guid EGGS = new Guid("94CE87BD-519E-4507-AE06-F5BCA2CBA595");
        public static readonly Guid DOZENS = new Guid("107C25DC-D92C-4BAB-A093-C9FCE2B8D522");
        public static readonly Guid MAPLES = new Guid("A9CDEB17-7207-4D95-BF55-0E62CF24FB65");
        public static readonly Guid BOXES = new Guid("5CB0F2A5-EA71-4539-A876-13F1DB31611E");
    }
}