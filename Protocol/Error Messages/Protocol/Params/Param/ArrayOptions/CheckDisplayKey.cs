namespace SLDisValidator2.Tests.Protocol.Params.Param.ArrayOptions.CheckDisplayKey
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult DuplicateDisplayKeyDefinition(IValidate test, IReadable referenceNode, IReadable positionNode, string tableId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayKey,
                ErrorId = ErrorIds.DuplicateDisplayKeyDefinition,
                FullId = "2.39.1",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Table with ID '{0}' has multiple display key definitions.", tableId),
                HowToFix = "Only keep the most recent syntax of defining the display key.",
                ExampleCode = "",
                Details = "When defining the display key via multiple syntaxes, only the most recent syntax is actually used. List of syntaxes from most recent to oldest:" + Environment.NewLine + " - NamingFormat tag" + Environment.NewLine + " - Naming option (ex: options=;naming=/101)" + Environment.NewLine + " - displayColumn attribute" + Environment.NewLine + "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DisplayColumnSameAsPK(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayKey,
                ErrorId = ErrorIds.DisplayColumnSameAsPK,
                FullId = "2.39.2",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("DisplayColumn is the same as the primary key. Table PID '{0}'.", tablePid),
                HowToFix = "Remove the displayColumn='' attribute.",
                ExampleCode = "",
                Details = "The excessive displayColumn='' definition has no added value and bad impact on the performance.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DisplayColumnUnrecommended(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid, bool hasCodeFix)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayKey,
                ErrorId = ErrorIds.DisplayColumnUnrecommended,
                FullId = "2.39.3",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Unrecommended use of displayColumn. Table PID '{0}'.", tablePid),
                HowToFix = "Replace the displayColumn attribute by the NamingFormat tag.",
                ExampleCode = "",
                Details = "It is preferred to define the display key via the NamingFormat tag.",
                HasCodeFix = hasCodeFix,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DisplayKeyColumnInvalidInterpreteType(IValidate test, IReadable referenceNode, IReadable positionNode, string columnIntrepeteType, string dkColumnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayKey,
                ErrorId = ErrorIds.DisplayKeyColumnInvalidInterpreteType,
                FullId = "2.39.6",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}' for {2}. Possible values '{3}'. {4} {5} '{6}'.", columnIntrepeteType, "Interprete/Type", "display key column", "string", "DK column", "PID", dkColumnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "A column used as table display key should be of Interprete/Type 'string'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DisplayKeyColumnInvalidMeasurementType(IValidate test, IReadable referenceNode, IReadable positionNode, string columnMeasurementType, string dkColumnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayKey,
                ErrorId = ErrorIds.DisplayKeyColumnInvalidMeasurementType,
                FullId = "2.39.7",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}' for {2}. Possible values '{3}'. {4} {5} '{6}'.", columnMeasurementType, "Measurement/Type", "display key column", "string, number", "DK column", "PID", dkColumnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "A column used as table display key should be of Measurement/Type 'string' or 'number'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DisplayKeyColumnInvalidType(IValidate test, IReadable referenceNode, IReadable positionNode, string columnType, string dkColumnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayKey,
                ErrorId = ErrorIds.DisplayKeyColumnInvalidType,
                FullId = "2.39.8",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}' for {2}. Possible values '{3}'. {4} {5} '{6}'.", columnType, "Param/Type", "display key column", "read", "DK column", "PID", dkColumnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "A column used as table display key should be of Param/Type 'read'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DisplayKeyColumnMissing(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayKey,
                ErrorId = ErrorIds.DisplayKeyColumnMissing,
                FullId = "2.39.9",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing column with ColumnOption@type=\"displaykey\". Table PID {0}.", tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "When defining display key format via ArrayOption/NamingFormat tag or via naming option in the ArrayOption@options attribute and the display key format does not only consist of a single column content, it is mandatory to add a displayed column with ColumnOption@type=\"displaykey\" attribute value so that the full display key is available to the user.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnexpectedIdxSuffix(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayKey,
                ErrorId = ErrorIds.UnexpectedIdxSuffix,
                FullId = "2.39.10",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unexpected [IDX] suffix on Param/Description. Column Pid {0}.", columnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The [IDX] suffix on column description is only expected on following columns:" + Environment.NewLine + "- Column included in table with ColumnOption@type=\"displaykey\"." + Environment.NewLine + "- Column referred by the ArrayOption/NamingFormat of the containing table only when NamingFormat only consist of that column (no other column, no additional hard-coded bits)." + Environment.NewLine + "- Column referred by the naming option in the ArrayOption@options attribute of the containing table only when it only consist of that column (no other column)." + Environment.NewLine + "- Column referred by the (obsolete) ArrayOption@displayColumn attribute of the containing table.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DuplicateDisplayKeyColumn(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayKey,
                ErrorId = ErrorIds.DuplicateDisplayKeyColumn,
                FullId = "2.39.11",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Table has multiple ColumnOption tags with value 'displaykey' in type attribute. Table Pid {0}.", tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "A table should have, at most, 1 ColumnOption tag with its type attribute set to 'displaykey'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorCompare
    {
        public static IValidationResult FormatChanged(IReadable referenceNode, IReadable positionNode, string oldSyntax, string oldFormat, string newSyntax, string newFormat, string tablePid)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckDisplayKey,
                ErrorId = ErrorIds.FormatChanged,
                FullId = "2.39.4",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Table display key was changed from {0} '{1}' to {2} '{3}'. Table PID '{4}'.", oldSyntax, oldFormat, newSyntax, newFormat, tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The display key of tables can be defined via 'ArrayOptions@option:naming' or via 'ArrayOptions/NamingFormat'." + Environment.NewLine + "'ArrayOptions/NamingFormat' is the prefered way and going from one syntax to another has no breaking impact as long as the defined format is equivalent.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult FormatRemoved(IReadable referenceNode, IReadable positionNode, string oldSyntax, string tablePid)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckDisplayKey,
                ErrorId = ErrorIds.FormatRemoved,
                FullId = "2.39.5",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Table display key previously defined via '{0}' was removed. Table PID '{1}'.", oldSyntax, tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The display key of tables can be defined via 'ArrayOptions@option:naming' or via 'ArrayOptions/NamingFormat'." + Environment.NewLine + "'ArrayOptions/NamingFormat' is the prefered way and going from one syntax to another has no breaking impact as long as the defined format is equivalent.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint DuplicateDisplayKeyDefinition = 1;
        public const uint DisplayColumnSameAsPK = 2;
        public const uint DisplayColumnUnrecommended = 3;
        public const uint FormatChanged = 4;
        public const uint FormatRemoved = 5;
        public const uint DisplayKeyColumnInvalidInterpreteType = 6;
        public const uint DisplayKeyColumnInvalidMeasurementType = 7;
        public const uint DisplayKeyColumnInvalidType = 8;
        public const uint DisplayKeyColumnMissing = 9;
        public const uint UnexpectedIdxSuffix = 10;
        public const uint DuplicateDisplayKeyColumn = 11;
    }

    public static class CheckId
    {
        public const uint CheckDisplayKey = 39;
    }
}