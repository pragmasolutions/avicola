//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Avicola.Sales.Entities
{
    using System;
    using System.Collections.Generic;
    
    using Framework.Data.Interfaces;
    public partial class OrderEggClass
    {
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int Dozens { get; set; }
        public System.Guid EggClassId { get; set; }
        public System.Guid OrderId { get; set; }
    
        public virtual EggClass EggClass { get; set; }
        public virtual Order Order { get; set; }
    }
}
