namespace SLDisValidator2.Tests.Protocol.Params.CheckLoadSequenceAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckLoadSequenceAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "2.56.1",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}'.", "Params@loadSequence"),
                HowToFix = "",
                ExampleCode = "",
                Details = "'Params@loadSequence' expects a semicolon separated list of Param IDs allowing to define the order in which saved parameter values are loaded in SLElement." + Environment.NewLine + "Referenced parameters are expected to:" + Environment.NewLine + "- Have the save attribute set to 'true'" + Environment.NewLine + "- Have the RTDisplay tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckLoadSequenceAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "2.56.2",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}'. Current value '{1}'.", "Params@loadSequence", untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "'Params@loadSequence' expects a semicolon separated list of Param IDs allowing to define the order in which saved parameter values are loaded in SLElement." + Environment.NewLine + "Referenced parameters are expected to:" + Environment.NewLine + "- Have the save attribute set to 'true'" + Environment.NewLine + "- Have the RTDisplay tag set to 'true'.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckLoadSequenceAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "2.56.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}@{1}' references a non-existing '{2}' with {3} '{4}'.", "Params", "loadSequence", "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "'Params@loadSequence' expects a semicolon separated list of Param IDs allowing to define the order in which saved parameter values are loaded in SLElement." + Environment.NewLine + "Referenced parameters are expected to:" + Environment.NewLine + "- Have the save attribute set to 'true'" + Environment.NewLine + "- Have the RTDisplay tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ReferencedParamSaveExpected(IValidate test, IReadable referenceNode, IReadable positionNode, string referencedPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckLoadSequenceAttribute,
                ErrorId = ErrorIds.ReferencedParamSaveExpected,
                FullId = "2.56.5",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Param '{0}' referenced by 'Params@loadSequence' attribute is expected to be saved.", referencedPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "'Params@loadSequence' expects a semicolon separated list of Param IDs allowing to define the order in which saved parameter values are loaded in SLElement." + Environment.NewLine + "Referenced parameters are expected to:" + Environment.NewLine + "- Have the save attribute set to 'true'" + Environment.NewLine + "- Have the RTDisplay tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ReferencedParamRTDisplayExpected(IValidate test, IReadable referenceNode, IReadable positionNode, string referencedPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckLoadSequenceAttribute,
                ErrorId = ErrorIds.ReferencedParamRTDisplayExpected,
                FullId = "2.56.6",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on Param '{0}' referenced by 'Params@loadSequence' attribute.", referencedPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "'Params@loadSequence' expects a semicolon separated list of Param IDs allowing to define the order in which saved parameter values are loaded in SLElement." + Environment.NewLine + "Referenced parameters are expected to:" + Environment.NewLine + "- Have the save attribute set to 'true'" + Environment.NewLine + "- Have the RTDisplay tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint EmptyAttribute = 1;
        public const uint UntrimmedAttribute = 2;
        public const uint NonExistingId = 3;
        public const uint ReferencedParamSaveExpected = 5;
        public const uint ReferencedParamRTDisplayExpected = 6;
    }

    public static class CheckId
    {
        public const uint CheckLoadSequenceAttribute = 56;
    }
}