namespace SLDisValidator2.Tests.Protocol.Params.Param.Display.Units.CheckUnitsTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckUnitsTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "2.9.2",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Units", "Param", pid),
                HowToFix = "Either add a correct unit, either remove the Unit tag.",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult OutdatedValue(IValidate test, IReadable referenceNode, IReadable positionNode, string obsoleteUnit, string newUnit, string paramPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckUnitsTag,
                ErrorId = ErrorIds.OutdatedValue,
                FullId = "2.9.3",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Obsolete unit '{0}'. New syntax '{1}'. Param ID '{2}'.", obsoleteUnit, newUnit, paramPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidTag(IValidate test, IReadable referenceNode, IReadable positionNode, string unitValue, string paramPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckUnitsTag,
                ErrorId = ErrorIds.InvalidTag,
                FullId = "2.9.4",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unknown unit '{0}'. Param ID '{1}'.", unitValue, paramPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UnsupportedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string paramDisplayType, string paramPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckUnitsTag,
                ErrorId = ErrorIds.UnsupportedTag,
                FullId = "2.9.5",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported '{0}' tag for '{1}' Param with ID '{2}'.", "Units", paramDisplayType, paramPid),
                HowToFix = "Remove the Units tag.",
                ExampleCode = "",
                Details = "Depending on the type of displayed Param, it does not always make sense to add a unit. Example: adding a unit to a table Param.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ExcessiveTag(IValidate test, IReadable referenceNode, IReadable positionNode, string tagName, string reason, string paramPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckUnitsTag,
                ErrorId = ErrorIds.ExcessiveTag,
                FullId = "2.9.6",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Excessive tag '{0}' because of {1}. Param ID '{2}'.", tagName, reason, paramPid),
                HowToFix = "Remove the unit.",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingTag(IValidate test, IReadable referenceNode, IReadable positionNode, string paramDisplayType, string paramPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckUnitsTag,
                ErrorId = ErrorIds.MissingTag,
                FullId = "2.9.7",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "Missing tag 'Display/Units' in some parameters.",
                Description = String.Format("Missing '{0}' tag for '{1}' Param with ID '{2}'.", "Units", paramDisplayType, paramPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckUnitsTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "2.9.8",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Units", "Param", pid, untrimmedValue),
                HowToFix = "Remove leading and/or trailing whitespaces.",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint EmptyTag = 2;
        public const uint OutdatedValue = 3;
        public const uint InvalidTag = 4;
        public const uint UnsupportedTag = 5;
        public const uint ExcessiveTag = 6;
        public const uint MissingTag = 7;
        public const uint UntrimmedTag = 8;
    }

    public static class CheckId
    {
        public const uint CheckUnitsTag = 9;
    }
}