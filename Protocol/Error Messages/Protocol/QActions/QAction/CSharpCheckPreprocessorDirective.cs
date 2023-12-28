namespace SLDisValidator2.Tests.Protocol.QActions.QAction.CSharpCheckPreprocessorDirective
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult ObsoleteDcfV1(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckPreprocessorDirective,
                ErrorId = ErrorIds.ObsoleteDcfV1,
                FullId = "3.13.1",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Obsolete preprocessor directive '{0}' used in QAction. QAction ID '{1}'.", "DCFv1", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "DCFv1 preprocessor directive was used in the past in order to support older DM versions that didn't support DCF yet." + Environment.NewLine + "However, by now, our minimum DM supported version already has DCF support so this DCFv1 preprocessor directive is of no use anymore." + Environment.NewLine + "Moreover, in some cases, such preprocessor directive makes it harder to pinpoint issues so we highly recommend to fully remove the now useless DCFv1 directives (even commented out ones) from all protocols.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint ObsoleteDcfV1 = 1;
    }

    public static class CheckId
    {
        public const uint CSharpCheckPreprocessorDirective = 13;
    }
}