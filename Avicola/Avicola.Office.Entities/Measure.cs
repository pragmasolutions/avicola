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
    
    public partial class Measure
    {
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid BatchId { get; set; }
        public System.Guid StandardItemId { get; set; }
        public decimal Value { get; set; }
    
        public virtual Batch Batch { get; set; }
        public virtual StandardItem StandardItem { get; set; }
    }
}