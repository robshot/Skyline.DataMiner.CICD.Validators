namespace SLDisValidator2.Tests.Protocol.Params.Param.Measurement.Type.CheckWidthAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckWidthAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "2.10.1",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing (page)button width attribute. Param '{0}'.", pid),
                HowToFix = "Add Measurement.Type@width attribute with a value equal or greater than 110.",
                ExampleCode = "<Type width=\"110\">button</Type>",
                Details = "The recommended width for (page)buttons is 110." + Environment.NewLine + "When needed, (page)buttons can exceptionally be made larger but in that case, they need to be consistent through the driver page they belong to.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult EmptyWidth(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckWidthAttribute,
                ErrorId = ErrorIds.EmptyWidth,
                FullId = "2.10.2",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty (page)button width attribute. Param '{0}'.", pid),
                HowToFix = "Fill in Measurement.Type@width attribute with a value equal or greater than 110.",
                ExampleCode = "<Type width=\"110\">button</Type>",
                Details = "The recommended width for (page)buttons is 110." + Environment.NewLine + "When needed, (page)buttons can exceptionally be made larger but in that case, they need to be consistent through the driver page they belong to.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedWidth(IValidate test, IReadable referenceNode, IReadable positionNode, string untrimmedWidth, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckWidthAttribute,
                ErrorId = ErrorIds.UntrimmedWidth,
                FullId = "2.10.3",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed (page)button width attribute '{0}'. Param '{1}'.", untrimmedWidth, pid),
                HowToFix = "Remove leading and/or trailing whitespaces",
                ExampleCode = "<Type width=\"110\">button</Type>",
                Details = "The recommended width for (page)buttons is 110." + Environment.NewLine + "When needed, (page)buttons can exceptionally be made larger but in that case, they need to be consistent through the driver page they belong to.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidWidth(IValidate test, IReadable referenceNode, IReadable positionNode, string invalidWidth, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckWidthAttribute,
                ErrorId = ErrorIds.InvalidWidth,
                FullId = "2.10.4",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid (page)button width attribute '{0}'. Param '{1}'.", invalidWidth, pid),
                HowToFix = "Fill in Measurement.Type@width attribute with a value equal or greater than 110.",
                ExampleCode = "<Type width=\"110\">button</Type>",
                Details = "The recommended width for (page)buttons is 110." + Environment.NewLine + "When needed, (page)buttons can exceptionally be made larger but in that case, they need to be consistent through the driver page they belong to.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InconsistentWidth(IValidate test, IReadable referenceNode, IReadable positionNode, string pageName, string paramIDs, string widthValues, bool hasCodeFix)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckWidthAttribute,
                ErrorId = ErrorIds.InconsistentWidth,
                FullId = "2.10.5",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Inconsistent (page)buttons width on page '{0}'. PIDs '{1}' - Widths '{2}'.", pageName, paramIDs, widthValues),
                HowToFix = "Adjust the width of this button to the highest width value of all buttons on this page.",
                ExampleCode = "<Type width=\"110\">button</Type>",
                Details = "The recommended width for (page)buttons is 110." + Environment.NewLine + "When needed, (page)buttons can exceptionally be made larger but in that case, they need to be consistent through the driver page they belong to.",
                HasCodeFix = hasCodeFix,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnsupportedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string measurementType, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckWidthAttribute,
                ErrorId = ErrorIds.UnsupportedAttribute,
                FullId = "2.10.6",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("The width attribute is not supported for '{0}'. Param '{1}'.", measurementType, pid),
                HowToFix = "Remove the Measurement.Type@width attribute.",
                ExampleCode = "",
                Details = "Measurement.Type@width attribute is only supported for (page)button parameters.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedWidth(IValidate test, IReadable referenceNode, IReadable positionNode, string widthValue, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckWidthAttribute,
                ErrorId = ErrorIds.UnrecommendedWidth,
                FullId = "2.10.7",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unrecommended (page)button width '{0}'. Param '{1}'.", widthValue, pid),
                HowToFix = "",
                ExampleCode = "<Type width=\"110\">button</Type>",
                Details = "The recommended width for (page)buttons is 110." + Environment.NewLine + "When needed, (page)buttons can exceptionally be made larger but in that case, they need to be consistent through the driver page they belong to.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint MissingAttribute = 1;
        public const uint EmptyWidth = 2;
        public const uint UntrimmedWidth = 3;
        public const uint InvalidWidth = 4;
        public const uint InconsistentWidth = 5;
        public const uint UnsupportedAttribute = 6;
        public const uint UnrecommendedWidth = 7;
    }

    public static class CheckId
    {
        public const uint CheckWidthAttribute = 10;
    }
}