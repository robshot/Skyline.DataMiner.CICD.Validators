namespace SLDisValidator2.Tests.Protocol.Actions.Action.Condition.CheckConditionTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult InvalidCondition(IValidate test, IReadable referenceNode, IReadable positionNode, string conditionString, string invalidityReason, string actionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConditionTag,
                ErrorId = ErrorIds.InvalidCondition,
                FullId = "6.4.1",
                Category = Category.Action,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid condition '{0}'. Reason '{1}'. {2} {3} '{4}'.", conditionString, invalidityReason, "Action", "ID", actionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "A 'Action/Condition' should always contain a statement returning a boolean." + Environment.NewLine + "See DDL for more information." + Environment.NewLine + "" + Environment.NewLine + "Here are a few examples of mistakes covered by this error:" + Environment.NewLine + "- Empty condition." + Environment.NewLine + "- Malformed condition:" + Environment.NewLine + "  - The 'id:' placeholder used to retrieve a parameter value is incorrectly defined." + Environment.NewLine + "  - The number of opening & closing parentheses is not matching." + Environment.NewLine + "  - '&&', '||' is used instead of 'AND', 'OR'." + Environment.NewLine + "- Condition that is not a boolean expression." + Environment.NewLine + "- Fully hard-coded boolean expression (No reference to any parameter value)." + Environment.NewLine + "- etc.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId, string actionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConditionTag,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "6.4.2",
                Category = Category.Action,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Tag '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Action/Condition", "Param", "PID", paramId, "Action", "ID", actionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "A 'Action/Condition' should always contain a statement returning a boolean." + Environment.NewLine + "See DDL for more information." + Environment.NewLine + "" + Environment.NewLine + "Here are a few examples of mistakes covered by this error:" + Environment.NewLine + "- Empty condition." + Environment.NewLine + "- Malformed condition:" + Environment.NewLine + "  - The 'id:' placeholder used to retrieve a parameter value is incorrectly defined." + Environment.NewLine + "  - The number of opening & closing parentheses is not matching." + Environment.NewLine + "  - '&&', '||' is used instead of 'AND', 'OR'." + Environment.NewLine + "- Condition that is not a boolean expression." + Environment.NewLine + "- Fully hard-coded boolean expression (No reference to any parameter value)." + Environment.NewLine + "- etc.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ConditionCanBeSimplified(IValidate test, IReadable referenceNode, IReadable positionNode, string conditionString, string actionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConditionTag,
                ErrorId = ErrorIds.ConditionCanBeSimplified,
                FullId = "6.4.3",
                Category = Category.Action,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Condition '{0}' can be simplified. {1} {2} '{3}'.", conditionString, "Action", "ID", actionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Action/Condition' can be simplified. Some examples of when the condition can be simplified:" + Environment.NewLine + "  - The condition contains redundant parentheses." + Environment.NewLine + "  - The condition does not contain a variable and therefore can either be dropped completely (or a variable must be included).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint InvalidCondition = 1;
        public const uint NonExistingId = 2;
        public const uint ConditionCanBeSimplified = 3;
    }

    public static class CheckId
    {
        public const uint CheckConditionTag = 4;
    }
}