namespace SLDisValidator2.Tests.Protocol.TreeControls.TreeControl.ExtraTab.Tab.CheckTableIdAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTableIdAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "18.9.1",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' in {1} '{2}'.", "Tab@tableId", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Tab@tableId attribute should contain a valid table PID." + Environment.NewLine + "The referred table allows to define the Treecontrol level to which an extra tab should be added and is expected to have the RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTableIdAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "18.9.2",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "Tab@tableId", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Tab@tableId attribute should contain a valid table PID." + Environment.NewLine + "The referred table allows to define the Treecontrol level to which an extra tab should be added and is expected to have the RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTableIdAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "18.9.3",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "Tab@tableId", "TreeControl", treeControlPid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Tab@tableId attribute should contain a valid table PID." + Environment.NewLine + "The referred table allows to define the Treecontrol level to which an extra tab should be added and is expected to have the RTDisplay tag set to true.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string attributeValue, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTableIdAttribute,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "18.9.4",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. {2} {4} '{3}'.", "Tab@tableId", attributeValue, "TreeControl", treeControlPid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "Tab@tableId attribute should contain a valid table PID." + Environment.NewLine + "The referred table allows to define the Treecontrol level to which an extra tab should be added and is expected to have the RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTableIdAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "18.9.5",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}@{1}' references a non-existing '{2}' with {3} '{4}'.", "ExtraTabs/Tab", "tableId", "Table", "PID", tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Tab@tableId attribute should contain a valid table PID." + Environment.NewLine + "The referred table allows to define the Treecontrol level to which an extra tab should be added and is expected to have the RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MissingAttribute = 1;
        public const uint EmptyAttribute = 2;
        public const uint UntrimmedAttribute = 3;
        public const uint InvalidValue = 4;
        public const uint NonExistingId = 5;
    }

    public static class CheckId
    {
        public const uint CheckTableIdAttribute = 9;
    }
}