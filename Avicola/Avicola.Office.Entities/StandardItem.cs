//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Avicola.Office.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class StandardItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StandardItem()
        {
            this.Measures = new HashSet<Measure>();
        }
    
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid StandardGeneticLineId { get; set; }
        public int Sequence { get; set; }
        public decimal Value { get; set; }
        public Nullable<System.Guid> FoodClassId { get; set; }
    
        public virtual FoodClass FoodClass { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Measure> Measures { get; set; }
        public virtual StandardGeneticLine StandardGeneticLine { get; set; }
    }
}
