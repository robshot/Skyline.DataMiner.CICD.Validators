namespace SLDisValidator2.Tests.Protocol.Params.Param.Display.Positions.Position.Column.CheckColumnTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    internal static class Error
    {
        internal static IValidationResult MissingTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckColumnTag,
                ErrorId = ErrorIds.MissingTag,
                FullId = "2.44.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing tag '{0}' in {1} '{2}'.", "Position/Column", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckColumnTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "2.44.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Position/Column", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidTag(IValidate test, IReadable referenceNode, IReadable positionNode, string tagValue, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckColumnTag,
                ErrorId = ErrorIds.InvalidTag,
                FullId = "2.44.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in tag '{0}'. Possible values '{2}'. {3} {4} '{5}'.", "Position/Column", tagValue, "0, 1", "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
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
                CheckId = CheckId.CheckColumnTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "2.44.4",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Position/Column", "Param", pid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UnrecommendedValue(IValidate test, IReadable referenceNode, IReadable positionNode, string pageName, string paramIDs)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckColumnTag,
                ErrorId = ErrorIds.UnrecommendedValue,
                FullId = "2.44.5",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Uncertain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unrecommended use of more than 2 columns. Page '{0}'. Param IDs '{1}'.", pageName, paramIDs),
                HowToFix = "",
                ExampleCode = "",
                Details = "Skyline considers it good practice to use 1 column for pages containing tables and 2 columns for pages containing only standalone parameters." + Environment.NewLine + "However, some exceptions can some times be made.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MissingTag = 1;
        public const uint EmptyTag = 2;
        public const uint InvalidTag = 3;
        public const uint UntrimmedTag = 4;
        public const uint UnrecommendedValue = 5;
    }

    public static class CheckId
    {
        public const uint CheckColumnTag = 44;
    }
}