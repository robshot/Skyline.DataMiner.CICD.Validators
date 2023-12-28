namespace SLDisValidatorUnitTests.Protocol.Params.Param.Interprete.Exceptions.Exception.CheckValueAttribute
{
    using System;
    using System.Collections.Generic;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;
    using SLDisValidator2.Tests.Protocol.Params.Param.Interprete.Exceptions.Exception.CheckValueAttribute;

    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    [TestClass]
    public class Validate
    {
        private readonly IValidate check = new CheckValueAttribute();

        #region Valid Checks

        [TestMethod]
        public void Param_CheckValueAttribute_Valid()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Valid,
                FileName = "Valid",
                ExpectedResults = new List<IValidationResult>()
            };

            Generic.Validate(check, data);
        }

        #endregion

        #region Invalid Checks

        [TestMethod]
        public void Param_CheckValueAttribute_MissingAttribute()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "MissingAttribute",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.MissingAttribute(null, null, null, "1"),

                    Error.MissingAttribute(null, null, null, "2"),
                    Error.MissingAttribute(null, null, null, "2"),
                }
            };

            Generic.Validate(check, data);
        }

        [TestMethod]
        public void Param_CheckValueAttribute_ValueIncompatibleWithInterpreteType()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "ValueIncompatibleWithInterpreteType",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.ValueIncompatibleWithInterpreteType(null, null, null, "abc", "double", "100"),
                }
            };

            Generic.Validate(check, data);
        }

        #endregion
    }

    [TestClass]
    public class ErrorMessages
    {
        [TestMethod]
        public void Param_CheckValueAttribute_MissingAttribute()
        {
            // Create ErrorMessage
            var message = Error.MissingAttribute(null, null, null, "paramId");
                        
            var expected = new ValidationResult
            {
                ErrorId = 1,
                FullId = "2.70.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "Missing attribute 'Exception@value' in Param 'paramId'.",
                HowToFix = "",
                ExampleCode = "",
                Details = "For each exception, the Exception@value attribute is required in order to define the incoming value that should be interpreted as exceptional." + Environment.NewLine + "The value should be compliant with the defined Param/Interprete/Type.",
                HasCodeFix = false,
            };

            // Assert
            message.Should().BeEquivalentTo(expected, Generic.ExcludePropertiesForErrorMessages);
        }
    }

    [TestClass]
    public class Attribute
    {
        private readonly IRoot check = new CheckValueAttribute();

        [TestMethod]
        public void Param_CheckValueAttribute_CheckCategory() => Generic.CheckCategory(check, Category.Param);

        [TestMethod]
        public void Param_CheckValueAttribute_CheckId() => Generic.CheckId(check, CheckId.CheckValueAttribute);
    }
}