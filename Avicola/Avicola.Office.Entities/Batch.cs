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
    
    using Framework.Data.Interfaces;
    public partial class Batch : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Batch()
        {
            this.BatchBarns = new HashSet<BatchBarn>();
            this.BatchMedicines = new HashSet<BatchMedicine>();
            this.BatchObservations = new HashSet<BatchObservation>();
            this.BatchVaccines = new HashSet<BatchVaccine>();
            this.Measures = new HashSet<Measure>();
        }
    
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int Number { get; set; }
        public int InitialBirds { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public System.Guid GeneticLineId { get; set; }
        public decimal StartingFood { get; set; }
        public System.Guid FoodClassId { get; set; }
        public Nullable<System.Guid> BarnId { get; set; }
        public System.Guid StageId { get; set; }
        public System.DateTime ArrivedToBarn { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> BreedingDate { get; set; }
        public Nullable<System.DateTime> ReBreedingDate { get; set; }
        public Nullable<System.DateTime> PostureDate { get; set; }
    
        public virtual Barn Barn { get; set; }
        public virtual FoodClass FoodClass { get; set; }
        public virtual GeneticLine GeneticLine { get; set; }
        public virtual Stage Stage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchBarn> BatchBarns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchMedicine> BatchMedicines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchObservation> BatchObservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchVaccine> BatchVaccines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Measure> Measures { get; set; }
    }
}
