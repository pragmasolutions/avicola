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
    public partial class Shift
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shift()
        {
            this.StockEntries = new HashSet<StockEntry>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockEntry> StockEntries { get; set; }
    }
}
