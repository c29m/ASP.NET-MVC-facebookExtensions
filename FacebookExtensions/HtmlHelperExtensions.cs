using System;
using System.Globalization;
using System.Text;
using System.Web.Mvc;

namespace FacebookExtensions
{
    public static class HtmlHelperExtensions
    {
        public static Fbml Facebook(this HtmlHelper helper)
        {
            return new Fbml();
        }
    }
}
