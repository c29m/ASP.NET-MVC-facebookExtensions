﻿namespace FacebookExtensions.Markup.Javascript
{
    public class StreamPublishAttachment
    {
        public string Name { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string Href { get; set; }
        public StreamPublishMediaItem Media { get; set; }

        public StreamPublishAttachment()
        {
            Name = string.Empty;
            Caption = string.Empty;
            Description = string.Empty;
            Href = string.Empty;
        }
    }
}