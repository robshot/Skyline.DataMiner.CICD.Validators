namespace SLDisValidator2.Tests.Protocol.Params.Param.Measurement.Discreets.Discreet.CheckDiscreetTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult MissingTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDiscreetTag,
                ErrorId = ErrorIds.MissingTag,
                FullId = "2.52.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing 'Discreet' tag(s) in 'Measurement/Discreets' tag. Param ID '{0}'.", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Discreets tags should always have at least one of the following:" + Environment.NewLine + "- Discreet tag(s)" + Environment.NewLine + "- dependencyId attribute.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint MissingTag = 1;
    }

    public static class CheckId
    {
        public const uint CheckDiscreetTag = 52;
    }
}