using System;
using System.Security.Cryptography.X509Certificates;
using Framework.Data.Repository;
using Avicola.Office.Entities;

namespace Avicola.Office.Data.Interfaces
{
    public interface IOfficeUow : IUow
    {
        IRepository<Barn> Barns { get; }
        IRepository<Batch> Batches { get; }
        IRepository<BatchObservation> BatchObservations { get; }
        IRepository<BatchVaccine> BatchVaccines { get; }
        IRepository<BatchMedicine> BatchMedicines { get; }
        IRepository<DataLoadType> DataLoadTypes { get; }
        IRepository<FoodClass> FoodClasses { get; }
        IRepository<GeneticLine> GeneticLines { get; }
        IRepository<Measure> Measures { get; }
        IRepository<Standard> Standards { get; }
        IRepository<StandardGeneticLine> StandardGeneticLines { get; }
        IRepository<StandardItem> StandardItems { get; }
        IRepository<Vaccine> Vaccines { get; }
        IRepository<Medicine> Medicines { get; }
        IRepository<Stage> Stages { get; }

        OfficeEntities DbContext { get; }
    }
}
