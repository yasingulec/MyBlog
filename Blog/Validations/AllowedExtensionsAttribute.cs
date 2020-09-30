using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Validations
{
    public class AllowedExtensionsAttribute : ValidationAttribute
    {
        private readonly string[] _extension;
        public AllowedExtensionsAttribute(string[] extensions)
        {
            _extension = extensions;
        }
        string extension = string.Empty;
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                 extension = Path.GetExtension(file.FileName);
                if (!_extension.Contains(extension.ToLower()))
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }
            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return $"This photo's extension type {extension} is not allowed!";
        }
    }
}
