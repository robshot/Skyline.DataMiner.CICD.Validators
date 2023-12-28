namespace SLDisValidator2.Tests.Protocol.QActions.QAction.CSharpNotifyProtocolNTSnmpGet
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult DeltIncompatible(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpNotifyProtocolNTSnmpGet,
                ErrorId = ErrorIds.DeltIncompatible,
                FullId = "3.30.1",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invocation of method '{0}.{1}' is not compatible with '{2}'. QAction ID '{3}'.", "SLProtocol", "NotifyProtocol(295/*NT_SNMP_GET*/, ...)", "DELT", qactionId),
                HowToFix = "",
                ExampleCode = "object[] elementInfo = new object[] { elementId, ipPort, multipleGet, instance, connectionId, getCommunityString, splitErrors, agentId };" + Environment.NewLine + "string[] oidInfo = new string[] { \"1.3.6.1.2.1.1.4.0\" };" + Environment.NewLine + "" + Environment.NewLine + "object[] result = (object[])protocol.NotifyProtocol(295/*NT_SNMP_GET*/, elementInfo, oidInfo);",
                Details = "To make this call DELT compatible, the DMA ID needs to be provided as argument." + Environment.NewLine + "See Example code." + Environment.NewLine + "" + Environment.NewLine + "More information about the syntax can be found in the DataMiner Development Library.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint DeltIncompatible = 1;
    }

    public static class CheckId
    {
        public const uint CSharpNotifyProtocolNTSnmpGet = 30;
    }
}