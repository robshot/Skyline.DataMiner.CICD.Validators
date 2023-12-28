namespace SLDisValidator2.Tests.Protocol.Triggers.Trigger.CheckOnTagTimeTagCombination
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult InvalidOnTagTimeTagCombination(IValidate test, IReadable referenceNode, IReadable positionNode, string onTagValue, string timeTagValue, string triggerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOnTagTimeTagCombination,
                ErrorId = ErrorIds.InvalidOnTagTimeTagCombination,
                FullId = "5.6.1",
                Category = Category.Trigger,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("The On tag value '{0}' can't be used in combination with the Time tag value '{1}'. Trigger ID '{2}'.", onTagValue, timeTagValue, triggerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult DuplicateTrigger(IValidate test, IReadable referenceNode, IReadable positionNode, Certainty certainty, string triggerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOnTagTimeTagCombination,
                ErrorId = ErrorIds.DuplicateTrigger,
                FullId = "5.6.2",
                Category = Category.Trigger,
                Severity = Severity.Minor,
                Certainty = certainty,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Multiple triggers with same Time/On combination. Trigger IDs '{0}'.", triggerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint InvalidOnTagTimeTagCombination = 1;
        public const uint DuplicateTrigger = 2;
    }

    public static class CheckId
    {
        public const uint CheckOnTagTimeTagCombination = 6;
    }
}