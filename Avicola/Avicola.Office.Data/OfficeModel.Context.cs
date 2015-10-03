﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Avicola.Office.Entities;

namespace Avicola.Office.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class OfficeEntities : DbContext
    {
        public OfficeEntities()
            : base("name=OfficeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Barn> Barns { get; set; }
        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<BatchObservation> BatchObservations { get; set; }
        public virtual DbSet<DataLoadType> DataLoadTypes { get; set; }
        public virtual DbSet<FoodClass> FoodClasses { get; set; }
        public virtual DbSet<GeneticLine> GeneticLines { get; set; }
        public virtual DbSet<Measure> Measures { get; set; }
        public virtual DbSet<Standard> Standards { get; set; }
        public virtual DbSet<StandardGeneticLine> StandardGeneticLines { get; set; }
        public virtual DbSet<StandardItem> StandardItems { get; set; }
        public virtual DbSet<BatchVaccine> BatchVaccines { get; set; }
        public virtual DbSet<Stage> Stages { get; set; }
        public virtual DbSet<StandardType> StandardTypes { get; set; }
        public virtual DbSet<Vaccine> Vaccines { get; set; }
    
        public virtual int StandardGeneticLineDelete(Nullable<System.Guid> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StandardGeneticLineDelete", idParameter);
        }
    
        public virtual ObjectResult<ReportBreedingMeasuresFollowUpRow> ReportBreedingMeasuresFollowUpRow(Nullable<System.Guid> batchId, Nullable<System.DateTime> dateFrom, Nullable<System.DateTime> dateTo)
        {
            var batchIdParameter = batchId.HasValue ?
                new ObjectParameter("BatchId", batchId) :
                new ObjectParameter("BatchId", typeof(System.Guid));
    
            var dateFromParameter = dateFrom.HasValue ?
                new ObjectParameter("DateFrom", dateFrom) :
                new ObjectParameter("DateFrom", typeof(System.DateTime));
    
            var dateToParameter = dateTo.HasValue ?
                new ObjectParameter("DateTo", dateTo) :
                new ObjectParameter("DateTo", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReportBreedingMeasuresFollowUpRow>("ReportBreedingMeasuresFollowUpRow", batchIdParameter, dateFromParameter, dateToParameter);
        }
    }
}
