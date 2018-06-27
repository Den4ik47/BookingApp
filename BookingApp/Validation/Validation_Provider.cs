using BookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookingApp.Validation
{
    public class ValidationsProvider : ModelValidatorProvider
    {
        public override IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ControllerContext context)
        {
            if (metadata.ContainerType == typeof(Authorizates))
            {
                return new ModelValidator[] { new AuthorizatesPropertyValidator(metadata, context) };
            }

            if (metadata.ModelType == typeof(Authorizates))
            {
                return new ModelValidator[] { new AuthorizatesValidator(metadata, context) };
            }

            return Enumerable.Empty<ModelValidator>();
        }
    }
    public class AuthorizatesPropertyValidator : ModelValidator
        {
            public AuthorizatesPropertyValidator(ModelMetadata metadata, ControllerContext controllerContext) : base(metadata, controllerContext)
            {
            }

            public override IEnumerable<ModelValidationResult> Validate(object container)
            {
            Authorizates b = container as Authorizates;
                if (b != null)
                {
                    switch (Metadata.PropertyName)
                    {
                        case "Name":
                            if (string.IsNullOrEmpty(b.Name))
                            {
                                return new ModelValidationResult[]{
                            new ModelValidationResult { MemberName="", Message="Enter book name"}
                        };
                            }
                            break;
                        case "Surname":
                            if (string.IsNullOrEmpty(b.Surname))
                            {
                                return new ModelValidationResult[]{
                            new ModelValidationResult { MemberName="", Message="Enter book author"}
                        };
                            }
                            break;
                        case "Password":
                            if ( string.IsNullOrEmpty(b.Password))
                            {
                                return new ModelValidationResult[]{
                            new ModelValidationResult { MemberName="", Message="Enter Pass"}
                        };
                            }
                            break;
                    }
                }
                return Enumerable.Empty<ModelValidationResult>();
            }
        }
    public class AuthorizatesValidator : ModelValidator
    {
        public AuthorizatesValidator(ModelMetadata metadata, ControllerContext context)
            : base(metadata, context)
        { }

        public override IEnumerable<ModelValidationResult> Validate(object container)
        {
            Authorizates b = (Authorizates)Metadata.Model;

            List<ModelValidationResult> errors = new List<ModelValidationResult>();

            if (b.Name == "1" && b.Surname == "2" && b.Password.Length==6)
            {
                errors.Add(new ModelValidationResult { MemberName = "", Message = "Unavailable book" });
            }
            return errors;
        }
    }
}
