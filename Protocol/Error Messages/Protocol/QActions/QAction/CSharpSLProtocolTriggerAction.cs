namespace SLDisValidator2.Tests.Protocol.QActions.QAction.CSharpSLProtocolTriggerAction
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult NonExistingActionId(IValidate test, IReadable referenceNode, IReadable positionNode, string actionId, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolTriggerAction,
                ErrorId = ErrorIds.NonExistingActionId,
                FullId = "3.5.1",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}' references a non-existing '{1}' with {2} '{3}'. QAction ID '{4}'.", "NotifyProtocol(221/*NT_RUN_ACTION*/, ...)", "Action", "ID", actionId, qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "NotifyProtocol 221 is used to trigger an action to go off." + Environment.NewLine + "Make sure to provide it with an ID of an action that exists.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint NonExistingActionId = 1;
    }

    public static class CheckId
    {
        public const uint CSharpSLProtocolTriggerAction = 5;
    }
}