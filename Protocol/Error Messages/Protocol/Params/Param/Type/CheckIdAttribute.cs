namespace SLDisValidator2.Tests.Protocol.Params.Param.Type.CheckIdAttribute
{
    using System;
    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    internal static class Error
    {
        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "2.62.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "Type@id", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Depending on the Param.Type tag value, this attribute should refer to an existing protocol items:" + Environment.NewLine + "- read bit: ID of the corresponding group param (mandatory)." + Environment.NewLine + "- write bit: ID of the corresponding group param (mandatory)." + Environment.NewLine + "- response: ID of the response responsible to further parse the value of this param (mandatory)." + Environment.NewLine + "- array: Semi-column list of column Param IDs (optional: depends on the type of table and the presence of ArrayOptions/ColumnOptions tags).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "2.62.2",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "Type@id", "Param", pid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Depending on the Param.Type tag value, this attribute should refer to an existing protocol items:" + Environment.NewLine + "- read bit: ID of the corresponding group param (mandatory)." + Environment.NewLine + "- write bit: ID of the corresponding group param (mandatory)." + Environment.NewLine + "- response: ID of the response responsible to further parse the value of this param (mandatory)." + Environment.NewLine + "- array: Semi-column list of column Param IDs (optional: depends on the type of table and the presence of ArrayOptions/ColumnOptions tags).",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingParam(IValidate test, IReadable referenceNode, IReadable positionNode, string referencedPid, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.NonExistingParam,
                FullId = "2.62.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Type@id", "Param", "ID", referencedPid, "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Depending on the Param.Type tag value, this attribute should refer to an existing protocol items:" + Environment.NewLine + "- read bit: ID of the corresponding group param (mandatory)." + Environment.NewLine + "- write bit: ID of the corresponding group param (mandatory)." + Environment.NewLine + "- response: ID of the response responsible to further parse the value of this param (mandatory)." + Environment.NewLine + "- array: Semi-column list of column Param IDs (optional: depends on the type of table and the presence of ArrayOptions/ColumnOptions tags).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingResponse(IValidate test, IReadable referenceNode, IReadable positionNode, string responseId, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.NonExistingResponse,
                FullId = "2.62.4",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Type@id", "Response", "ID", responseId, "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Depending on the Param.Type tag value, this attribute should refer to an existing protocol items:" + Environment.NewLine + "- read bit: ID of the corresponding group param (mandatory)." + Environment.NewLine + "- write bit: ID of the corresponding group param (mandatory)." + Environment.NewLine + "- response: ID of the response responsible to further parse the value of this param (mandatory)." + Environment.NewLine + "- array: Semi-column list of column Param IDs (optional: depends on the type of table and the presence of ArrayOptions/ColumnOptions tags).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingColumn(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.NonExistingColumn,
                FullId = "2.62.5",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Type@id", "Column", "PID", columnPid, "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Depending on the Param.Type tag value, this attribute should refer to an existing protocol items:" + Environment.NewLine + "- read bit: ID of the corresponding group param (mandatory)." + Environment.NewLine + "- write bit: ID of the corresponding group param (mandatory)." + Environment.NewLine + "- response: ID of the response responsible to further parse the value of this param (mandatory)." + Environment.NewLine + "- array: Semi-column list of column Param IDs (optional: depends on the type of table and the presence of ArrayOptions/ColumnOptions tags).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string paramType, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "2.62.6",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' due to '{1}' '{2}'. {3} {4} '{5}'.", "Type@id", "Param/Type", paramType, "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Depending on the Param.Type tag value, this attribute should refer to an existing protocol items:" + Environment.NewLine + "- read bit: ID of the corresponding group param (mandatory)." + Environment.NewLine + "- write bit: ID of the corresponding group param (mandatory)." + Environment.NewLine + "- response: ID of the response responsible to further parse the value of this param (mandatory)." + Environment.NewLine + "- array: Semi-column list of column Param IDs (optional: depends on the type of table and the presence of ArrayOptions/ColumnOptions tags).",
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
        public const uint NonExistingParam = 3;
        public const uint NonExistingResponse = 4;
        public const uint NonExistingColumn = 5;
        public const uint MissingAttribute = 6;
    }

    public static class CheckId
    {
        public const uint CheckIdAttribute = 62;
    }
}