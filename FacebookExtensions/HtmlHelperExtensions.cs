using System;
using System.Globalization;
using System.Text;
using System.Web.Mvc;

namespace FacebookExtensions
{
    public static class HtmlHelperExtensions
    {
        private static readonly Fbml _fbml;

        static HtmlHelperExtensions()
        {
            _fbml = new Fbml();
        }

        public static Fbml Facebook(this HtmlHelper helper)
        {
            return _fbml;
        }
    }
}
