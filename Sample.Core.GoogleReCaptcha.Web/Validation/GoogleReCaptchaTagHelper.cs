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
            var tagBuilder = new TagBuilder("div");
            tagBuilder.Attributes.Add("class", "g-recaptcha");
            tagBuilder.Attributes.Add("data-sitekey", siteKey);
            if (callback != null && String.IsNullOrWhiteSpace(callback))
            {
                tagBuilder.Attributes.Add("data-callback", callback);
            }
            using (var writer = new StringWriter())
            {
                tagBuilder.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);
                var htmlOutput = writer.ToString();
                return htmlHelper.Raw(htmlOutput);
            }
        }
    }
}
