namespace SLDisValidator2.Tests.Protocol.Params.Param.Alarm.Monitored.CheckDisabledIfAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisabledIfAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "2.72.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "Monitored@disabledIf", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Monitored@disabledIf attribute should follow the following format 'pid,value' where:" + Environment.NewLine + "- pid: refers to the ID of an existing parameter." + Environment.NewLine + "  The referenced Param is expected to:" + Environment.NewLine + "    - Have RTDisplay tag set to 'true'." + Environment.NewLine + "- value: correspond to the value of the referenced parameter which will cause the monitoring to be disabled." + Environment.NewLine + "  When using discreet values, it is only possible to set a condition on the discreet value, not on the display value.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisabledIfAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "2.72.2",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "Monitored@disabledIf", "Param", pid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Monitored@disabledIf attribute should follow the following format 'pid,value' where:" + Environment.NewLine + "- pid: refers to the ID of an existing parameter." + Environment.NewLine + "  The referenced Param is expected to:" + Environment.NewLine + "    - Have RTDisplay tag set to 'true'." + Environment.NewLine + "- value: correspond to the value of the referenced parameter which will cause the monitoring to be disabled." + Environment.NewLine + "  When using discreet values, it is only possible to set a condition on the discreet value, not on the display value.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string attributeValue, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisabledIfAttribute,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "2.72.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. {2} {4} '{3}'.", "Monitored@disabledIf", attributeValue, "Param", pid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "Monitored@disabledIf attribute should follow the following format 'pid,value' where:" + Environment.NewLine + "- pid: refers to the ID of an existing parameter." + Environment.NewLine + "  The referenced Param is expected to:" + Environment.NewLine + "    - Have RTDisplay tag set to 'true'." + Environment.NewLine + "- value: correspond to the value of the referenced parameter which will cause the monitoring to be disabled." + Environment.NewLine + "  When using discreet values, it is only possible to set a condition on the discreet value, not on the display value.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string referencedPid, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisabledIfAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "2.72.4",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Monitored@disabledIf", "Param", "ID", referencedPid, "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Monitored@disabledIf attribute should follow the following format 'pid,value' where:" + Environment.NewLine + "- pid: refers to the ID of an existing parameter." + Environment.NewLine + "  The referenced Param is expected to:" + Environment.NewLine + "    - Have RTDisplay tag set to 'true'." + Environment.NewLine + "- value: correspond to the value of the referenced parameter which will cause the monitoring to be disabled." + Environment.NewLine + "  When using discreet values, it is only possible to set a condition on the discreet value, not on the display value.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ReferencedParamWrongType(IValidate test, IReadable referenceNode, IReadable positionNode, string referencedParamType, string referencedPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisabledIfAttribute,
                ErrorId = ErrorIds.ReferencedParamWrongType,
                FullId = "2.72.5",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid Param Type '{0}' on Param referenced by a 'Monitored@disabledIf' attribute. Param ID '{1}'.", referencedParamType, referencedPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Monitored@disabledIf attribute should follow the following format 'pid,value' where:" + Environment.NewLine + "- pid: refers to the ID of an existing parameter." + Environment.NewLine + "  The referenced Param is expected to:" + Environment.NewLine + "    - Have RTDisplay tag set to 'true'." + Environment.NewLine + "- value: correspond to the value of the referenced parameter which will cause the monitoring to be disabled." + Environment.NewLine + "  When using discreet values, it is only possible to set a condition on the discreet value, not on the display value.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ReferencedParamRTDisplayExpected(IValidate test, IReadable referenceNode, IReadable positionNode, string referencedPid, string referencingPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisabledIfAttribute,
                ErrorId = ErrorIds.ReferencedParamRTDisplayExpected,
                FullId = "2.72.6",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on Param '{0}' referenced by a 'Monitored@disabledIf' attribute. Param ID '{1}'.", referencedPid, referencingPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Monitored@disabledIf attribute should follow the following format 'pid,value' where:" + Environment.NewLine + "- pid: refers to the ID of an existing parameter." + Environment.NewLine + "  The referenced Param is expected to:" + Environment.NewLine + "    - Have RTDisplay tag set to 'true'." + Environment.NewLine + "- value: correspond to the value of the referenced parameter which will cause the monitoring to be disabled." + Environment.NewLine + "  When using discreet values, it is only possible to set a condition on the discreet value, not on the display value.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint EmptyAttribute = 1;
        public const uint UntrimmedAttribute = 2;
        public const uint InvalidValue = 3;
        public const uint NonExistingId = 4;
        public const uint ReferencedParamWrongType = 5;
        public const uint ReferencedParamRTDisplayExpected = 6;
    }

    public static class CheckId
    {
        public const uint CheckDisabledIfAttribute = 72;
    }
}