using System;
using System.Globalization;
using System.Text;
using System.Web.Mvc;

namespace FacebookExtensions
{
    public static class HtmlHelperExtensions
    {
        private static Fbml _fbmlUtility;

        public static Fbml Facebook(this HtmlHelper helper)
        {
            return _fbmlUtility ?? (_fbmlUtility = new Fbml());
        }

        private static string RequestUrl(this HtmlHelper helper)
        {
            return helper.ViewContext.RequestContext.HttpContext.Request.Url.ToString();
        }
    }
}
