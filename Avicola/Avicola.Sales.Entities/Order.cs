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
    public partial class Order : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderEggClasses = new HashSet<OrderEggClass>();
        }
    
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ClientId { get; set; }
        public System.Guid OrderStatusId { get; set; }
        public Nullable<System.DateTime> DispatchedDate { get; set; }
        public Nullable<System.Guid> TruckId { get; set; }
        public Nullable<System.Guid> DriverId { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> PreparedDate { get; set; }
        public Nullable<System.Guid> DepositId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual Truck Truck { get; set; }
        public virtual Deposit Deposit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderEggClass> OrderEggClasses { get; set; }
    }
}
