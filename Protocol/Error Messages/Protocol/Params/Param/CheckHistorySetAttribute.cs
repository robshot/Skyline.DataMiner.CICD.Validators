namespace SLDisValidator2.Tests.Protocol.Params.Param.CheckHistorySetAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;

    internal static class ErrorCompare
    {
        internal static IValidationResult EnabledHistorySet(IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckHistorySetAttribute,
                ErrorId = ErrorIds.EnabledHistorySet,
                FullId = "2.29.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("HistorySet attribute was enabled on Param '{0}'.", paramId),
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
        public const uint EnabledHistorySet = 1;
    }

    public static class CheckId
    {
        public const uint CheckHistorySetAttribute = 29;
    }
}