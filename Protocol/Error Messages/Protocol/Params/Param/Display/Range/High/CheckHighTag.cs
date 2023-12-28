namespace SLDisValidator2.Tests.Protocol.Params.Param.Display.Range.High.CheckHighTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHighTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "2.33.3",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Range/High", "Param", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "If present, the 'Range/High' tag should be filled in with a numerical value." + Environment.NewLine + "Its value should be bigger than the one in the 'Range/Low' tag.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string tagValue, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHighTag,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "2.33.4",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}'. {2} {4} '{3}'.", tagValue, "Range/High", "Param", paramId, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "If present, the 'Range/High' tag should be filled in with a numerical value." + Environment.NewLine + "Its value should be bigger than the one in the 'Range/Low' tag.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedValue(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHighTag,
                ErrorId = ErrorIds.UntrimmedValue,
                FullId = "2.33.5",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Range/High", "Param", paramId, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "If present, the 'Range/High' tag should be filled in with a numerical value." + Environment.NewLine + "Its value should be bigger than the one in the 'Range/Low' tag.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult LogarithmicLowerOrEqualToZero(IValidate test, IReadable referenceNode, IReadable positionNode, string rangeHigh, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHighTag,
                ErrorId = ErrorIds.LogarithmicLowerOrEqualToZero,
                FullId = "2.33.6",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Range/High '{0}' should be bigger than zero due to Trending@logarithmic 'true'. Param ID '{1}'.", rangeHigh, paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "When Trending@logarithmic is set to 'true', both 'Range/Low' and 'Range/High' should be bigger than 0.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult WriteDifferentThanRead(IValidate test, IReadable referenceNode, IReadable positionNode, string rangeHighOnWrite, string rangeHighOnRead, string writePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHighTag,
                ErrorId = ErrorIds.WriteDifferentThanRead,
                FullId = "2.33.7",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Range/High on write Param '{0}' is different than the one on read Param '{1}'. Write PID '{2}'.", rangeHighOnWrite, rangeHighOnRead, writePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorCompare
    {
        public static IValidationResult UpdatedHighRange(IReadable referenceNode, IReadable positionNode, string previousValue, string paramPid, string newValue)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckHighTag,
                ErrorId = ErrorIds.UpdatedHighRange,
                FullId = "2.33.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("High range '{0}' in Param '{1}' decreased to '{2}'.", previousValue, paramPid, newValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult AddedHighRange(IReadable referenceNode, IReadable positionNode, string newValue, string paramPid)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckHighTag,
                ErrorId = ErrorIds.AddedHighRange,
                FullId = "2.33.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("High range '{0}' in Param '{1}' was added.", newValue, paramPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint UpdatedHighRange = 1;
        public const uint AddedHighRange = 2;
        public const uint EmptyTag = 3;
        public const uint InvalidValue = 4;
        public const uint UntrimmedValue = 5;
        public const uint LogarithmicLowerOrEqualToZero = 6;
        public const uint WriteDifferentThanRead = 7;
    }

    public static class CheckId
    {
        public const uint CheckHighTag = 33;
    }
}