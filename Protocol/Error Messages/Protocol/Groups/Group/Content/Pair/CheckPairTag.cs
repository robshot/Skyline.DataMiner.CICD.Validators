namespace SLDisValidator2.Tests.Protocol.Groups.Group.Content.Pair.CheckPairTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string pairId, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPairTag,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "4.4.1",
                Category = Category.Group,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Tag '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Content/Pair", "Pair", "ID", pairId, "Group", "ID", groupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Group/Content tag should contain a list of 'Param', 'Pair', 'Session', 'Trigger' or 'Action' tags. Note that only one type of them is allowed for a specific Group." + Environment.NewLine + " - 'Param' tags should refer to the id of an existing Param." + Environment.NewLine + " - 'Pair' tags should refer to the id of an existing Pair." + Environment.NewLine + " - 'Session' tags should refer to the id of an existing HTTP/Session." + Environment.NewLine + " - 'Trigger' tags should refer to the id of an existing Trigger." + Environment.NewLine + " - 'Action' tags should refer to the id of an existing Action.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult EmptyPairTag(IValidate test, IReadable referenceNode, IReadable positionNode, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPairTag,
                ErrorId = ErrorIds.EmptyPairTag,
                FullId = "4.4.2",
                Category = Category.Group,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Content/Pair", "Group", groupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Group/Content tag should contain a list of 'Param', 'Pair', 'Session', 'Trigger' or 'Action' tags. Note that only one type of them is allowed for a specific Group." + Environment.NewLine + " - 'Param' tags should refer to the id of an existing Param." + Environment.NewLine + " - 'Pair' tags should refer to the id of an existing Pair." + Environment.NewLine + " - 'Session' tags should refer to the id of an existing HTTP/Session." + Environment.NewLine + " - 'Trigger' tags should refer to the id of an existing Trigger." + Environment.NewLine + " - 'Action' tags should refer to the id of an existing Action.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidPairTag(IValidate test, IReadable referenceNode, IReadable positionNode, string value, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPairTag,
                ErrorId = ErrorIds.InvalidPairTag,
                FullId = "4.4.3",
                Category = Category.Group,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}'. {2} {4} '{3}'.", value, "Content/Pair", "Group", groupId, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "Group/Content tag should contain a list of 'Param', 'Pair', 'Session', 'Trigger' or 'Action' tags. Note that only one type of them is allowed for a specific Group." + Environment.NewLine + " - 'Param' tags should refer to the id of an existing Param." + Environment.NewLine + " - 'Pair' tags should refer to the id of an existing Pair." + Environment.NewLine + " - 'Session' tags should refer to the id of an existing HTTP/Session." + Environment.NewLine + " - 'Trigger' tags should refer to the id of an existing Trigger." + Environment.NewLine + " - 'Action' tags should refer to the id of an existing Action.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint NonExistingId = 1;
        public const uint EmptyPairTag = 2;
        public const uint InvalidPairTag = 3;
    }

    public static class CheckId
    {
        public const uint CheckPairTag = 4;
    }
}