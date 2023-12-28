namespace SLDisValidator2.Tests.Protocol.Params.Param.SNMP.OID.CheckIdAttribute
{
    using System;
    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    internal static class Error
    {
        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "2.48.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "SNMP/OID@id", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The SNMP/OID@id attribute needs to refer to a standalone read or bus Param and can be used in following situations:" + Environment.NewLine + "- Subtables: the id should refer to a parameter that will allow to filter on the list of instances to be polled." + Environment.NewLine + "- Tables with filtered rows: each column should contain an id attribute that refers to a parameter that will allow to filter on the instances to be polled." + Environment.NewLine + "- Dynamic OID: the id should refer to a parameter that will allow to dynamically define the full OID." + Environment.NewLine + "Except for subtables, the id attribute only makes sense in case a wildcard is present in the OID tag value.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidAttributeValue(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string currentValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.InvalidAttributeValue,
                FullId = "2.48.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported attribute '{0}' in {1} '{2}'. Current value '{3}'.", "SNMP/OID@id", "Param", pid, currentValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The SNMP/OID@id attribute needs to refer to a standalone read or bus Param and can be used in following situations:" + Environment.NewLine + "- Subtables: the id should refer to a parameter that will allow to filter on the list of instances to be polled." + Environment.NewLine + "- Tables with filtered rows: each column should contain an id attribute that refers to a parameter that will allow to filter on the instances to be polled." + Environment.NewLine + "- Dynamic OID: the id should refer to a parameter that will allow to dynamically define the full OID." + Environment.NewLine + "Except for subtables, the id attribute only makes sense in case a wildcard is present in the OID tag value.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingParam(IValidate test, IReadable referenceNode, IReadable positionNode, string referencedPid, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.NonExistingParam,
                FullId = "2.48.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "SNMP/OID@id", "Param", "ID", referencedPid, "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The SNMP/OID@id attribute needs to refer to a standalone read or bus Param and can be used in following situations:" + Environment.NewLine + "- Subtables: the id should refer to a parameter that will allow to filter on the list of instances to be polled." + Environment.NewLine + "- Tables with filtered rows: each column should contain an id attribute that refers to a parameter that will allow to filter on the instances to be polled." + Environment.NewLine + "- Dynamic OID: the id should refer to a parameter that will allow to dynamically define the full OID." + Environment.NewLine + "Except for subtables, the id attribute only makes sense in case a wildcard is present in the OID tag value.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UnsupportedParam(IValidate test, IReadable referenceNode, IReadable positionNode, string idAttributeValue, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.UnsupportedParam,
                FullId = "2.48.4",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported Param '{0}' reference in attribute 'SNMP/OID@id' in Param '{1}'.", idAttributeValue, pid),
                HowToFix = "Refer to a standalone read param.",
                ExampleCode = "",
                Details = "The SNMP/OID@id attribute needs to refer to a standalone read or bus Param and can be used in following situations:" + Environment.NewLine + "- Subtables: the id should refer to a parameter that will allow to filter on the list of instances to be polled." + Environment.NewLine + "- Tables with filtered rows: each column should contain an id attribute that refers to a parameter that will allow to filter on the instances to be polled." + Environment.NewLine + "- Dynamic OID: the id should refer to a parameter that will allow to dynamically define the full OID." + Environment.NewLine + "Except for subtables, the id attribute only makes sense in case a wildcard is present in the OID tag value.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "2.48.5",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "SNMP/OID@id", "Param", pid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The SNMP/OID@id attribute needs to refer to a standalone read or bus Param and can be used in following situations:" + Environment.NewLine + "- Subtables: the id should refer to a parameter that will allow to filter on the list of instances to be polled." + Environment.NewLine + "- Tables with filtered rows: each column should contain an id attribute that refers to a parameter that will allow to filter on the instances to be polled." + Environment.NewLine + "- Dynamic OID: the id should refer to a parameter that will allow to dynamically define the full OID." + Environment.NewLine + "Except for subtables, the id attribute only makes sense in case a wildcard is present in the OID tag value.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint EmptyAttribute = 1;
        public const uint InvalidAttributeValue = 2;
        public const uint NonExistingParam = 3;
        public const uint UnsupportedParam = 4;
        public const uint UntrimmedAttribute = 5;
    }

    public static class CheckId
    {
        public const uint CheckIdAttribute = 48;
    }
}