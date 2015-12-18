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
    public partial class ClassificationEggClass : IEntity
    {
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public System.Guid ClassificationId { get; set; }
        public System.Guid EggClassId { get; set; }
        public System.Guid EggEquivalenceId { get; set; }
        public int Amount { get; set; }
        public Nullable<int> EggsCount { get; set; }
    
        public virtual Classification Classification { get; set; }
        public virtual EggClass EggClass { get; set; }
        public virtual EggEquivalence EggEquivalence { get; set; }
    }
}
