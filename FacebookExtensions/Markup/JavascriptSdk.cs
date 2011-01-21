using FacebookExtensions.Markup.Javascript;

namespace FacebookExtensions.Markup
{
    public class JavascriptSdk
    {
        public Stream Stream { get; private set; }

        public JavascriptSdk()
        {
            Stream = new Stream();
        }
    }
}
