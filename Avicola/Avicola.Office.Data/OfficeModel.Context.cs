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
        public virtual DbSet<BatchVaccine> BatchVaccines { get; set; }
        public virtual DbSet<DataLoadType> DataLoadTypes { get; set; }
        public virtual DbSet<FoodClass> FoodClasses { get; set; }
        public virtual DbSet<GeneticLine> GeneticLines { get; set; }
        public virtual DbSet<Measure> Measures { get; set; }
        public virtual DbSet<Standard> Standards { get; set; }
        public virtual DbSet<StandardGeneticLine> StandardGeneticLines { get; set; }
        public virtual DbSet<StandardItem> StandardItems { get; set; }
        public virtual DbSet<Vaccine> Vaccines { get; set; }
    }
}