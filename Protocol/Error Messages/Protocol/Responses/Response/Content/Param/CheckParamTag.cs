namespace SLDisValidator2.Tests.Protocol.Responses.Response.Content.Param.CheckParamTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string referencedPid, string responseId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParamTag,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "11.3.1",
                Category = Category.Response,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Tag '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Content/Param", "Param", "ID", referencedPid, "Response", "ID", responseId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Response/Content tag should contain a list of 'Param' tags. The 'Param' tags should refer to the id of an existing Param.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyParamTag(IValidate test, IReadable referenceNode, IReadable positionNode, string responseId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParamTag,
                ErrorId = ErrorIds.EmptyParamTag,
                FullId = "11.3.2",
                Category = Category.Response,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Content/Param", "Response", responseId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Response/Content tag should contain a list of 'Param' tags. The 'Param' tags should refer to the id of an existing Param.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidParamTag(IValidate test, IReadable referenceNode, IReadable positionNode, string value, string responseId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParamTag,
                ErrorId = ErrorIds.InvalidParamTag,
                FullId = "11.3.3",
                Category = Category.Response,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}'. {2} {4} '{3}'.", value, "Content/Param", "Response", responseId, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "Response/Content tag should contain a list of 'Param' tags. The 'Param' tags should refer to the id of an existing Param.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint NonExistingId = 1;
        public const uint EmptyParamTag = 2;
        public const uint InvalidParamTag = 3;
    }

    public static class CheckId
    {
        public const uint CheckParamTag = 3;
    }
}