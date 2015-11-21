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
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int Dozens { get; set; }
        public System.Guid ClientId { get; set; }
        public System.Guid OrderStatusId { get; set; }
        public Nullable<System.DateTime> DispatchedDate { get; set; }
        public Nullable<System.Guid> TruckId { get; set; }
        public Nullable<System.Guid> DriverId { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual Truck Truck { get; set; }
    }
}
