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
    
    public partial class ReportOrderDispatchNoteRow
    {
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> PreparedDate { get; set; }
        public Nullable<System.DateTime> DispatchedDate { get; set; }
        public string ClientName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Truck { get; set; }
        public string DriverName { get; set; }
        public string EggClassName { get; set; }
        public Nullable<int> Dozens { get; set; }
    }
}
