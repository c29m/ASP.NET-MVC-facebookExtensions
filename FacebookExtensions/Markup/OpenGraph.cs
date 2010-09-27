using System;
using System.Globalization;
using System.Text;

namespace FacebookExtensions.Markup
{
    public class OpenGraph
    {
        private string _siteName;
        private string _appId;

        public void Initilise(string siteName, string appId)
        {
            _siteName = siteName;
            _appId = appId;
        }

        public string OpenGraphTags(string title, string url)
        {
            return OpenGraphTags(title, string.Empty, url, OpenGraphType.Website);
        }

        public string OpenGraphTags(string title, string imageUrl, string url, OpenGraphType type)
        {
            if(string.IsNullOrWhiteSpace(_siteName) 
                || string.IsNullOrWhiteSpace(_appId))
            {
                throw new InvalidOperationException("OpenGraph not initilised, please call Initilise(string sitename, string appId) first.");
            }

            ValidateOpenGraphParameter(_appId, "appId");

            ValidateOpenGraphUrlIsAbsolute(imageUrl, "imageUrl");
            ValidateOpenGraphUrlIsAbsolute(url, "url");

            return new StringBuilder()
                .AddOpenGraphMetaTag("title", title)
                .AddOpenGraphMetaTag("type", type.ToString().ToLower())
                .AddOpenGraphMetaTag("image", imageUrl)
                .AddOpenGraphMetaTag("url", url)
                .AddOpenGraphMetaTag("site_name", _siteName)
                .AddOpenGraphMetaTag("fb", "app_id", _appId)
                .ToString();
        }

        private static void ValidateOpenGraphParameter(string parameterValue, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(parameterValue))
            {
                throw new ArgumentException(String.Format("Unable to add OpenGraph metadata, parameter '{0}' not specified.", parameterName), parameterName);
            }
        }

        private static void ValidateOpenGraphUrlIsAbsolute(string url, string urlParameterName)
        {
            if (!url.StartsWith("http://", true, CultureInfo.InvariantCulture))
            {
                throw new ArgumentException(String.Format("Unable to add OpenGraph metadata, '{0}' specified must be absolute.\r\nValue Passed: '{1}'.", urlParameterName, url), urlParameterName);
            }
        }
        
    }
}