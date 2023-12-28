namespace SLDisValidator2.Tests.Protocol.Relations.Relation.CheckPathAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "13.2.1",
                Category = Category.Relation,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}@{1}' references a non-existing '{2}' with {3} '{4}'.", "Relation", "path", "Table", "PID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Relation path should contain a semicolon list of Param IDs for tables that are linked to each other." + Environment.NewLine + "" + Environment.NewLine + "Additionally, Every adjacent table in a relation path need at least one foreignKey from one another.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "13.2.2",
                Category = Category.Relation,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}'.", "Relation@path"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Relation path should contain a semicolon list of Param IDs for tables that are linked to each other." + Environment.NewLine + "" + Environment.NewLine + "Additionally, Every adjacent table in a relation path need at least one foreignKey from one another.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string pathValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "13.2.3",
                Category = Category.Relation,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'.", "Relation@path", pathValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Relation path should contain a semicolon list of Param IDs for tables that are linked to each other." + Environment.NewLine + "" + Environment.NewLine + "Additionally, Every adjacent table in a relation path need at least one foreignKey from one another.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "13.2.4",
                Category = Category.Relation,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}'.", "Relation@path"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Relation path should contain a semicolon list of Param IDs for tables that are linked to each other." + Environment.NewLine + "" + Environment.NewLine + "Additionally, Every adjacent table in a relation path need at least one foreignKey from one another.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingForeignKeyForRelation(IValidate test, IReadable referenceNode, IReadable positionNode, string relationNameOrPath)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.MissingForeignKeyForRelation,
                FullId = "13.2.5",
                Category = Category.Relation,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing foreignKey(s) detected for relation '{0}'.", relationNameOrPath),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Relation path should contain a semicolon list of Param IDs for tables that are linked to each other." + Environment.NewLine + "" + Environment.NewLine + "Additionally, Every adjacent table in a relation path need at least one foreignKey from one another.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingForeignKeyInTable_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string table1Pid, string table2Pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.MissingForeignKeyInTable_Sub,
                FullId = "13.2.6",
                Category = Category.Relation,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing foreignKey between table '{0}' and table '{1}'.", table1Pid, table2Pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Relation path should contain a semicolon list of Param IDs for tables that are linked to each other." + Environment.NewLine + "" + Environment.NewLine + "Additionally, Every adjacent table in a relation path need at least one foreignKey from one another.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ReferencedParamWrongType(IValidate test, IReadable referenceNode, IReadable positionNode, string paramType, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.ReferencedParamWrongType,
                FullId = "13.2.7",
                Category = Category.Relation,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid Param Type '{0}' in relation. Expected Type 'array'. Param ID '{1}'.", paramType, paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Relation path should contain a semicolon list of Param IDs for tables that are linked to each other." + Environment.NewLine + "" + Environment.NewLine + "Additionally, Every adjacent table in a relation path need at least one foreignKey from one another.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ReferencedParamExpectingRTDisplay(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.ReferencedParamExpectingRTDisplay,
                FullId = "13.2.8",
                Category = Category.Relation,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on Param referenced in a relation path. Param ID '{0}'.", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Relation path should contain a semicolon list of Param IDs for tables that are linked to each other." + Environment.NewLine + "" + Environment.NewLine + "Additionally, every table in a relation is expected to have its RTDisplay element set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult DuplicateValue(IValidate test, IReadable referenceNode, IReadable positionNode, string duplicateValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPathAttribute,
                ErrorId = ErrorIds.DuplicateValue,
                FullId = "13.2.9",
                Category = Category.Relation,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicated {0} {1} '{2}'.", "Relation", "path", duplicateValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Relation path should contain a semicolon list of Param IDs for tables that are linked to each other." + Environment.NewLine + "" + Environment.NewLine + "Additionally, Every adjacent table in a relation path need at least one foreignKey from one another.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint NonExistingId = 1;
        public const uint MissingAttribute = 2;
        public const uint InvalidValue = 3;
        public const uint EmptyAttribute = 4;
        public const uint MissingForeignKeyForRelation = 5;
        public const uint MissingForeignKeyInTable_Sub = 6;
        public const uint ReferencedParamWrongType = 7;
        public const uint ReferencedParamExpectingRTDisplay = 8;
        public const uint DuplicateValue = 9;
    }

    public static class CheckId
    {
        public const uint CheckPathAttribute = 2;
    }
}