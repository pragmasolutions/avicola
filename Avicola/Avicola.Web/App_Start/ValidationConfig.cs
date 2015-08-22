using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Resources;

namespace Avicola.Web
{
	public class ValidationConfig
	{
		public static void Config()
		{
            ClientDataTypeModelValidatorProvider.ResourceClassKey = "AvicolaGlobalResources";
            DefaultModelBinder.ResourceClassKey = "AvicolaGlobalResources";
            
            DataAnnotationsModelValidatorProvider.RegisterAdapter(
                typeof(RequiredAttribute),
                typeof(ResourseBaseRequiredAttributeAdapter));

            DataAnnotationsModelValidatorProvider.RegisterAdapter(
                typeof(RangeAttribute),
                typeof(ResourseBaseRangeAttributeAdapter));
		}
	}

    public class ResourseBaseRequiredAttributeAdapter : RequiredAttributeAdapter
    {
        public ResourseBaseRequiredAttributeAdapter(ModelMetadata metadata,
                                          ControllerContext context,
                                          RequiredAttribute attribute)
            : base(metadata, context, attribute)
        {
            attribute.ErrorMessageResourceType = typeof(AvicolaGlobalResources);
            attribute.ErrorMessageResourceName = "Required";
        }
    }

    public class ResourseBaseRangeAttributeAdapter : RangeAttributeAdapter
    {
        public ResourseBaseRangeAttributeAdapter(ModelMetadata metadata,
                                          ControllerContext context,
                                          RangeAttribute attribute)
            : base(metadata, context, attribute)
        {
            attribute.ErrorMessageResourceType = typeof(AvicolaGlobalResources);
            attribute.ErrorMessageResourceName = "Range";
        }
    }
}