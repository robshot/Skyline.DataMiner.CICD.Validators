namespace SLDisValidator2.Tests.Protocol.QActions.QAction.CheckNameAttribute
{
    using System;
    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    public static class Error
    {
        public static IValidationResult DuplicatedValue(IValidate test, IReadable referenceNode, IReadable positionNode, string duplicateName, string qactionIds)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameAttribute,
                ErrorId = ErrorIds.DuplicatedValue,
                FullId = "3.1.1",
                Category = Category.QAction,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicated {0} {1} '{2}'. {0} IDs '{3}'.", "QAction", "Name", duplicateName, qactionIds),
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
        public const uint CheckNameAttribute = 1;
    }
}