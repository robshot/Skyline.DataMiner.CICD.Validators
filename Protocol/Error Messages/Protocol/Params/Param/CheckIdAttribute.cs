namespace SLDisValidator2.Tests.Protocol.Params.Param.CheckIdAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "2.1.1",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}'.", "Param@id"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The id attribute is used internally as the identifier for each param." + Environment.NewLine + "It is therefore mandatory and needs to follow a number of rules:" + Environment.NewLine + "- Each param should have a unique id." + Environment.NewLine + "- Should be an unsigned integer." + Environment.NewLine + "- Only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "2.1.2",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}'.", "Param@id"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The id attribute is used internally as the identifier for each param." + Environment.NewLine + "It is therefore mandatory and needs to follow a number of rules:" + Environment.NewLine + "- Each param should have a unique id." + Environment.NewLine + "- Should be an unsigned integer." + Environment.NewLine + "- Only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string paramName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "2.1.3",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. {2} {4} '{3}'.", "Param@id", pid, "Param", paramName, "name"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The id attribute is used internally as the identifier for each param." + Environment.NewLine + "It is therefore mandatory and needs to follow a number of rules:" + Environment.NewLine + "- Each param should have a unique id." + Environment.NewLine + "- Should be an unsigned integer." + Environment.NewLine + "- Only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult OutOfRangeId(IValidate test, IReadable referenceNode, IReadable positionNode, string id)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.OutOfRangeId,
                FullId = "2.1.5",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Out of range {0} ID '{1}'.", "Param", id),
                HowToFix = "",
                ExampleCode = "",
                Details = "Default allowed ranges are:" + Environment.NewLine + "- 1 -> 64.299" + Environment.NewLine + "- 70.000 -> 99.999" + Environment.NewLine + "- 1.000.000 -> 9.999.999" + Environment.NewLine + "" + Environment.NewLine + "There are exception for spectrum, base, Enhanced Service, SLA and Aggregation drivers. For more information about those exceptions, please check the protocol reference guide.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidUseOfSpectrumIdRange(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.InvalidUseOfSpectrumIdRange,
                FullId = "2.1.6",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Invalid use of Spectrum ID range for Param with ID '{0}'.", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidUseOfMediationIdRange(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.InvalidUseOfMediationIdRange,
                FullId = "2.1.7",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Invalid use of Mediation ID range for Param with ID '{0}'.", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidUseOfDataMinerModulesIdRange(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.InvalidUseOfDataMinerModulesIdRange,
                FullId = "2.1.8",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Invalid use of DataMiner Modules ID range for Param with ID '{0}'.", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidUseOfEnhancedServiceIdRange(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.InvalidUseOfEnhancedServiceIdRange,
                FullId = "2.1.9",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Invalid use of Enhanced Service ID range for Param with ID '{0}'.", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidUseOfSlaIdRange(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.InvalidUseOfSlaIdRange,
                FullId = "2.1.10",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Invalid use of SLA ID range for Param with ID '{0}'.", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DuplicatedId(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string paramNames)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.DuplicatedId,
                FullId = "2.1.11",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("More than one {0} with same ID '{1}'. {0} Names '{2}'.", "Param", pid, paramNames),
                HowToFix = "",
                ExampleCode = "",
                Details = "The id attribute is used internally as the identifier for each param." + Environment.NewLine + "It is therefore mandatory and needs to follow a number of rules:" + Environment.NewLine + "- Each param should have a unique id." + Environment.NewLine + "- Should be an unsigned integer." + Environment.NewLine + "- Only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string attributeValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "2.1.13",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}'. Current value '{1}'.", "Param@id", attributeValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The id attribute is used internally as the identifier for each param." + Environment.NewLine + "It is therefore mandatory and needs to follow a number of rules:" + Environment.NewLine + "- Each param should have a unique id." + Environment.NewLine + "- Should be an unsigned integer." + Environment.NewLine + "- Only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult RTDisplayExpectedOnSpectrumParam(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.RTDisplayExpectedOnSpectrumParam,
                FullId = "2.1.14",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on Spectrum Params. Param ID '{0}'.", pid),
                HowToFix = "Either the parameter should be removed, either its RTDisplay tag should be set to true.",
                ExampleCode = "",
                Details = "Parameters with ID in the range [64 000, 64 299] are considered as spectrum parameters." + Environment.NewLine + "Such spectrum Param should have its RTDisplay set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorCompare
    {
        public static IValidationResult MissingParam(IReadable referenceNode, IReadable positionNode, string paramName, string paramType, string paramId)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.MissingParam,
                FullId = "2.1.12",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Missing displayed Param. Param Name '{0}'. Param Type '{1}'. Param ID '{2}'.", paramName, paramType, paramId),
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
        public const uint MissingAttribute = 1;
        public const uint EmptyAttribute = 2;
        public const uint InvalidValue = 3;
        public const uint OutOfRangeId = 5;
        public const uint InvalidUseOfSpectrumIdRange = 6;
        public const uint InvalidUseOfMediationIdRange = 7;
        public const uint InvalidUseOfDataMinerModulesIdRange = 8;
        public const uint InvalidUseOfEnhancedServiceIdRange = 9;
        public const uint InvalidUseOfSlaIdRange = 10;
        public const uint DuplicatedId = 11;
        public const uint MissingParam = 12;
        public const uint UntrimmedAttribute = 13;
        public const uint RTDisplayExpectedOnSpectrumParam = 14;
    }

    public static class CheckId
    {
        public const uint CheckIdAttribute = 1;
    }
}