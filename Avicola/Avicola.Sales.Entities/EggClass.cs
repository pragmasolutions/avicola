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
    public partial class EggClass : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EggClass()
        {
            this.ClassificationEggClasses = new HashSet<ClassificationEggClass>();
            this.OrderEggClasses = new HashSet<OrderEggClass>();
        }
    
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public int Sequence { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassificationEggClass> ClassificationEggClasses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderEggClass> OrderEggClasses { get; set; }
    }
}
