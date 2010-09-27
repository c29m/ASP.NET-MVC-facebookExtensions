using System;
using System.Web.Mvc;

namespace FacebookExtensions.Markup
{
    public class SocialPlugins
    {
        public string Like()
        {
            return Like(string.Empty, string.Empty);
        }

        public string Like(string href, string linkReference)
        {
            return string.Format("<fb:like href=\"{0}\" ref=\"{1}\" show_faces=\"false\" width=\"510\" font=\"arial\" style=\"font-size:12px\" action=\"recommend\" ></fb:like>", href, linkReference);
        }

        public string ActivityFeed()
        {
            return ActivityFeed(false);
        }

        public string ActivityFeed(bool showRecommendations)
        {
            return string.Format("<fb:activity recommendations=\"{0}\"></fb:activity>", showRecommendations);
        }

        public string Comments()
        {
            return "<fb:comments></fb:comments>";
        }

        public string Facepile()
        {
            return "<fb:facepile></fb:facepile>";
        }

        public string LikeBox(string facebookPageUrl)
        {
            return string.Format("<fb:like-box href=\"{0}\"></fb:like-box>", facebookPageUrl);
        }

        public string LiveStream(string appId)
        {
            return string.Format("<fb:live-stream event_app_id=\"{0}\"></fb:live-stream>", appId);
        }

        public string LoginButton()
        {
            return LoginButton(false, 200, 10);
        }

        public string LoginButton(bool showFaces, int width, int maxRows)
        {
            return string.Format("<fb:login-button show-faces=\"{0}\" width=\"{1}\" max-rows=\"{2}\"></fb:login-button>", showFaces, width, maxRows);
        }

        public string Recommendations()
        {
            return Recommendations(300, 300, true, "light", "arial", "", "");
        }

        public string Recommendations(int width, int height, bool showHeader, string colorScheme, string font, string borderColor, string site)
        {
            return string.Format(
                    "<fb:recommendations width=\"{0}\" height=\"{1}\" header=\"{2}\" font=\"{3}\" border_color=\"{4}\" site=\"{5}\"></fb:recommendations>",
                    width, height, showHeader, font, borderColor, site);
        }
    }
}