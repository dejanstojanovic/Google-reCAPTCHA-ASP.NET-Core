using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using Sample.Core.GoogleReCaptcha.Web.Validation;
using Newtonsoft.Json;

namespace Sample.Core.GoogleReCaptcha.Web.Models
{
    public class Comment
    {
        [Required]
        public String Title { get; set; }

        [Required]
        public String Content { get; set; }

        [Required]
        [GoogleReCaptchaValidation]
        [BindProperty(Name = "g-recaptcha-response")]
        public String GoogleReCaptchaResponse { get; set; }
    }
}
