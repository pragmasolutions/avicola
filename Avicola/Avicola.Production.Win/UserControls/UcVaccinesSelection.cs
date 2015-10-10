using System;
using System.Linq;
using System.Windows.Forms;
using Avicola.Office.Services.Interfaces;
using Avicola.Office.Entities;

namespace Avicola.Production.Win.UserControls
{
    public partial class UcVaccinesSelection : UserControl
    {
        
        public UcVaccinesSelection(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
            InitializeComponent();
        }

        public event EventHandler vaccineChanged;

        public Guid Id
        {
            get { return (ddlVaccines.SelectedValue != null) ? (Guid)ddlVaccines.SelectedValue : Guid.Empty; }
            set { ddlVaccines.SelectedValue = value; }
        }

        public void LoadVaccine()
        {
            using (var vaccineService = _serviceFactory.Create<IVaccineService>())
            {
                var vaccines = vaccineService.GetAllActive().OrderBy(x => x.Name).ToList();
                ddlVaccines.ValueMember = "Id";
                ddlVaccines.DisplayMember = "Name";
                Vaccine item = new Vaccine();
                item.Name = "Selecciona una vacuna..";
                item.Id = Guid.Empty;
                vaccines.Insert(0, item);
                ddlVaccines.DataSource = vaccines;
            }
        }

        private void ddlVaccines_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.vaccineChanged != null)
                this.vaccineChanged(this, e); 
        }
    }
}
