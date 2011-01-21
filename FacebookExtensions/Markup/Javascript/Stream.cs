namespace FacebookExtensions.Markup.Javascript
{
    public class Stream
    {
        public StreamPublishBuilder Publish()
        {
            return new StreamPublishBuilder("stream.publish");
        }
    }
}