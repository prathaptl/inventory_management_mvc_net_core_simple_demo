using InventoryManagement.Web.Context;
using InventoryManagement.Web.Extentions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Web.Filters
{
    public class BaseAuthenticationFilter : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext filterContext)
        {
            var routeData = filterContext.RouteData;

            var action = routeData.GetRequiredString("action");
            var controller = routeData.GetRequiredString("controller");

            var method = filterContext.HttpContext.Request.Method;
            var ipAddress = filterContext.HttpContext.Request.Host;

            if (InventoryManagemetHttpContext.Current.Session.GetObject<UserContext>("UserContext") == null)
            {
                filterContext.Result = new RedirectResult("~/Login");
                return;
            }

            if (Context.Context.UserContext.IsSuperUser)
                return;

            if (action.StartsWith("Get") || action.StartsWith("GET")) //Ajax calls
                return;

            if (controller == "Home" && (action == "AuthenticationError" || action == "Index")) 
                return;

            if (Context.Context.UserContext.Privileges.HasPrivilege(controller + action))
                return;

            SetAuthError(filterContext);

        }

        private void SetAuthError(AuthorizationFilterContext filterContext)
        {
            var redirectTargetDictionary = new RouteValueDictionary();
            redirectTargetDictionary.Add("action", "AuthenticationError");
            redirectTargetDictionary.Add("controller", "Home");
            redirectTargetDictionary.Add("error", "You don`t have permission to do this action, Please contact Your Administrator !");
            filterContext.Result = new RedirectToRouteResult(redirectTargetDictionary);
        }
    }


}

namespace Microsoft.AspNetCore.Mvc
{
    public static class HelperExtensions
    {
        public static string GetRequiredString(this RouteData routeData, string keyName)
        {
            object value;
            if (!routeData.Values.TryGetValue(keyName, out value))
            {
                throw new InvalidOperationException($"Could not find key with name '{keyName}'");
            }

            return value?.ToString();
        }
    }
}
