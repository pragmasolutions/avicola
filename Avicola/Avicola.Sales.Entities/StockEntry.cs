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
    public partial class StockEntry : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockEntry()
        {
            this.Classifications = new HashSet<Classification>();
        }
    
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ShiftId { get; set; }
        public System.Guid StockId { get; set; }
        public int Boxes { get; set; }
        public int Maples { get; set; }
        public int Eggs { get; set; }
        public Nullable<System.Guid> ProviderId { get; set; }
        public bool IsDeleted { get; set; }
        public int CurrentEggs { get; set; }
        public System.Guid BarnId { get; set; }
    
        public virtual Provider Provider { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual Stock Stock { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Classification> Classifications { get; set; }
    }
}
