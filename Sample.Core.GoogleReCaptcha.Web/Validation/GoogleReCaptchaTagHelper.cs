using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;

namespace Sample.Core.GoogleReCaptcha.Web.Validation
{
    public static class GoogleReCaptchaTagHelper
    {
        public static IHtmlContent GoogleReCaptcha(this IHtmlHelper htmlHelper, String siteKey, String callback = null)
        {
            var tagBuilder = GetReCaptchaTag("div", siteKey, callback);
            return GetHtmlContent(htmlHelper, tagBuilder);
        }


        public static IHtmlContent GoogleInvisibleReCaptcha(this IHtmlHelper htmlHelper, String text,  String siteKey, String callback=null)
        {
            var tagBuilder = GetReCaptchaTag("button", siteKey, callback);
            tagBuilder.InnerHtml.Append(text);
            return GetHtmlContent(htmlHelper, tagBuilder);
        }

        private static TagBuilder GetReCaptchaTag(String tagName, String siteKey, String callback = null)
        {
            var tagBuilder = new TagBuilder(tagName);
            tagBuilder.Attributes.Add("class", "g-recaptcha");
            tagBuilder.Attributes.Add("data-sitekey", siteKey);
            if (callback != null && String.IsNullOrWhiteSpace(callback))
            {
                tagBuilder.Attributes.Add("data-callback", callback);
            }

            return tagBuilder;
        }

        private static IHtmlContent GetHtmlContent(IHtmlHelper htmlHelper,TagBuilder tagBuilder)
        {
            using (var writer = new StringWriter())
            {
                tagBuilder.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);
                var htmlOutput = writer.ToString();
                return htmlHelper.Raw(htmlOutput);
            }
        }


    }
}
