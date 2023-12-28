namespace SLDisValidator2.Tests.Protocol.Params.Param.Name.CheckNameTag
{
    using System;
    using System.Collections.Generic;
    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    internal static class Error
    {
        internal static IValidationResult MissingTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameTag,
                ErrorId = ErrorIds.MissingTag,
                FullId = "2.2.1",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing tag '{0}' in {1} '{2}'.", "Name", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "2.2.2",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Name", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "2.2.3",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Name", "Param", pid, untrimmedValue),
                HowToFix = "Remove the leading/trailing whitespaces.",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidChars(IValidate test, IReadable referenceNode, IReadable positionNode, string tagValue, string invalidCharacters)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameTag,
                ErrorId = ErrorIds.InvalidChars,
                FullId = "2.2.4",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid chars '{2}' in tag '{0}'. Current value '{1}'.", "Name", tagValue, invalidCharacters),
                HowToFix = "Remove or replace invalid chars.",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult RestrictedName(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId, string paramName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameTag,
                ErrorId = ErrorIds.RestrictedName,
                FullId = "2.2.5",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid Param Name '{1}'. Param ID '{0}'. The Param Name is reserved by DataMiner for internal use.", paramId, paramName),
                HowToFix = "",
                ExampleCode = "",
                Details = "On top of a predefined list of names, all parameter names starting with two underscores are reserved for internal use.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult DuplicatedValue(IValidate test, IReadable referenceNode, IReadable positionNode, string duplicateName, string paramIds)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameTag,
                ErrorId = ErrorIds.DuplicatedValue,
                FullId = "2.2.6",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicated {0} {1} '{2}'. {0} IDs '{3}'.", "Param", "Name", duplicateName, paramIds),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UnrecommendedChars(IValidate test, IReadable referenceNode, IReadable positionNode, string tagName, string tagValue, string invalidCharacters)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameTag,
                ErrorId = ErrorIds.UnrecommendedChars,
                FullId = "2.2.7",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "Unrecommended chars in some parameter names.",
                Description = String.Format("Unrecommended chars '{2}' in tag '{0}'. Current value '{1}'.", tagName, tagValue, invalidCharacters),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,

                AutoFixWarnings = new List<(string, bool)>
                {
                    ("Double check the use of the Parameter class in QActions.", true),
                    ("Double check the use of the (Get/Set)ParameterByName methods in QActions.", false),
                }
            };
        }

        internal static IValidationResult UnrecommendedStartChars(IValidate test, IReadable referenceNode, IReadable positionNode, string tagName, string tagValue, string unrecommendedStartCharacters)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameTag,
                ErrorId = ErrorIds.UnrecommendedStartChars,
                FullId = "2.2.8",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unrecommended start chars '{2}' in tag '{0}'. Current value '{1}'.", tagName, tagValue, unrecommendedStartCharacters),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult RTDisplayExpectedOnContextMenu(IValidate test, IReadable referenceNode, IReadable positionNode, string contextMenuPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameTag,
                ErrorId = ErrorIds.RTDisplayExpectedOnContextMenu,
                FullId = "2.2.10",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on Param '{0}' used as context menu for table.", contextMenuPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Parameter with names ending with \"_contextmenu\" are used as context menu for tables." + Environment.NewLine + "Such Param requires its RTDisplay tag to be set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult RTDisplayExpectedOnQActionFeedback(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionFeedbackPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameTag,
                ErrorId = ErrorIds.RTDisplayExpectedOnQActionFeedback,
                FullId = "2.2.11",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on Param '{0}' used for QAction feedback.", qactionFeedbackPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Parameter with names ending with \"_QActionFeedback\" are used to dynamically provide feedback from a QAction to (and only to) the user triggering the QAction." + Environment.NewLine + "Example scenarios where such feature is used:" + Environment.NewLine + "- Feedback from a QAction triggered by a table context menu." + Environment.NewLine + "" + Environment.NewLine + "Such Param requires its RTDisplay tag to be set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorCompare
    {
        internal static IValidationResult LoggerTableColumnNameChanged(IReadable referenceNode, IReadable positionNode, string oldColumnName, string columnPid, string tablePid, string newColumnName)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckNameTag,
                ErrorId = ErrorIds.LoggerTableColumnNameChanged,
                FullId = "2.2.9",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Logger table column name '{0}' for column PID '{1}' on table '{2}' was changed into '{3}'.", oldColumnName, columnPid, tablePid, newColumnName),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MissingTag = 1;
        public const uint EmptyTag = 2;
        public const uint UntrimmedTag = 3;
        public const uint InvalidChars = 4;
        public const uint RestrictedName = 5;
        public const uint DuplicatedValue = 6;
        public const uint UnrecommendedChars = 7;
        public const uint UnrecommendedStartChars = 8;
        public const uint LoggerTableColumnNameChanged = 9;
        public const uint RTDisplayExpectedOnContextMenu = 10;
        public const uint RTDisplayExpectedOnQActionFeedback = 11;
    }

    public static class CheckId
    {
        public const uint CheckNameTag = 2;
    }
}