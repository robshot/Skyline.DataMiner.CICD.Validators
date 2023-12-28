namespace SLDisValidator2.Tests.Protocol.TreeControls.TreeControl.HiddenColumns.CheckHiddenColumnsTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHiddenColumnsTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "18.10.1",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "HiddenColumns", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/HiddenColumns' tag should contain a comma separated list of column PIDs that should not be visible in the TreeControl." + Environment.NewLine + "The column PIDs should belong to one of the table displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHiddenColumnsTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "18.10.2",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "HiddenColumns", "TreeControl", treeControlPid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/HiddenColumns' tag should contain a comma separated list of column PIDs that should not be visible in the TreeControl." + Environment.NewLine + "The column PIDs should belong to one of the table displayed in the TreeControl.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string hiddenColumnsValue, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHiddenColumnsTag,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "18.10.3",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}'. {2} {4} '{3}'.", hiddenColumnsValue, "HiddenColumns", "TreeControl", treeControlPid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/HiddenColumns' tag should contain a comma separated list of column PIDs that should not be visible in the TreeControl." + Environment.NewLine + "The column PIDs should belong to one of the table displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingIds(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHiddenColumnsTag,
                ErrorId = ErrorIds.NonExistingIds,
                FullId = "18.10.4",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Tag '{0}' references non-existing IDs. {1} {3} '{2}'.", "HiddenColumns", "TreeControl", treeControlPid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/HiddenColumns' tag should contain a comma separated list of column PIDs that should not be visible in the TreeControl." + Environment.NewLine + "The column PIDs should belong to one of the table displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingIds_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHiddenColumnsTag,
                ErrorId = ErrorIds.NonExistingIds_Sub,
                FullId = "18.10.5",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Tag '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "HiddenColumns", "Column", "PID", columnPid, "TreeControl", "ID", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/HiddenColumns' tag should contain a comma separated list of column PIDs that should not be visible in the TreeControl." + Environment.NewLine + "The column PIDs should belong to one of the table displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DuplicateId(IValidate test, IReadable referenceNode, IReadable positionNode, string duplicateId, string treeControlId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHiddenColumnsTag,
                ErrorId = ErrorIds.DuplicateId,
                FullId = "18.10.6",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicate value '{0}' in tag '{1}'. {2} {3} '{4}'.", duplicateId, "HiddenColumns", "TreeControl", "ID", treeControlId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/HiddenColumns' tag should contain a comma separated list of column PIDs that should not be visible in the TreeControl." + Environment.NewLine + "The column PIDs should belong to one of the table displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidValueInTag_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string invalidPart)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHiddenColumnsTag,
                ErrorId = ErrorIds.InvalidValueInTag_Sub,
                FullId = "18.10.7",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in tag '{0}'.", "HiddenColumns", invalidPart),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/HiddenColumns' tag should contain a comma separated list of column PIDs that should not be visible in the TreeControl." + Environment.NewLine + "The column PIDs should belong to one of the table displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedInTag_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHiddenColumnsTag,
                ErrorId = ErrorIds.UntrimmedInTag_Sub,
                FullId = "18.10.8",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed value '{0}' in tag '{1}'.", untrimmedValue, "HiddenColumns"),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/HiddenColumns' tag should contain a comma separated list of column PIDs that should not be visible in the TreeControl." + Environment.NewLine + "The column PIDs should belong to one of the table displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult IrrelevantColumn(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string treeControlId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHiddenColumnsTag,
                ErrorId = ErrorIds.IrrelevantColumn,
                FullId = "18.10.9",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Irrelevant column with PID '{0}' in 'TreeControl/HiddenColumns'. TreeControl ID '{1}'.", columnPid, treeControlId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/HiddenColumns' tag should contain a comma separated list of column PIDs that should not be visible in the TreeControl." + Environment.NewLine + "The column PIDs should belong to one of the table displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint EmptyTag = 1;
        public const uint UntrimmedTag = 2;
        public const uint InvalidValue = 3;
        public const uint NonExistingIds = 4;
        public const uint NonExistingIds_Sub = 5;
        public const uint DuplicateId = 6;
        public const uint InvalidValueInTag_Sub = 7;
        public const uint UntrimmedInTag_Sub = 8;
        public const uint IrrelevantColumn = 9;
    }

    public static class CheckId
    {
        public const uint CheckHiddenColumnsTag = 10;
    }
}