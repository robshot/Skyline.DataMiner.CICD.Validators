namespace SLDisValidator2.Tests.Protocol.Triggers.Trigger.On.CheckIdAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string triggerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "5.1.1",
                Category = Category.Trigger,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' in {1} '{2}'.", "On@id", "Trigger", triggerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "When triggering on:" + Environment.NewLine + "  - parameter" + Environment.NewLine + "  - command" + Environment.NewLine + "  - response" + Environment.NewLine + "  - pair" + Environment.NewLine + "  - group" + Environment.NewLine + "  - timer" + Environment.NewLine + "  - session" + Environment.NewLine + "A 'Trigger/On@id' attribute is expected and should have one of the following values:" + Environment.NewLine + "  - 'each': in this case, the protocol should have at least one item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "  - The ID of an item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "" + Environment.NewLine + "When triggering on:" + Environment.NewLine + "  - protocol" + Environment.NewLine + "  - communication" + Environment.NewLine + "No 'Trigger/On@id' attribute is expected.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ExcessiveAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string onTagValue, string triggerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.ExcessiveAttribute,
                FullId = "5.1.2",
                Category = Category.Trigger,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Excessive 'id' Attribute in tag 'On' with value '{0}'. Trigger ID '{1}'.", onTagValue, triggerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "When triggering on:" + Environment.NewLine + "  - parameter" + Environment.NewLine + "  - command" + Environment.NewLine + "  - response" + Environment.NewLine + "  - pair" + Environment.NewLine + "  - group" + Environment.NewLine + "  - timer" + Environment.NewLine + "  - session" + Environment.NewLine + "A 'Trigger/On@id' attribute is expected and should have one of the following values:" + Environment.NewLine + "  - 'each': in this case, the protocol should have at least one item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "  - The ID of an item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "" + Environment.NewLine + "When triggering on:" + Environment.NewLine + "  - protocol" + Environment.NewLine + "  - communication" + Environment.NewLine + "No 'Trigger/On@id' attribute is expected.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "5.1.3",
                Category = Category.Trigger,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}'.", "id"),
                HowToFix = "",
                ExampleCode = "",
                Details = "When triggering on:" + Environment.NewLine + "  - parameter" + Environment.NewLine + "  - command" + Environment.NewLine + "  - response" + Environment.NewLine + "  - pair" + Environment.NewLine + "  - group" + Environment.NewLine + "  - timer" + Environment.NewLine + "  - session" + Environment.NewLine + "A 'Trigger/On@id' attribute is expected and should have one of the following values:" + Environment.NewLine + "  - 'each': in this case, the protocol should have at least one item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "  - The ID of an item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "" + Environment.NewLine + "When triggering on:" + Environment.NewLine + "  - protocol" + Environment.NewLine + "  - communication" + Environment.NewLine + "No 'Trigger/On@id' attribute is expected.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MultipleIds(IValidate test, IReadable referenceNode, IReadable positionNode, string triggerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.MultipleIds,
                FullId = "5.1.4",
                Category = Category.Trigger,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute 'On@id' cannot have multiple values. Trigger ID '{0}'.", triggerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "When triggering on:" + Environment.NewLine + "  - parameter" + Environment.NewLine + "  - command" + Environment.NewLine + "  - response" + Environment.NewLine + "  - pair" + Environment.NewLine + "  - group" + Environment.NewLine + "  - timer" + Environment.NewLine + "  - session" + Environment.NewLine + "A 'Trigger/On@id' attribute is expected and should have one of the following values:" + Environment.NewLine + "  - 'each': in this case, the protocol should have at least one item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "  - The ID of an item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "" + Environment.NewLine + "When triggering on:" + Environment.NewLine + "  - protocol" + Environment.NewLine + "  - communication" + Environment.NewLine + "No 'Trigger/On@id' attribute is expected.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string attributeValue, string allowedValues)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "5.1.5",
                Category = Category.Trigger,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. Possible values '{2}'.", "id", attributeValue, allowedValues),
                HowToFix = "",
                ExampleCode = "",
                Details = "When triggering on:" + Environment.NewLine + "  - parameter" + Environment.NewLine + "  - command" + Environment.NewLine + "  - response" + Environment.NewLine + "  - pair" + Environment.NewLine + "  - group" + Environment.NewLine + "  - timer" + Environment.NewLine + "  - session" + Environment.NewLine + "A 'Trigger/On@id' attribute is expected and should have one of the following values:" + Environment.NewLine + "  - 'each': in this case, the protocol should have at least one item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "  - The ID of an item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "" + Environment.NewLine + "When triggering on:" + Environment.NewLine + "  - protocol" + Environment.NewLine + "  - communication" + Environment.NewLine + "No 'Trigger/On@id' attribute is expected.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string referenceKind, string referenceId, string triggerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "5.1.6",
                Category = Category.Trigger,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "On@id", referenceKind, "ID", referenceId, "Trigger", "ID", triggerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "When triggering on:" + Environment.NewLine + "  - parameter" + Environment.NewLine + "  - command" + Environment.NewLine + "  - response" + Environment.NewLine + "  - pair" + Environment.NewLine + "  - group" + Environment.NewLine + "  - timer" + Environment.NewLine + "  - session" + Environment.NewLine + "A 'Trigger/On@id' attribute is expected and should have one of the following values:" + Environment.NewLine + "  - 'each': in this case, the protocol should have at least one item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "  - The ID of an item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "" + Environment.NewLine + "When triggering on:" + Environment.NewLine + "  - protocol" + Environment.NewLine + "  - communication" + Environment.NewLine + "No 'Trigger/On@id' attribute is expected.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult LeadingZeros(IValidate test, IReadable referenceNode, IReadable positionNode, string triggerId, string attributeValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.LeadingZeros,
                FullId = "5.1.7",
                Category = Category.Trigger,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid use of leading zeros on 'On@id' attribute. Trigger ID '{0}'. Current value '{1}'.", triggerId, attributeValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "When triggering on:" + Environment.NewLine + "  - parameter" + Environment.NewLine + "  - command" + Environment.NewLine + "  - response" + Environment.NewLine + "  - pair" + Environment.NewLine + "  - group" + Environment.NewLine + "  - timer" + Environment.NewLine + "  - session" + Environment.NewLine + "A 'Trigger/On@id' attribute is expected and should have one of the following values:" + Environment.NewLine + "  - 'each': in this case, the protocol should have at least one item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "  - The ID of an item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "" + Environment.NewLine + "When triggering on:" + Environment.NewLine + "  - protocol" + Environment.NewLine + "  - communication" + Environment.NewLine + "No 'Trigger/On@id' attribute is expected.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string attributeValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "5.1.8",
                Category = Category.Trigger,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}'. Current value '{1}'.", "id", attributeValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "When triggering on:" + Environment.NewLine + "  - parameter" + Environment.NewLine + "  - command" + Environment.NewLine + "  - response" + Environment.NewLine + "  - pair" + Environment.NewLine + "  - group" + Environment.NewLine + "  - timer" + Environment.NewLine + "  - session" + Environment.NewLine + "A 'Trigger/On@id' attribute is expected and should have one of the following values:" + Environment.NewLine + "  - 'each': in this case, the protocol should have at least one item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "  - The ID of an item of the type mentioned in the 'Trigger/On' tag." + Environment.NewLine + "" + Environment.NewLine + "When triggering on:" + Environment.NewLine + "  - protocol" + Environment.NewLine + "  - communication" + Environment.NewLine + "No 'Trigger/On@id' attribute is expected.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MissingAttribute = 1;
        public const uint ExcessiveAttribute = 2;
        public const uint EmptyAttribute = 3;
        public const uint MultipleIds = 4;
        public const uint InvalidValue = 5;
        public const uint NonExistingId = 6;
        public const uint LeadingZeros = 7;
        public const uint UntrimmedAttribute = 8;
    }

    public static class CheckId
    {
        public const uint CheckIdAttribute = 1;
    }
}