using System.Collections.Generic;
using System.Text;

namespace FacebookExtensions.Markup.Javascript
{
    public class StreamPublishBuilder
    {
        private readonly string _method;
        private string _message;
        private StreamPublishAttachment _attachment;
        private readonly List<StreamPublishActionLink> _actionLinks;
        private string _userMessagePrompt;

        public StreamPublishBuilder(string method)
        {
            _method = method;
            _actionLinks = new List<StreamPublishActionLink>();
        }

        public StreamPublishBuilder Message(string message)
        {
            _message = message;
            return this;
        }

        public StreamPublishBuilder UserMessagePrompt(string userMessagePrompt)
        {
            _userMessagePrompt = userMessagePrompt;
            return this;
        }

        public StreamPublishBuilder AddActionLink(string text, string href)
        {
            _actionLinks.Add(new StreamPublishActionLink(text, href));
            return this;
        }

        public StreamPublishBuilder WithAttachment(StreamPublishAttachment attachment)
        {
            _attachment = attachment;
            return this;
        }

        public string ToJavascript()
        {
            const string mediaEntryTemplate = "{{'type':'image','src':'{0}','href':'{1}'}}";
            const string actionLinkTemplate = "{{ 'text': '{0}', 'href': '{1}' }}";
            const string attachmentTemplate = "'attachment': {{ 'name': '{0}', 'caption': '{1}', 'description': '{2}', 'href': '{3}', 'media':[{4}] }}";
            const string attachmentTemplateWithDescriptionCallback = "'attachment': {{ 'name': '{0}', 'caption': '{1}', 'description': {2}({{'description':'{3}', 'data':{4}}}), 'href': '{5}', 'media':[{6}] }}";
            const string fbUiTemplate = @"FB.ui({{'method': '{0}','message': '{1}',{2} 'action_links': [{3}],'user_message_prompt': '{4}'}},function (response) {{  }});";

            var attachmentBuilder = new StringBuilder();
            if (_attachment != null)
            {
                string mediaTemplates = string.Empty;
                if (_attachment.Media != null)
                {
                    mediaTemplates = string.Format(mediaEntryTemplate, _attachment.Media.Src, _attachment.Media.Href );
                }

                if (string.IsNullOrWhiteSpace(_attachment.DescriptionClientCallbackFunction))
                {
                    attachmentBuilder.AppendFormat(attachmentTemplate, _attachment.Name, _attachment.Caption,
                                                   _attachment.Description, _attachment.Href, mediaTemplates);
                }
                else
                {
                    attachmentBuilder.AppendFormat(attachmentTemplateWithDescriptionCallback, _attachment.Name,
                                                   _attachment.Caption, _attachment.DescriptionClientCallbackFunction,
                                                   _attachment.Description,
                                                   _attachment.DescriptionClientCallbackData,
                                                    _attachment.Href, mediaTemplates);
                }

                attachmentBuilder.Append(",");
            }

            var actionLinkBuilder = new StringBuilder();
            foreach(var actionLink in _actionLinks)
            {
                if(actionLinkBuilder.Length > 0)
                {
                    actionLinkBuilder.Append(",");
                }
                actionLinkBuilder.AppendFormat(actionLinkTemplate, actionLink.Text, actionLink.Href);
            }

            var built = string.Format(fbUiTemplate, _method, _message, attachmentBuilder, actionLinkBuilder, _userMessagePrompt);

            return built;
        }

        public override string ToString()
        {
            return ToJavascript();
        }
    }
}