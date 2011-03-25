namespace FacebookExtensions.Markup.Javascript
{
    public class Stream
    {
        public StreamPublishBuilder Publish()
        {
            return new StreamPublishBuilder("stream.publish");
        }

        /// <summary>
        /// Possible publish methods values:
        /// stream.publish
        /// friends.add
        /// stream.share
        /// fbml.dialog
        /// bookmark.add
        /// profile.addtab
        /// </summary>
        /// <returns></returns>
        public StreamPublishBuilder Publish(string method)
        {
            return new StreamPublishBuilder(method);
        }
    }
}