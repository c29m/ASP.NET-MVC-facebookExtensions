namespace FacebookExtensions.Markup.Javascript
{
    public class StreamPublishActionLink
    {
        public string Text { get; set; }
        public string Href { get; set; }

        public StreamPublishActionLink(string text, string href)
        {
            Text = text;
            Href = href;
        }
    }
}