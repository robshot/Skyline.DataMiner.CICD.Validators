namespace SLDisValidator2.Tests.Protocol.ParameterGroups.Group.CheckNameAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string parameterGroupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "16.3.4",
                Category = Category.ParameterGroup,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' in {1} '{2}'.", "name", "ParameterGroup", parameterGroupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "All ParameterGroups should have an unique name." + Environment.NewLine + "These names are used by DataMiner to build the DCF interfaces names. Therefore, we recommend to keep it rather small (max 25 chars) and avoid using special characters (see protocol guide for more info).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string parameterGroupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "16.3.5",
                Category = Category.ParameterGroup,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "name", "ParameterGroup", parameterGroupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "All ParameterGroups should have an unique name." + Environment.NewLine + "These names are used by DataMiner to build the DCF interfaces names. Therefore, we recommend to keep it rather small (max 25 chars) and avoid using special characters (see protocol guide for more info).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DuplicatedValue(IValidate test, IReadable referenceNode, IReadable positionNode, string duplicateName, string parameterGroupIds)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameAttribute,
                ErrorId = ErrorIds.DuplicatedValue,
                FullId = "16.3.6",
                Category = Category.ParameterGroup,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Duplicated {0} {1} '{2}'. {0} IDs '{3}'.", "ParameterGroup", "Name", duplicateName, parameterGroupIds),
                HowToFix = "",
                ExampleCode = "",
                Details = "All ParameterGroups should have an unique name." + Environment.NewLine + "These names are used by DataMiner to build the DCF interfaces names. Therefore, we recommend to keep it rather small (max 25 chars) and avoid using special characters (see protocol guide for more info).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidChars(IValidate test, IReadable referenceNode, IReadable positionNode, string attributeValue, string invalidCharacters)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameAttribute,
                ErrorId = ErrorIds.InvalidChars,
                FullId = "16.3.7",
                Category = Category.ParameterGroup,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Invalid chars '{2}' in attribute '{0}'. Current value '{1}'.", "name", attributeValue, invalidCharacters),
                HowToFix = "",
                ExampleCode = "",
                Details = "All ParameterGroups should have an unique name." + Environment.NewLine + "These names are used by DataMiner to build the DCF interfaces names. Therefore, we recommend to keep it rather small (max 25 chars) and avoid using special characters (see protocol guide for more info).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult LengthyValue(IValidate test, IReadable referenceNode, IReadable positionNode, string parameterGroupName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameAttribute,
                ErrorId = ErrorIds.LengthyValue,
                FullId = "16.3.8",
                Category = Category.ParameterGroup,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Too long ParameterGroup Name. Current value '{0}'.", parameterGroupName),
                HowToFix = "",
                ExampleCode = "",
                Details = "All ParameterGroups should have an unique name." + Environment.NewLine + "These names are used by DataMiner to build the DCF interfaces names. Therefore, we recommend to keep it rather small (max 25 chars) and avoid using special characters (see protocol guide for more info).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string parameterGroupId, string untrimmedName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNameAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "16.3.9",
                Category = Category.ParameterGroup,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "name", "ParameterGroup", parameterGroupId, untrimmedName),
                HowToFix = "",
                ExampleCode = "",
                Details = "All ParameterGroups should have an unique name." + Environment.NewLine + "These names are used by DataMiner to build the DCF interfaces names. Therefore, we recommend to keep it rather small (max 25 chars) and avoid using special characters (see protocol guide for more info).",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorCompare
    {
        public static IValidationResult DcfParameterGroupNameChanged(IReadable referenceNode, IReadable positionNode, string groupId, string oldName, string newName)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckNameAttribute,
                ErrorId = ErrorIds.DcfParameterGroupNameChanged,
                FullId = "16.3.3",
                Category = Category.ParameterGroup,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("DCF Group name for ParameterGroup '{0}' was changed from '{1}' into '{2}'.", groupId, oldName, newName),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint DcfParameterGroupNameChanged = 3;
        public const uint MissingAttribute = 4;
        public const uint EmptyAttribute = 5;
        public const uint DuplicatedValue = 6;
        public const uint InvalidChars = 7;
        public const uint LengthyValue = 8;
        public const uint UntrimmedAttribute = 9;
    }

    public static class CheckId
    {
        public const uint CheckNameAttribute = 3;
    }
}