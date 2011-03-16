using System.Web.Mvc;

namespace FacebookExtensions
{
    public static class HtmlHelperExtensions
    {
        private static readonly Fbml Fbml;

        static HtmlHelperExtensions()
        {
            Fbml = new Fbml();
        }

        public static Fbml Facebook(this HtmlHelper helper)
        {
            return Fbml;
        }
    }
}
