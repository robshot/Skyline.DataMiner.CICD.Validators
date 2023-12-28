namespace SLDisValidator2.Tests.Protocol.Params.Param.Measurement.Discreets.CheckMatrixDiscreets
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult InvalidDiscreetCount(IValidate test, IReadable referenceNode, IReadable positionNode, string discreetCount, string expectedDiscreetCount, string matrixPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckMatrixDiscreets,
                ErrorId = ErrorIds.InvalidDiscreetCount,
                FullId = "2.41.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Invalid number of Discreets '{0}' for matrix Param. Expected count '{1}'. Param ID '{2}'.", discreetCount, expectedDiscreetCount, matrixPid),
                HowToFix = "Make sure the number of discreets is equal to the number of inputs + outputs as defined in the Param/Type@options dimension.",
                ExampleCode = "",
                Details = "For matrix read parameters, the number of discreets should correspond to sum of the number of inputs and the number of outputs." + Environment.NewLine + "Their values should be one-based and sequentially increasing by 1.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MissingDiscreetValue(IValidate test, IReadable referenceNode, IReadable positionNode, string missingValues, string matrixPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckMatrixDiscreets,
                ErrorId = ErrorIds.MissingDiscreetValue,
                FullId = "2.41.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Missing matrix Discreet values '{0}'. Param ID '{1}'.", missingValues, matrixPid),
                HowToFix = "Make sure Discreet values are sequentially incremented by 1.",
                ExampleCode = "",
                Details = "For matrix read parameters, the number of discreets should correspond to sum of the number of inputs and the number of outputs." + Environment.NewLine + "Their values should be one-based and sequentially increasing by 1.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DiscreetsNotOneBased(IValidate test, IReadable referenceNode, IReadable positionNode, string matrixPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckMatrixDiscreets,
                ErrorId = ErrorIds.DiscreetsNotOneBased,
                FullId = "2.41.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Matrix Discreet values should be one-based. Param ID '{0}'.", matrixPid),
                HowToFix = "Make sure the first discreet value is 1.",
                ExampleCode = "",
                Details = "For matrix read parameters, the number of discreets should correspond to sum of the number of inputs and the number of outputs." + Environment.NewLine + "Their values should be one-based and sequentially increasing by 1.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint InvalidDiscreetCount = 1;
        public const uint MissingDiscreetValue = 2;
        public const uint DiscreetsNotOneBased = 3;
    }

    public static class CheckId
    {
        public const uint CheckMatrixDiscreets = 41;
    }
}