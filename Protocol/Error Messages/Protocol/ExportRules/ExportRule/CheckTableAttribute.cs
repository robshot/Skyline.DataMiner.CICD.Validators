namespace SLDisValidator2.Tests.Protocol.ExportRules.ExportRule.CheckTableAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTableAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "17.1.1",
                Category = Category.ExportRule,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}@{1}' references a non-existing '{2}' with {3} '{4}'.", "ExportRule", "table", "Table", "PID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Make sure every attribute that links to a parameter is configured correctly and links to an existing parameter id.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTableAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "17.1.2",
                Category = Category.ExportRule,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}'.", "ExportRule@table"),
                HowToFix = "",
                ExampleCode = "",
                Details = "Make sure every attribute that links to a parameter is configured correctly and links to an existing parameter id. ",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string tableValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTableAttribute,
                ErrorId = ErrorIds.InvalidAttribute,
                FullId = "17.1.3",
                Category = Category.ExportRule,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'.", "ExportRule@table", tableValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Make sure every attribute that links to a parameter is configured correctly and links to an existing parameter id. ",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTableAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "17.1.4",
                Category = Category.ExportRule,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}'.", "ExportRule@table"),
                HowToFix = "",
                ExampleCode = "",
                Details = "Make sure every attribute that links to a parameter is configured correctly and links to an existing parameter id. ",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint NonExistingId = 1;
        public const uint MissingAttribute = 2;
        public const uint InvalidAttribute = 3;
        public const uint EmptyAttribute = 4;
    }

    public static class CheckId
    {
        public const uint CheckTableAttribute = 1;
    }
}