namespace SLDisValidator2.Tests.Protocol.Actions.Action.Name.CheckNameTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult DuplicatedValue(IValidate test, IReadable referenceNode, IReadable positionNode, string duplicateName, string actionIds)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameTag,
                ErrorId = ErrorIds.DuplicatedValue,
                FullId = "6.1.1",
                Category = Category.Action,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicated {0} {1} '{2}'. {0} IDs '{3}'.", "Action", "Name", duplicateName, actionIds),
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
        public const uint DuplicatedValue = 1;
    }

    public static class CheckId
    {
        public const uint CheckNameTag = 1;
    }
}