namespace SLDisValidator2.Tests.Protocol.Params.Param.Measurement.Discreets.Discreet.Display.CheckDisplayTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult InvalidPagebuttonCaption(IValidate test, IReadable referenceNode, IReadable positionNode, string displayValue, string suggestedValue, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.InvalidPagebuttonCaption,
                FullId = "2.13.2",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid pagebutton caption format '{0}'. Suggested fix '{1}'. Param ID '{2}'.", displayValue, suggestedValue, paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "For pagebuttons, the display tag should end with ellipsis (…) without any space before nor after it.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MissingTag(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.MissingTag,
                FullId = "2.13.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing tag '{0}' in {1} '{2}'.", "Discreet/Display", "Param", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Discreet tags should always contain a unique Display tag (user-friendly value) and a unique Value tag (internal value).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "2.13.4",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Discreet/Display", "Param", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Discreet tags should always contain a unique Display tag (user-friendly value) and a unique Value tag (internal value).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "2.13.5",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Discreet/Display", "Param", paramId, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Discreet tags should always contain a unique Display tag (user-friendly value) and a unique Value tag (internal value).",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DuplicatedValue(IValidate test, IReadable referenceNode, IReadable positionNode, string duplicateValue, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.DuplicatedValue,
                FullId = "2.13.6",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicated {0} {1} '{2}'. {0} IDs '{3}'.", "Param", "Discreet/Display", duplicateValue, paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Discreet tags should always contain a unique Display tag (user-friendly value) and a unique Value tag (internal value).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult WrongCasing_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string currentValue, string expectedValue, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.WrongCasing_Sub,
                FullId = "2.13.7",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Current value '{0}'. Expected value '{1}'. {2} {3} '{4}'.", currentValue, expectedValue, "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Discreet/Display values should follow following title case rules:" + Environment.NewLine + "- Should start with a capital" + Environment.NewLine + "    - First and last word" + Environment.NewLine + "    - Important words (verbs, nouns, adjective, adverb, etc)" + Environment.NewLine + "- Should not start with a capital" + Environment.NewLine + "    - Articles (a, an, the)" + Environment.NewLine + "    - Coordinating conjuctions (and, but, for, nor, or, so, yet)" + Environment.NewLine + "    - Preposition with <4 chars (at, by, to...)",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult WrongCasing(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.WrongCasing,
                FullId = "2.13.8",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("'{0}' values do not follow {1} rules.", "Discreet/Display", "title casing"),
                HowToFix = "",
                ExampleCode = "",
                Details = "Discreet/Display values should follow following title case rules:" + Environment.NewLine + "- Should start with a capital" + Environment.NewLine + "    - First and last word" + Environment.NewLine + "    - Important words (verbs, nouns, adjective, adverb, etc)" + Environment.NewLine + "- Should not start with a capital" + Environment.NewLine + "    - Articles (a, an, the)" + Environment.NewLine + "    - Coordinating conjuctions (and, but, for, nor, or, so, yet)" + Environment.NewLine + "    - Preposition with <4 chars (at, by, to...)",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorCompare
    {
        public static IValidationResult UpdatedValue(IReadable referenceNode, IReadable positionNode, string oldValue, string paramId, string previousDispay, string newDisplay)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.UpdatedValue,
                FullId = "2.13.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Discreet display tag with value '{0}' on Param '{1}' was changed from '{2}' into '{3}'.", oldValue, paramId, previousDispay, newDisplay),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint UpdatedValue = 1;
        public const uint InvalidPagebuttonCaption = 2;
        public const uint MissingTag = 3;
        public const uint EmptyTag = 4;
        public const uint UntrimmedTag = 5;
        public const uint DuplicatedValue = 6;
        public const uint WrongCasing_Sub = 7;
        public const uint WrongCasing = 8;
    }

    public static class CheckId
    {
        public const uint CheckDisplayTag = 13;
    }
}