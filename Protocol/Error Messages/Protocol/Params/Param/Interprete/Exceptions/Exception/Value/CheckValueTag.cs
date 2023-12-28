namespace SLDisValidator2.Tests.Protocol.Params.Param.Interprete.Exceptions.Exception.Value.CheckValueTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult MissingTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckValueTag,
                ErrorId = ErrorIds.MissingTag,
                FullId = "2.71.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing tag '{0}' in {1} '{2}'.", "Exception/Value", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "For each exception, the Exception/Value tag is required in order to define the value that should be stored in memory and database." + Environment.NewLine + "The value should be compliant with the defined Param/Interprete/Type.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckValueTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "2.71.2",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Exception/Value", "Param", pid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "For each exception, the Exception/Value tag is required in order to define the value that should be stored in memory and database." + Environment.NewLine + "The value should be compliant with the defined Param/Interprete/Type.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ValueIncompatibleWithInterpreteType(IValidate test, IReadable referenceNode, IReadable positionNode, string exceptionValue, string interpreteType, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckValueTag,
                ErrorId = ErrorIds.ValueIncompatibleWithInterpreteType,
                FullId = "2.71.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Incompatible '{0}' value '{1}' with '{2}' value '{3}'. {4} {5} '{6}'.", "Exception/Value", exceptionValue, "Interprete/Type", interpreteType, "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "For each exception, the Exception/Value tag is required in order to define the value that should be stored in memory and database." + Environment.NewLine + "The value should be compliant with the defined Param/Interprete/Type.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MissingTag = 1;
        public const uint UntrimmedTag = 2;
        public const uint ValueIncompatibleWithInterpreteType = 3;
    }

    public static class CheckId
    {
        public const uint CheckValueTag = 71;
    }
}