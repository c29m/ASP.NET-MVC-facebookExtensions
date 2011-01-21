using System;
using FacebookExtensions.Markup;

namespace FacebookExtensions
{
    public class Fbml
    {
        public SocialPlugins SocialPlugins { get; set; }
        public OpenGraph OpenGraph { get; set; }
        public JavascriptSdk JavascriptSdk { get; set; }

        public Fbml()
        {
            SocialPlugins = new SocialPlugins();
            OpenGraph = new OpenGraph();
            JavascriptSdk = new JavascriptSdk();
        }

        public string EnableJavascriptSdk(string facebookAppId)
        {
            if (string.IsNullOrWhiteSpace(facebookAppId))
            {
                throw new ArgumentNullException("facebookAppId", "You must supply a valid Facebook App Id");
            }

            return string.Format(@"<div id=""fb-root""></div>
<script type=""text/javascript"">
    try {{
        window.fbAsyncInit = function () {{
            FB.init({{ appId: '{0}', status: true, cookie: true, xfbml: true }});
        }};
        (function () {{
            var e = document.createElement('script'); e.async = true;
            e.src = document.location.protocol + '//connect.facebook.net/en_US/all.js';
            document.getElementById('fb-root').appendChild(e);
        }} ());
    }}
    catch (err) {{ }}
</script>", facebookAppId);
        }
    }
}
