using System;
using System.Web;
using FacebookExtensions.Markup.SocialPlugin;
using FacebookExtensions.Markup.SocialPlugin.Like;

namespace FacebookExtensions.Markup
{
    public class SocialPlugins
    {
        public string Like(string href = "", string linkReference = "", bool showFaces = false, int width = 510, string font = "arial", string style = "", LikeVerb action = LikeVerb.Like, ColorScheme colorScheme = ColorScheme.Light, LayoutStyle layout = LayoutStyle.Standard)
        {
            return string.Format("<fb:like href=\"{0}\" ref=\"{1}\" show_faces=\"{2}\" width=\"{3}\" font=\"{4}\" style=\"{5}\" action=\"{6}\" colorscheme=\"{7}\" layout=\"{8}\"></fb:like>",
                                        href, linkReference, showFaces, width, font, style, action.ToString().ToLower(), colorScheme.ToString().ToLower(), layout.ToString().ToLower());
        }

        public string ActivityFeed(bool showRecommendations = false)
        {
            return string.Format("<fb:activity recommendations=\"{0}\"></fb:activity>", showRecommendations);
        }

        public string Comments(string uniqueId = "", int numberOfComments = 10, int width = 425, bool publishToFeed = true)
        {
            return string.Format("<fb:comments xid=\"{0}\" numposts=\"{1}\" width=\"{2}\" publish_feed=\"{3}\"></fb:comments>", uniqueId, numberOfComments, width, publishToFeed);
        }

        public string Facepile(int maxRows = 1, string href = "", int width = 200)
        {
            return string.Format("<fb:facepile max-rows=\"{0}\" href=\"{1}\" width=\"{2}\"></fb:facepile>", maxRows, href, width);
        }

        public string LikeBox(string facebookPageUrl, int width = 300, int height = 556, ColorScheme colorScheme = ColorScheme.Light, int connections = 10, bool showStream = true, bool showHeader = true)
        {
            return string.Format("<fb:like-box href=\"{0}\" width=\"{1}\" height=\"{2}\" colorscheme=\"{3}\" connections=\"{4}\" stream=\"{5}\" header=\"{6}\"></fb:like-box>",
                                    facebookPageUrl, width, height, colorScheme.ToString().ToLower(), connections, showStream, showHeader);
        }

        public string LiveStream(string appId)
        {
            return string.Format("<fb:live-stream event_app_id=\"{0}\"></fb:live-stream>", appId);
        }

        public string LoginButton(bool showFaces = false, int width = 200, int maxRows = 1)
        {
            return string.Format("<fb:login-button show-faces=\"{0}\" width=\"{1}\" max-rows=\"{2}\"></fb:login-button>", showFaces, width, maxRows);
        }
 
        public string Recommendations(int width = 300, int height = 300, bool showHeader = true, string font = "arial", string borderColor = "", string site = "")
        {
            return string.Format("<fb:recommendations width=\"{0}\" height=\"{1}\" header=\"{2}\" font=\"{3}\" border_color=\"{4}\" site=\"{5}\"></fb:recommendations>",
                    width, height, showHeader, font, borderColor, site);
        }

        public string Registration(string appId, Uri redirectUri, string fields, bool? facebookOnly = false, string cssWidth = "100%", string cssHeight = "330", string borderColor = "")
        {
            return string.Format(@"
                <iframe src=""http://www.facebook.com/plugins/registration.php?
                             client_id={0}&
                             redirect_uri={1}&
                             fields={2}""
                        scrolling=""auto""
                        frameborder=""no""
                        style=""border:none""
                        allowTransparency=""true""
                        width=""100%""
                        height=""330"">
                </iframe>
            ", appId, HttpUtility.UrlEncode(redirectUri.ToString()), fields);
        }
    }
}