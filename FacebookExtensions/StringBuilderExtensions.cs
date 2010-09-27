using System.Text;

namespace FacebookExtensions
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder AddOpenGraphMetaTag(this StringBuilder builder, string propertyName, string contentValue)
        {
            return builder.AddOpenGraphMetaTag("og", propertyName, contentValue);
        }

        public static StringBuilder AddOpenGraphMetaTag(this StringBuilder builder, string @namespace, string propertyName, string contentValue)
        {
            builder.AppendFormat("<meta property=\"{0}:{1}\" content=\"{2}\" />\r\n", @namespace, propertyName, contentValue);
            return builder;
        }
    }
}