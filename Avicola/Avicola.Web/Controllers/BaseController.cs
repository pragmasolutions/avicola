using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using Microsoft.Web.Mvc;
using Framework.Common.Web.ActionResults;

namespace Avicola.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        public const int DefaultPageSize = 50;
        protected ActionResult RedirectToAction<TController>(Expression<Action<TController>> action)
            where TController : Controller
        {
            return ControllerExtensions.RedirectToAction(this, action);
        }

        protected ImageResult Image(byte[] fileBytes, string contentType, int? width = null, int? height = null)
        {
            return new ImageResult(fileBytes, contentType, width, height);
        }
    }
}