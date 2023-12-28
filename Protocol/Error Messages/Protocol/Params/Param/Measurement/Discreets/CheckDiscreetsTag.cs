namespace SLDisValidator2.Tests.Protocol.Params.Param.Measurement.Discreets.CheckDiscreetsTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult MissingTag(IValidate test, IReadable referenceNode, IReadable positionNode, string paramDisplayType, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDiscreetsTag,
                ErrorId = ErrorIds.MissingTag,
                FullId = "2.51.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing '{0}' tag for '{1}' Param with ID '{2}'.", "Measurement/Discreets", paramDisplayType, pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Button, pagebutton and discreet parameters should always have the Discreets tag." + Environment.NewLine + "Additionally, Discreets tags should always have at least one of the following:" + Environment.NewLine + "- Discreet tag(s)" + Environment.NewLine + "- dependencyId attribute.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MissingTag = 1;
    }

    public static class CheckId
    {
        public const uint CheckDiscreetsTag = 51;
    }
}