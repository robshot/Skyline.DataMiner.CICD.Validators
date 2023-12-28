namespace SLDisValidator2.Tests.Protocol.TreeControls.TreeControl.CheckParameterIdAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParameterIdAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "18.1.1",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}'.", "TreeControl@parameterId"),
                HowToFix = "",
                ExampleCode = "",
                Details = "TreeControl@parameterId attribute should contain the PID of a parameter which will be used to define where to display the TreeControl." + Environment.NewLine + "Such TreeControl parameter is expected to have:" + Environment.NewLine + "- 'Param\\Type' tag set to 'dummy' (or alternatively 'read' but 'dummy' is preferred)." + Environment.NewLine + "- 'Param\\Display\\RTDisplay' tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParameterIdAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "18.1.2",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}'.", "TreeControl@parameterId"),
                HowToFix = "",
                ExampleCode = "",
                Details = "TreeControl@parameterId attribute should contain the PID of a parameter which will be used to define where to display the TreeControl." + Environment.NewLine + "Such TreeControl parameter is expected to have:" + Environment.NewLine + "- 'Param\\Type' tag set to 'dummy' (or alternatively 'read' but 'dummy' is preferred)." + Environment.NewLine + "- 'Param\\Display\\RTDisplay' tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string currentValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParameterIdAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "18.1.3",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}'. Current value '{1}'.", "TreeControl@parameterId", currentValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "TreeControl@parameterId attribute should contain the PID of a parameter which will be used to define where to display the TreeControl." + Environment.NewLine + "Such TreeControl parameter is expected to have:" + Environment.NewLine + "- 'Param\\Type' tag set to 'dummy' (or alternatively 'read' but 'dummy' is preferred)." + Environment.NewLine + "- 'Param\\Display\\RTDisplay' tag set to 'true'.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string invalidValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParameterIdAttribute,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "18.1.4",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'.", "TreeControl@parameterId", invalidValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "TreeControl@parameterId attribute should contain the PID of a parameter which will be used to define where to display the TreeControl." + Environment.NewLine + "Such TreeControl parameter is expected to have:" + Environment.NewLine + "- 'Param\\Type' tag set to 'dummy' (or alternatively 'read' but 'dummy' is preferred)." + Environment.NewLine + "- 'Param\\Display\\RTDisplay' tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParameterIdAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "18.1.5",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}@{1}' references a non-existing '{2}' with {3} '{4}'.", "TreeControl", "parameterId", "Param", "ID", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "TreeControl@parameterId attribute should contain the PID of a parameter which will be used to define where to display the TreeControl." + Environment.NewLine + "Such TreeControl parameter is expected to have:" + Environment.NewLine + "- 'Param\\Type' tag set to 'dummy' (or alternatively 'read' but 'dummy' is preferred)." + Environment.NewLine + "- 'Param\\Display\\RTDisplay' tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ReferencedParamWrongType(IValidate test, IReadable referenceNode, IReadable positionNode, string paramType, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParameterIdAttribute,
                ErrorId = ErrorIds.ReferencedParamWrongType,
                FullId = "18.1.6",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid TreeControl Param Type '{0}'. Expected Type 'dummy'. Param ID '{1}'.", paramType, paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "TreeControl@parameterId attribute should contain the PID of a parameter which will be used to define where to display the TreeControl." + Environment.NewLine + "Such TreeControl parameter is expected to have:" + Environment.NewLine + "- 'Param\\Type' tag set to 'dummy' (or alternatively 'read' but 'dummy' is preferred)." + Environment.NewLine + "- 'Param\\Display\\RTDisplay' tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ReferencedParamExpectingRTDisplay(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParameterIdAttribute,
                ErrorId = ErrorIds.ReferencedParamExpectingRTDisplay,
                FullId = "18.1.7",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on TreeControl Param. Param ID '{0}'.", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "TreeControl@parameterId attribute should contain the PID of a parameter which will be used to define where to display the TreeControl." + Environment.NewLine + "Such TreeControl parameter is expected to have:" + Environment.NewLine + "- 'Param\\Type' tag set to 'dummy' (or alternatively 'read' but 'dummy' is preferred)." + Environment.NewLine + "- 'Param\\Display\\RTDisplay' tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint MissingAttribute = 1;
        public const uint EmptyAttribute = 2;
        public const uint UntrimmedAttribute = 3;
        public const uint InvalidValue = 4;
        public const uint NonExistingId = 5;
        public const uint ReferencedParamWrongType = 6;
        public const uint ReferencedParamExpectingRTDisplay = 7;
    }

    public static class CheckId
    {
        public const uint CheckParameterIdAttribute = 1;
    }
}