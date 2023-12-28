namespace SLDisValidatorUnitTests.Protocol.QActions.QAction.Condition.CheckConditionTag
{
    using System;
    using System.Collections.Generic;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;
    using SLDisValidator2.Tests.Protocol.QActions.QAction.Condition.CheckConditionTag;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    [TestClass]
    public class Validate
    {
        private readonly IValidate check = new CheckConditionTag();

        #region Valid Checks

        [TestMethod]
        public void QAction_CheckConditionTag_Valid()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Valid,
                FileName = "Valid",
                ExpectedResults = new List<IValidationResult>()
            };

            Generic.Validate(check, data);
        }

        #endregion

        #region Invalid Checks

        [TestMethod]
        public void QAction_CheckConditionTag_InvalidCondition()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "InvalidCondition",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.InvalidCondition(null, null, null, "", "Condition is empty.", "1"),
                    Error.InvalidCondition(null, null, null, "((id:12 + \"efg\") + 10) == \"defefgabc\"", "The addition operator ('+') must be used with operands of the same type.", "2")
                }
            };

            Generic.Validate(check, data);
        }

        [TestMethod]
        public void QAction_CheckConditionTag_NonExistingId()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "NonExistingId",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.NonExistingId(null, null, null, "10", "1")
                }
            };

            Generic.Validate(check, data);
        }

        [TestMethod]
        public void QAction_CheckConditionTag_ConditionCanBeSimplified()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "ConditionCanBeSimplified",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.ConditionCanBeSimplified(null, null, null, "id:12 == (\"test\")", "1")
                }
            };

            Generic.Validate(check, data);
        }
        #endregion
    }

    [TestClass]
    public class ErrorMessages
    {
        [TestMethod]
        public void QAction_CheckConditionTag_InvalidCondition()
        {
            // Create ErrorMessage
            var message = Error.InvalidCondition(null, null, null, "currentCondition", "reason", "100");

            var expected = new ValidationResult
            {
                ErrorId = 1,
                FullId = "3.35.1",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "Invalid condition 'currentCondition'. Reason 'reason'. QAction ID '100'.",
                HowToFix = "",
                ExampleCode = "",
                Details = "A 'QAction/Condition' should always contain a statement returning a boolean." + Environment.NewLine + "See DDL for more information." + Environment.NewLine + "" + Environment.NewLine + "Here are a few examples of mistakes covered by this error:" + Environment.NewLine + "- Empty condition." + Environment.NewLine + "- Malformed condition:" + Environment.NewLine + "  - The 'id:' placeholder used to retrieve a parameter value is incorrectly defined." + Environment.NewLine + "  - The number of opening & closing parentheses is not matching." + Environment.NewLine + "  - '&&', '||' is used instead of 'AND', 'OR'." + Environment.NewLine + "- Condition that is not a boolean expression." + Environment.NewLine + "- Fully hard-coded boolean expression (No reference to any parameter value)." + Environment.NewLine + "- etc.",
                HasCodeFix = false
            };

            // Assert
            message.Should().BeEquivalentTo(expected, Generic.ExcludePropertiesForErrorMessages);
        }

        [TestMethod]
        public void QAction_CheckConditionTag_NonExistingId()
        {
            // Create ErrorMessage
            var message = Error.NonExistingId(null, null, null, "2", "3");
                        
            var expected = new ValidationResult
            {
                ErrorId = 2,
                FullId = "3.35.2",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "Tag 'QAction/Condition' references a non-existing 'Param' with PID '2'. QAction ID '3'.",
                HowToFix = "",
                ExampleCode = "",
                Details = "A 'QAction/Condition' should always contain a statement returning a boolean." + Environment.NewLine + "See DDL for more information." + Environment.NewLine + "" + Environment.NewLine + "Here are a few examples of mistakes covered by this error:" + Environment.NewLine + "- Empty condition." + Environment.NewLine + "- Malformed condition:" + Environment.NewLine + "  - The 'id:' placeholder used to retrieve a parameter value is incorrectly defined." + Environment.NewLine + "  - The number of opening & closing parentheses is not matching." + Environment.NewLine + "  - '&&', '||' is used instead of 'AND', 'OR'." + Environment.NewLine + "- Condition that is not a boolean expression." + Environment.NewLine + "- Fully hard-coded boolean expression (No reference to any parameter value)." + Environment.NewLine + "- etc.",
                HasCodeFix = false
            };

            // Assert
            message.Should().BeEquivalentTo(expected, Generic.ExcludePropertiesForErrorMessages);
        }
    }

    [TestClass]
    public class Attribute
    {
        private readonly IRoot check = new CheckConditionTag();

        [TestMethod]
        public void QAction_CheckConditionTag_CheckCategory() => Generic.CheckCategory(check, Category.QAction);

        [TestMethod]
        public void QAction_CheckConditionTag_CheckId() => Generic.CheckId(check, CheckId.CheckConditionTag);
    }
}