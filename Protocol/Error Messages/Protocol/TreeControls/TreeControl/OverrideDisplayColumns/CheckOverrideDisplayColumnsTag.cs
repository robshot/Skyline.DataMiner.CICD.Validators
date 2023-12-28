namespace SLDisValidator2.Tests.Protocol.TreeControls.TreeControl.OverrideDisplayColumns.CheckOverrideDisplayColumnsTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOverrideDisplayColumnsTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "18.11.1",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "OverrideDisplayColumns", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/OverrideDisplayColumns' tag should contain a comma separated list of column PIDs that should be used as display name in the TreeControl structure." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl Hierarchy and only one column per table should be used." + Environment.NewLine + "For each column PID, an extra pipeline can optionally be added followed by a column PID to be used for sorting items.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOverrideDisplayColumnsTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "18.11.2",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "OverrideDisplayColumns", "TreeControl", treeControlPid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/OverrideDisplayColumns' tag should contain a comma separated list of column PIDs that should be used as display name in the TreeControl structure." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl Hierarchy and only one column per table should be used." + Environment.NewLine + "For each column PID, an extra pipeline can optionally be added followed by a column PID to be used for sorting items.",
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
                CheckId = CheckId.CheckOverrideDisplayColumnsTag,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "18.11.3",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}'. {2} {4} '{3}'.", attributeValue, "OverrideDisplayColumns", "TreeControl", treeControlPid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/OverrideDisplayColumns' tag should contain a comma separated list of column PIDs that should be used as display name in the TreeControl structure." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl Hierarchy and only one column per table should be used." + Environment.NewLine + "For each column PID, an extra pipeline can optionally be added followed by a column PID to be used for sorting items.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingIds(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOverrideDisplayColumnsTag,
                ErrorId = ErrorIds.NonExistingIds,
                FullId = "18.11.4",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Tag '{0}' references non-existing IDs. {1} {3} '{2}'.", "OverrideDisplayColumns", "TreeControl", treeControlPid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/OverrideDisplayColumns' tag should contain a comma separated list of column PIDs that should be used as display name in the TreeControl structure." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl Hierarchy and only one column per table should be used." + Environment.NewLine + "For each column PID, an extra pipeline can optionally be added followed by a column PID to be used for sorting items.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingIds_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOverrideDisplayColumnsTag,
                ErrorId = ErrorIds.NonExistingIds_Sub,
                FullId = "18.11.5",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Tag '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "OverrideDisplayColumns", "Column", "PID", columnPid, "TreeControl", "ID", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/OverrideDisplayColumns' tag should contain a comma separated list of column PIDs that should be used as display name in the TreeControl structure." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl Hierarchy and only one column per table should be used." + Environment.NewLine + "For each column PID, an extra pipeline can optionally be added followed by a column PID to be used for sorting items.",
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
                CheckId = CheckId.CheckOverrideDisplayColumnsTag,
                ErrorId = ErrorIds.DuplicateId,
                FullId = "18.11.6",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicate value '{0}' in tag '{1}'. {2} {3} '{4}'.", duplicateId, "OverrideDisplayColumns", "TreeControl", "ID", treeControlId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/OverrideDisplayColumns' tag should contain a comma separated list of column PIDs that should be used as display name in the TreeControl structure." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl Hierarchy and only one column per table should be used." + Environment.NewLine + "For each column PID, an extra pipeline can optionally be added followed by a column PID to be used for sorting items.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult DuplicateOverrideDisplayColumn(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOverrideDisplayColumnsTag,
                ErrorId = ErrorIds.DuplicateOverrideDisplayColumn,
                FullId = "18.11.7",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicate OverrideDisplayColumns IDs for Table '{0}'. TreeControl ID '{1}'.", tablePid, treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/OverrideDisplayColumns' tag should contain a comma separated list of column PIDs that should be used as display name in the TreeControl structure." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl Hierarchy and only one column per table should be used." + Environment.NewLine + "For each column PID, an extra pipeline can optionally be added followed by a column PID to be used for sorting items.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedValueInTag_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOverrideDisplayColumnsTag,
                ErrorId = ErrorIds.UntrimmedValueInTag_Sub,
                FullId = "18.11.8",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed value '{0}' in tag '{1}'.", untrimmedValue, "OverrideDisplayColumns"),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/OverrideDisplayColumns' tag should contain a comma separated list of column PIDs that should be used as display name in the TreeControl structure." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl Hierarchy and only one column per table should be used." + Environment.NewLine + "For each column PID, an extra pipeline can optionally be added followed by a column PID to be used for sorting items.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidValueInTag_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string invalidPart)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOverrideDisplayColumnsTag,
                ErrorId = ErrorIds.InvalidValueInTag_Sub,
                FullId = "18.11.9",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in tag '{0}'.", "OverrideDisplayColumns", invalidPart),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/OverrideDisplayColumns' tag should contain a comma separated list of column PIDs that should be used as display name in the TreeControl structure." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl Hierarchy and only one column per table should be used." + Environment.NewLine + "For each column PID, an extra pipeline can optionally be added followed by a column PID to be used for sorting items.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult DuplicateOverrideDisplayColumns_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string duplicateId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOverrideDisplayColumnsTag,
                ErrorId = ErrorIds.DuplicateOverrideDisplayColumns_Sub,
                FullId = "18.11.10",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicate OverrideDisplayColumns ID '{0}'.", duplicateId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/OverrideDisplayColumns' tag should contain a comma separated list of column PIDs that should be used as display name in the TreeControl structure." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl Hierarchy and only one column per table should be used." + Environment.NewLine + "For each column PID, an extra pipeline can optionally be added followed by a column PID to be used for sorting items.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult IrrelevantColumn(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string treeControlId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOverrideDisplayColumnsTag,
                ErrorId = ErrorIds.IrrelevantColumn,
                FullId = "18.11.11",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Irrelevant column with PID '{0}' in 'TreeControl/OverrideDisplayColumns'. TreeControl ID '{1}'.", columnPid, treeControlId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/OverrideDisplayColumns' tag should contain a comma separated list of column PIDs that should be used as display name in the TreeControl structure." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl Hierarchy and only one column per table should be used." + Environment.NewLine + "For each column PID, an extra pipeline can optionally be added followed by a column PID to be used for sorting items.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint EmptyTag = 1;
        public const uint UntrimmedTag = 2;
        public const uint InvalidValue = 3;
        public const uint NonExistingIds = 4;
        public const uint NonExistingIds_Sub = 5;
        public const uint DuplicateId = 6;
        public const uint DuplicateOverrideDisplayColumn = 7;
        public const uint UntrimmedValueInTag_Sub = 8;
        public const uint InvalidValueInTag_Sub = 9;
        public const uint DuplicateOverrideDisplayColumns_Sub = 10;
        public const uint IrrelevantColumn = 11;
    }

    public static class CheckId
    {
        public const uint CheckOverrideDisplayColumnsTag = 11;
    }
}