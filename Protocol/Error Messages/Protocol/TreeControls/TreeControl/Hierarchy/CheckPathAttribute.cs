namespace SLDisValidator2.Tests.Protocol.TreeControls.TreeControl.Hierarchy.CheckPathAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "18.2.1",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "Hierarchy@path", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy@path attribute should contain a comma separated list of table PIDs." + Environment.NewLine + "Those tables will define the different levels of the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "Note that this can also be achieved with more flexibility via the Hierarchy/Table tags.",
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
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "18.2.2",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "Hierarchy@path", "TreeControl", treeControlPid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy@path attribute should contain a comma separated list of table PIDs." + Environment.NewLine + "Those tables will define the different levels of the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "Note that this can also be achieved with more flexibility via the Hierarchy/Table tags.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string pathValue, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "18.2.3",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. {2} {4} '{3}'.", "Hierarchy@path", pathValue, "TreeControl", treeControlPid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy@path attribute should contain a comma separated list of table PIDs." + Environment.NewLine + "Those tables will define the different levels of the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "Note that this can also be achieved with more flexibility via the Hierarchy/Table tags.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingIdsInAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.NonExistingIdsInAttribute,
                FullId = "18.2.4",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references non-existing IDs. {1} {3} '{2}'.", "Hierarchy@path", "TreeControl", treeControlPid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy@path attribute should contain a comma separated list of table PIDs." + Environment.NewLine + "Those tables will define the different levels of the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "Note that this can also be achieved with more flexibility via the Hierarchy/Table tags.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingIdsInAttribute_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.NonExistingIdsInAttribute_Sub,
                FullId = "18.2.5",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Hierarchy@path", "Table", "PID", paramId, "TreeControl", "ID", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy@path attribute should contain a comma separated list of table PIDs." + Environment.NewLine + "Those tables will define the different levels of the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "Note that this can also be achieved with more flexibility via the Hierarchy/Table tags.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult DuplicateId(IValidate test, IReadable referenceNode, IReadable positionNode, string duplicateId, string treeControlId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.DuplicateId,
                FullId = "18.2.6",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicate value '{0}' in attribute '{1}'. {2} {3} '{4}'.", duplicateId, "Hierarchy@path", "TreeControl", "ID", treeControlId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy@path attribute should contain a comma separated list of table PIDs." + Environment.NewLine + "Those tables will define the different levels of the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "Note that this can also be achieved with more flexibility via the Hierarchy/Table tags.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedValueInAttribute_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.UntrimmedValueInAttribute_Sub,
                FullId = "18.2.7",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed value '{0}' in attribute '{1}'.", untrimmedValue, "Hierarchy@path"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy@path attribute should contain a comma separated list of table PIDs." + Environment.NewLine + "Those tables will define the different levels of the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "Note that this can also be achieved with more flexibility via the Hierarchy/Table tags.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidValueInAttribute_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string invalidPart)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.InvalidValueInAttribute_Sub,
                FullId = "18.2.8",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'.", "Hierarchy@path", invalidPart),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy@path attribute should contain a comma separated list of table PIDs." + Environment.NewLine + "Those tables will define the different levels of the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "Note that this can also be achieved with more flexibility via the Hierarchy/Table tags.",
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
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.ReferencedParamExpectingRTDisplay,
                FullId = "18.2.9",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on table displayed in TreeControl Hierarchy. Table PID '{0}'.", tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Hierarchy@path attribute should contain a comma separated list of table PIDs." + Environment.NewLine + "Those tables will define the different levels of the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "Note that this can also be achieved with more flexibility via the Hierarchy/Table tags.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint EmptyAttribute = 1;
        public const uint UntrimmedAttribute = 2;
        public const uint InvalidValue = 3;
        public const uint NonExistingIdsInAttribute = 4;
        public const uint NonExistingIdsInAttribute_Sub = 5;
        public const uint DuplicateId = 6;
        public const uint UntrimmedValueInAttribute_Sub = 7;
        public const uint InvalidValueInAttribute_Sub = 8;
        public const uint ReferencedParamExpectingRTDisplay = 9;
    }

    public static class CheckId
    {
        public const uint CheckPathAttribute = 2;
    }
}