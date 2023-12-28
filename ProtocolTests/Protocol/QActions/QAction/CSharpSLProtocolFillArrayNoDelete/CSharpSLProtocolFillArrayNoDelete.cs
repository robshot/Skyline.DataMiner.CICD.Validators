namespace SLDisValidatorUnitTests.Protocol.QActions.QAction.CSharpSLProtocolFillArrayNoDelete
{
    using System;
    using System.Collections.Generic;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;
    using SLDisValidator2.Tests.Protocol.QActions.QAction.CSharpSLProtocolFillArrayNoDelete;

    [TestClass]
    public class Validate
    {
        private readonly IValidate check = new CSharpSLProtocolFillArrayNoDelete();

        #region Valid Checks

        [TestMethod]
        public void QAction_CSharpSLProtocolFillArrayNoDelete_Valid()
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
        public void QAction_CSharpSLProtocolFillArrayNoDelete_HardCodedPid()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "HardCodedPid",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.HardCodedPid(null, null, null, "2000", "103"),
                    Error.HardCodedPid(null, null, null, "2000", "103"),
                    Error.HardCodedPid(null, null, null, "2000", "103"),

                    Error.HardCodedPid(null, null, null, "2000", "103"),
                    Error.HardCodedPid(null, null, null, "2000", "103"),
                    Error.HardCodedPid(null, null, null, "2000", "103"),
                }
            };

            Generic.Validate(check, data);
        }

        [TestMethod]
        public void QAction_CSharpSLProtocolFillArrayNoDelete_NonExistingParam()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "NonExistingParam",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.NonExistingParam(null, null, null, "1000", "103"),
                    Error.NonExistingParam(null, null, null, "1100", "103"),
                    Error.NonExistingParam(null, null, null, "1200", "103"),
                    Error.HardCodedPid(null, null, null, "1000", "103"),
                    Error.HardCodedPid(null, null, null, "1100", "103"),
                    Error.HardCodedPid(null, null, null, "1200", "103"),

                    Error.NonExistingParam(null, null, null, "2000", "103"),
                    Error.NonExistingParam(null, null, null, "2100", "103"),
                    Error.NonExistingParam(null, null, null, "2200", "103"),
                    Error.HardCodedPid(null, null, null, "2000", "103"),
                    Error.HardCodedPid(null, null, null, "2100", "103"),
                    Error.HardCodedPid(null, null, null, "2200", "103"),
                    
		            // TODO: Not yet covered
                    //Error.NonExistingParam(null, null, null, "4000", "103"),
                    //Error.NonExistingParam(null, null, null, "4200", "103"),
                }
            };

            Generic.Validate(check, data);
        }

        [TestMethod]
        public void QAction_CSharpSLProtocolFillArrayNoDelete_ParamMissingHistorySet()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "ParamMissingHistorySet",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.ParamMissingHistorySet(null, null, null, "1002"),
                    Error.ParamMissingHistorySet(null, null, null, "1003"),

                    Error.ParamMissingHistorySet(null, null, null, "1102"),
                    Error.ParamMissingHistorySet(null, null, null, "1103"),
                    
		            // TODO: Not yet covered
                    //Error.ParamMissingHistorySet(null, null, null, "1002"),
                    //Error.ParamMissingHistorySet(null, null, null, "1003"),
                }
            };

            Generic.Validate(check, data);
        }

        #endregion
    }

    //[TestClass]
    public class CodeFix
    {
        private readonly ICodeFix codeFix = new CSharpSLProtocolFillArrayNoDelete();

        [TestMethod]
        public void Protocol_CSharpSLProtocolFillArrayNoDelete_ParamMissingHistorySet()
        {
            Generic.FixData data = new Generic.FixData
            {
                FileNameBase = "ParamMissingHistorySet",
            };

            Generic.Fix(codeFix, data);
        }
    }

    [TestClass]
    public class ErrorMessages
    {
        [TestMethod]
        public void QAction_CSharpSLProtocolFillArrayNoDelete_NonExistingParam()
        {
            // Create ErrorMessage
            var message = Error.NonExistingParam(null, null, null, "1", "2");

            var expected = new ValidationResult()
            {
                ErrorId = 1,
                FullId = "3.10.1",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "Method 'SLProtocol.FillArrayNoDelete' references a non-existing 'table' with PID '1'. QAction ID '2'.",
                HowToFix = "",
                ExampleCode = "",
                Details = "SLProtocol.FillArrayNoDelete is used to update a table with new values." + Environment.NewLine + "Make sure to provide it with an ID of a table parameter that exists." + Environment.NewLine + "Using Parameter class is recommended.",
                HasCodeFix = false,
            };

            // Assert
            message.Should().BeEquivalentTo(expected, Generic.ExcludePropertiesForErrorMessages);
        }

        [TestMethod]
        public void QAction_CSharpSLProtocolFillArrayNoDelete_ParamMissingHistorySet()
        {
            // Create ErrorMessage
            var message = Error.ParamMissingHistorySet(null, null, null, "1");

            var expected = new ValidationResult()
            {
                ErrorId = 2,
                FullId = "3.10.2",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "SLProtocol.FillArrayNoDelete overload with 'DateTime? timeInfo' argument requires 'Param@historySet=true'. column PID '1'.",
                HowToFix = "",
                ExampleCode = "",
                Details = "Every overload of the 'SLProtocol.FillArrayNoDelete' method having the 'DateTime? timeInfo' argument is meant to execute a historySet." + Environment.NewLine + "Such method requires the columns of the table to be set to have the 'Param@historySet' attribute set to 'true'.",
                HasCodeFix = true,
            };

            // Assert
            message.Should().BeEquivalentTo(expected, Generic.ExcludePropertiesForErrorMessages);
        }

        [TestMethod]
        public void QAction_CSharpSLProtocolFillArray_HardCodedPid()
        {
            // Create ErrorMessage
            var message = Error.HardCodedPid(null, null, null, "1", "2");

            var expected = new ValidationResult()
            {
                ErrorId = 3,
                FullId = "3.10.3",
                Category = Category.QAction,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "Unrecommended use of magic number '1', use 'Parameter' class instead. QAction ID '2'.",
                HowToFix = "",
                ExampleCode = "",
                Details = "SLProtocol.FillArrayNoDelete is used to update a table with new values." + Environment.NewLine + "Make sure to provide it with an ID of a table parameter that exists." + Environment.NewLine + "Using Parameter class is recommended.",
                HasCodeFix = false,
            };

            // Assert
            message.Should().BeEquivalentTo(expected, Generic.ExcludePropertiesForErrorMessages);
        }
    }

    [TestClass]
    public class Attribute
    {
        private readonly IRoot check = new CSharpSLProtocolFillArrayNoDelete();

        [TestMethod]
        public void QAction_CSharpSLProtocolFillArrayNoDelete_CheckCategory() => Generic.CheckCategory(check, Category.QAction);

        [TestMethod]
        public void QAction_CSharpSLProtocolFillArrayNoDelete_CheckId() => Generic.CheckId(check, CheckId.CSharpSLProtocolFillArrayNoDelete);
    }
}