using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.ModelBinding;
using Framework.Data.EntityFramework.Helpers;
using Avicola.Sales.Data;
using Avicola.Sales.Entities;

namespace Avicola.Security
{
    public static class AvicolaContext // : IAvicolaContext
    {
        private static SalesUow _uow = new SalesUow(new RepositoryProvider(new RepositoryFactories())); 

        public static User User
        {
            get
            {
                if (HttpContext.Current.Session["User"] != null)
                    return HttpContext.Current.Session["User"] as User;
                if (HttpContext.Current.User.Identity != null)
                {
                    var user = _uow.Users.Get(u => u.UserName == HttpContext.Current.User.Identity.Name, u => u.Roles);
                    HttpContext.Current.Session["User"] = user;
                    return user;
                }
                return null;
            }
        }

        public static bool IsInRole(string role)
        {
            return Role == role;
        }

        public static string Role
        {
            get
            {
                if (User != null && User.Roles != null)
                {
                    return User.Roles.FirstOrDefault().Name;
                }
                return null;
            }
        }

        public static void SetIdentity(User user)
        {
            System.Web.HttpContext.Current.Session["User"] = user;
        }
    }
}
