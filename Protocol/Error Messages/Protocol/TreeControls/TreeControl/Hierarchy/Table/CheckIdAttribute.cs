namespace SLDisValidator2.Tests.Protocol.TreeControls.TreeControl.Hierarchy.Table.CheckIdAttribute
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
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "18.3.1",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' in {1} '{2}'.", "Table@id", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy/Table@id attribute should contain a table PID allowing to define which table contains entries for a specific level of the TreeControl." + Environment.NewLine + "Such table is expected to have RTDisplay tag set to 'true'.",
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
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "18.3.2",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "Table@id", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy/Table@id attribute should contain a table PID allowing to define which table contains entries for a specific level of the TreeControl." + Environment.NewLine + "Such table is expected to have RTDisplay tag set to 'true'.",
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
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "18.3.3",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "Table@id", "TreeControl", treeControlPid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy/Table@id attribute should contain a table PID allowing to define which table contains entries for a specific level of the TreeControl." + Environment.NewLine + "Such table is expected to have RTDisplay tag set to 'true'.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string tableId, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "18.3.4",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. {2} {4} '{3}'.", "Table@id", tableId, "TreeControl", treeControlPid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy/Table@id attribute should contain a table PID allowing to define which table contains entries for a specific level of the TreeControl." + Environment.NewLine + "Such table is expected to have RTDisplay tag set to 'true'.",
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
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "18.3.5",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}@{1}' references a non-existing '{2}' with {3} '{4}'.", "Hierarchy/Table", "id", "Table", "PID", tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy/Table@id attribute should contain a table PID allowing to define which table contains entries for a specific level of the TreeControl." + Environment.NewLine + "Such table is expected to have RTDisplay tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ReferencedParamExpectingRTDisplay(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.ReferencedParamExpectingRTDisplay,
                FullId = "18.3.6",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on table displayed in TreeControl Hierarchy. Table PID '{0}'.", tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy/Table@id attribute should contain a table PID allowing to define which table contains entries for a specific level of the TreeControl." + Environment.NewLine + "Such table is expected to have RTDisplay tag set to 'true'.",
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
        public const uint ReferencedParamExpectingRTDisplay = 6;
    }

    public static class CheckId
    {
        public const uint CheckIdAttribute = 3;
    }
}