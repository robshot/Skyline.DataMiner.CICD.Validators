namespace SLDisValidatorUnitTests.Protocol.Params.Param.Interprete.LengthType.CheckIdAttribute
{
    using System.Collections.Generic;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;
    using SLDisValidator2.Tests.Protocol.Params.Param.Interprete.LengthType.CheckIdAttribute;

    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    [TestClass]
    public class Validate
    {
        private readonly IValidate check = new CheckIdAttribute();

        #region Valid Checks

        [TestMethod]
        public void Param_CheckIdAttribute_Valid()
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
        public void Param_CheckIdAttribute_EmptyAttribute()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "EmptyAttribute",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.EmptyAttribute(null, null, null, "1"),    // Empty
                    Error.EmptyAttribute(null, null, null, "2"),    // Spaces
                }
            };

            Generic.Validate(check, data);
        }

        [TestMethod]
        public void Param_CheckIdAttribute_MissingAttribute()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "MissingAttribute",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.MissingAttribute(null, null, null, "200"),
                }
            };

            Generic.Validate(check, data);
        }

        [TestMethod]
        public void Param_CheckIdAttribute_NonExistingId()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "NonExistingId",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.NonExistingId(null, null, null, "1", "200"),
                }
            };

            Generic.Validate(check, data);
        }

        [TestMethod]
        public void Param_CheckIdAttribute_ReferencedParamWrongInterpreteType()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "ReferencedParamWrongInterpreteType",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.ReferencedParamWrongInterpreteType(null, null, null, "string", "1"),
                }
            };

            Generic.Validate(check, data);
        }

        [TestMethod]
        public void Param_CheckIdAttribute_UntrimmedAttribute()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "UntrimmedAttribute",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.UntrimmedAttribute(null, null, null, "200", " 1"),
                }
            };

            Generic.Validate(check, data);
        }

        #endregion
    }

    [TestClass]
    public class CodeFix
    {
        private readonly ICodeFix check = new CheckIdAttribute();

        [TestMethod]
        public void Param_CheckIdAttribute_UntrimmedAttribute()
        {
            Generic.FixData data = new Generic.FixData
            {
                FileNameBase = "UntrimmedAttribute",
            };

            Generic.Fix(check, data);
        }
    }

    [TestClass]
    public class ErrorMessages
    {
        [TestMethod]
        public void Param_CheckIdAttribute_EmptyAttribute()
        {
            // Create ErrorMessage
            var message = Error.EmptyAttribute(null, null, null, "paramId");
                        
            var expected = new ValidationResult
            {
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "Empty attribute 'Interprete/LengthType@id' in Param 'paramId'.",
                Details = "When Interprete/LengthType tag is set to 'other param', the id attribute should be added to it and should refer to the id of an existing parameter of Interprete/Type double.",
                HasCodeFix = false,
            };

            // Assert
            message.Should().BeEquivalentTo(expected, Generic.ExcludePropertiesForErrorMessages);
        }

        [TestMethod]
        public void Param_CheckIdAttribute_MissingAttribute()
        {
            // Create ErrorMessage
            var message = Error.MissingAttribute(null, null, null, "paramId");
                        
            var expected = new ValidationResult
            {
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "Missing attribute 'Interprete/LengthType@id' due to 'LengthType' 'other param'. Param ID 'paramId'.",
                Details = "When Interprete/LengthType tag is set to 'other param', the id attribute should be added to it and should refer to the id of an existing parameter of Interprete/Type double.",
                HasCodeFix = false,
            };

            // Assert
            message.Should().BeEquivalentTo(expected, Generic.ExcludePropertiesForErrorMessages);
        }

        [TestMethod]
        public void Param_CheckIdAttribute_NonExistingId()
        {
            // Create ErrorMessage
            var message = Error.NonExistingId(null, null, null, "nonExistingParamId", "paramId");
                        
            var expected = new ValidationResult
            {
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "Attribute 'Interprete/LengthType@id' references a non-existing 'Param' with ID 'nonExistingParamId'. Param ID 'paramId'.",
                Details = "When Interprete/LengthType tag is set to 'other param', the id attribute should be added to it and should refer to the id of an existing parameter of Interprete/Type double.",
                HasCodeFix = false,
            };

            // Assert
            message.Should().BeEquivalentTo(expected, Generic.ExcludePropertiesForErrorMessages);
        }

        [TestMethod]
        public void Param_CheckIdAttribute_UntrimmedAttribute()
        {
            // Create ErrorMessage
            var message = Error.UntrimmedAttribute(null, null, null, "paramId", "untrimmedValue");
                        
            var expected = new ValidationResult
            {
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "Untrimmed attribute 'id' in Param 'paramId'. Current value 'untrimmedValue'.",
                Details = "When Interprete/LengthType tag is set to 'other param', the id attribute should be added to it and should refer to the id of an existing parameter of Interprete/Type double.",
                HasCodeFix = true,
            };

            // Assert
            message.Should().BeEquivalentTo(expected, Generic.ExcludePropertiesForErrorMessages);
        }

        [TestMethod]
        public void Param_CheckIdAttribute_ReferencedParamWrongInterpreteType()
        {
            // Create ErrorMessage
            var message = Error.ReferencedParamWrongInterpreteType(null, null, null, "interpreteType", "2");
                        
            var expected = new ValidationResult
            {
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "Invalid Interprete/Type 'interpreteType' on Param referenced by Interprete/LengthType@id. Expected value 'double'. Param ID '2'.",
                Details = "When Interprete/LengthType tag is set to 'other param', the id attribute should be added to it and should refer to the id of an existing parameter of Interprete/Type double.",
                HasCodeFix = false,
            };

            // Assert
            message.Should().BeEquivalentTo(expected, Generic.ExcludePropertiesForErrorMessages);
        }
    }

    [TestClass]
    public class Attribute
    {
        private readonly IRoot check = new CheckIdAttribute();

        [TestMethod]
        public void Param_CheckIdAttribute_CheckCategory() => Generic.CheckCategory(check, Category.Param);

        [TestMethod]
        public void Param_CheckIdAttribute_CheckId() => Generic.CheckId(check, CheckId.CheckIdAttribute);
    }
}