namespace SLDisValidator2.Tests.Protocol.Pairs.Pair.Content.CheckContentTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult MissingClearResponseRoutine(IValidate test, IReadable referenceNode, IReadable positionNode, string pairId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckContentTag,
                ErrorId = ErrorIds.MissingClearResponseRoutine,
                FullId = "9.2.1",
                Category = Category.Pair,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Missing clear response routine for pair '{0}'.", pairId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Typically when a pair contains multiple responses, a clear response routine needs to be implemented in order to make sure parameters gets updated correctly." + Environment.NewLine + "There are 2 possible ways to implement the clear routine." + Environment.NewLine + "However, the first one is recommended as it is more efficient." + Environment.NewLine + "    - Recommended way: After response X, clear all other responses present in the same pair." + Environment.NewLine + "    - Alternative way: After response X, clear response X.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingClearResponseRoutine_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string responseIdToClear, string responseIdOnWhichToTrigger)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckContentTag,
                ErrorId = ErrorIds.MissingClearResponseRoutine_Sub,
                FullId = "9.2.2",
                Category = Category.Pair,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Missing clear response '{0}' routine after response '{1}'.", responseIdToClear, responseIdOnWhichToTrigger),
                HowToFix = "",
                ExampleCode = "",
                Details = "Typically when a pair contains multiple responses, a clear response routine needs to be implemented in order to make sure parameters gets updated correctly." + Environment.NewLine + "There are 2 possible ways to implement the clear routine." + Environment.NewLine + "However, the first one is recommended as it is more efficient." + Environment.NewLine + "    - Recommended way: After response X, clear all other responses present in the same pair." + Environment.NewLine + "    - Alternative way: After response X, clear response X.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MissingClearResponseRoutine = 1;
        public const uint MissingClearResponseRoutine_Sub = 2;
    }

    public static class CheckId
    {
        public const uint CheckContentTag = 2;
    }
}