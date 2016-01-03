using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using Framework.Common.Validation;

namespace Avicola.Common.Win.Forms
{
    public class EditFormBase : FrmBase
    {
        public EditFormBase()
        {
            Errores = new Collection<ValidationResult>();
        }

        protected virtual object GetEntity()
        {
            return new object();
        }

        protected virtual void ValidateControls()
        {
        }

        protected ICollection<ValidationResult> Errores { get; set; }

        protected virtual bool ValidarForm()
        {
            //Validate
            this.FormErrorProvider.Clear();
            ICollection<ValidationResult> errores = new Collection<ValidationResult>();
            var esValido = DataAnnotationsValidator.TryValidate(GetEntity(), out errores);
            Errores = errores;

            //Mostrar errores de validacion en controles
            ValidateControls();

            return esValido;
        }

        protected void ValidateControl(Control control, string nombrePropiedad)
        {
            var erroresControl = Errores.Where(r => r.MemberNames.Any(n => n == nombrePropiedad));
            if (erroresControl.Any())
            {
                foreach (var error in erroresControl)
                {
                    this.FormErrorProvider.SetError(control, error.ErrorMessage);
                }
            }
        }
    }
}
