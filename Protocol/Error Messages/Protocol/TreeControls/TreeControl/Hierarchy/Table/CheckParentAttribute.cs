namespace SLDisValidator2.Tests.Protocol.TreeControls.TreeControl.Hierarchy.Table.CheckParentAttribute
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
                CheckId = CheckId.CheckParentAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "18.4.1",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' in {1} '{2}'.", "Table@parent", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy/Table@parent attribute should contain a table PID. This allows to define which table is on the above level." + Environment.NewLine + "Note this does not make sense on the first Hierarchy/Table tag but is mandatory on all other ones.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ExcessiveAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParentAttribute,
                ErrorId = ErrorIds.ExcessiveAttribute,
                FullId = "18.4.2",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported attribute '{0}' in {1} '{2}'.", "Table@parent", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy/Table@parent attribute should contain a table PID. This allows to define which table is on the above level." + Environment.NewLine + "Note this does not make sense on the first Hierarchy/Table tag but is mandatory on all other ones.",
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
                CheckId = CheckId.CheckParentAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "18.4.3",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "Table@parent", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy/Table@parent attribute should contain a table PID. This allows to define which table is on the above level." + Environment.NewLine + "Note this does not make sense on the first Hierarchy/Table tag but is mandatory on all other ones.",
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
                CheckId = CheckId.CheckParentAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "18.4.4",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "Table@parent", "TreeControl", treeControlPid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy/Table@parent attribute should contain a table PID. This allows to define which table is on the above level." + Environment.NewLine + "Note this does not make sense on the first Hierarchy/Table tag but is mandatory on all other ones.",
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
                CheckId = CheckId.CheckParentAttribute,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "18.4.5",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. {2} {4} '{3}'.", "Table@parent", attributeValue, "TreeControl", treeControlPid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy/Table@parent attribute should contain a table PID. This allows to define which table is on the above level." + Environment.NewLine + "Note this does not make sense on the first Hierarchy/Table tag but is mandatory on all other ones.",
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
                CheckId = CheckId.CheckParentAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "18.4.6",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}@{1}' references a non-existing '{2}' with {3} '{4}'.", "Hierarchy/Table", "parent", "Table", "PID", tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy/Table@parent attribute should contain a table PID. This allows to define which table is on the above level." + Environment.NewLine + "Note this does not make sense on the first Hierarchy/Table tag but is mandatory on all other ones.",
                HasCodeFix = false,

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
        public const uint UntrimmedAttribute = 4;
        public const uint InvalidValue = 5;
        public const uint NonExistingId = 6;
    }

    public static class CheckId
    {
        public const uint CheckParentAttribute = 4;
    }
}