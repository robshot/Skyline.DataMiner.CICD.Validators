namespace SLDisValidator2.Tests.Protocol.Params.Param.Measurement.Type.CheckLinkAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult InvalidAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string matrixPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckLinkAttribute,
                ErrorId = ErrorIds.InvalidAttribute,
                FullId = "2.42.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid syntax for 'Measurement/Type@link' attribute on matrix Param. Matrix PID '{0}'.", matrixPid),
                HowToFix = "Make sure the value contains a valid file name including the .xml extension.",
                ExampleCode = "",
                Details = "This attribute causes an XML file to be created on the system. Make sure the value contains a valid file name including the .xml extension.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string matrixPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckLinkAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "2.42.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' in {1} '{2}'.", "Measurement/Type@link", "matrix", matrixPid),
                HowToFix = "Add link=\"XXXXXXXX.xml\"",
                ExampleCode = "",
                Details = "This attribute causes an XML file to be created on the system. Make sure the value contains a valid file name including the .xml extension.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint InvalidAttribute = 1;
        public const uint MissingAttribute = 2;
    }

    public static class CheckId
    {
        public const uint CheckLinkAttribute = 42;
    }
}