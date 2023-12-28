namespace SLDisValidator2.Tests.Protocol.Params.Param.ArrayOptions.ColumnOption.CheckPidAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPidAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "2.63.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' in {1} '{2}'.", "ColumnOption@pid", "table", tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The ColumnOption@pid attribute is mandatory and should be filled in with the ID of an existing column Param.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPidAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "2.63.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "ColumnOption@pid", "Param", tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The ColumnOption@pid attribute is mandatory and should be filled in with the ID of an existing column Param.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPidAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "2.63.3",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "ColumnOption@pid", "Table", tablePid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The ColumnOption@pid attribute is mandatory and should be filled in with the ID of an existing column Param.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingParam(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPidAttribute,
                ErrorId = ErrorIds.NonExistingParam,
                FullId = "2.63.4",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "ColumnOption@pid", "column", "PID", columnPid, "Table", "PID", tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The ColumnOption@pid attribute is mandatory and should be filled in with the ID of an existing column Param.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint MissingAttribute = 1;
        public const uint EmptyAttribute = 2;
        public const uint UntrimmedAttribute = 3;
        public const uint NonExistingParam = 4;
    }

    public static class CheckId
    {
        public const uint CheckPidAttribute = 63;
    }
}