namespace SLDisValidator2.Tests.Protocol.Type.CheckAdvancedAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckAdvancedAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "1.11.4",
                Category = Category.Protocol,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}'.", "Protocol/Type@advanced"),
                HowToFix = "",
                ExampleCode = "",
                Details = "- When having only one connection for a specific type, the name needs to be of following format, where the second option can (optionally) be used to add more info about the goal of the connection (ex: XXX = Traps, XXX = Events, XXX = Alarms, etc):" + Environment.NewLine + "     - \"IP Connection\" or \"IP Connection - XXX\": for drivers that support TCP and/or UDP" + Environment.NewLine + "     - \"HTTP Connection\" or \"HTTP Connection - XXX\"" + Environment.NewLine + "     - \"SSH Connection\" or \"SSH Connection - XXX\"" + Environment.NewLine + "     - \"SNMP Connection\" or \"SNMP Connection - XXX\"" + Environment.NewLine + "     - \"Serial Connection\" or \"Serial Connection - XXX\": for drivers that only support the physical serial port (driver connection of type serial but not support TCP nor UDP)" + Environment.NewLine + "- When having more than one connection for a specific type, the name need to be of following format where XXX is used to distinguish them (ex: XXX = Redundant, XXX = Redundant 2, XXX = Backup, XXX = Traps, XXX = Events, etc):" + Environment.NewLine + "     - \"IP Connection - XXX\"" + Environment.NewLine + "     - \"HTTP Connection - XXX\"" + Environment.NewLine + "     - etc",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string attributeValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckAdvancedAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "1.11.5",
                Category = Category.Protocol,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}'. Current value '{1}'.", "Protocol/Type@advanced", attributeValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "- When having only one connection for a specific type, the name needs to be of following format, where the second option can (optionally) be used to add more info about the goal of the connection (ex: XXX = Traps, XXX = Events, XXX = Alarms, etc):" + Environment.NewLine + "     - \"IP Connection\" or \"IP Connection - XXX\": for drivers that support TCP and/or UDP" + Environment.NewLine + "     - \"HTTP Connection\" or \"HTTP Connection - XXX\"" + Environment.NewLine + "     - \"SSH Connection\" or \"SSH Connection - XXX\"" + Environment.NewLine + "     - \"SNMP Connection\" or \"SNMP Connection - XXX\"" + Environment.NewLine + "     - \"Serial Connection\" or \"Serial Connection - XXX\": for drivers that only support the physical serial port (driver connection of type serial but not support TCP nor UDP)" + Environment.NewLine + "- When having more than one connection for a specific type, the name need to be of following format where XXX is used to distinguish them (ex: XXX = Redundant, XXX = Redundant 2, XXX = Backup, XXX = Traps, XXX = Events, etc):" + Environment.NewLine + "     - \"IP Connection - XXX\"" + Environment.NewLine + "     - \"HTTP Connection - XXX\"" + Environment.NewLine + "     - etc",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedValueInAttribute_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckAdvancedAttribute,
                ErrorId = ErrorIds.UntrimmedValueInAttribute_Sub,
                FullId = "1.11.6",
                Category = Category.Protocol,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed value '{0}' in attribute '{1}'.", untrimmedValue, "Protocol/Type@advanced"),
                HowToFix = "",
                ExampleCode = "",
                Details = "- When having only one connection for a specific type, the name needs to be of following format, where the second option can (optionally) be used to add more info about the goal of the connection (ex: XXX = Traps, XXX = Events, XXX = Alarms, etc):" + Environment.NewLine + "     - \"IP Connection\" or \"IP Connection - XXX\": for drivers that support TCP and/or UDP" + Environment.NewLine + "     - \"HTTP Connection\" or \"HTTP Connection - XXX\"" + Environment.NewLine + "     - \"SSH Connection\" or \"SSH Connection - XXX\"" + Environment.NewLine + "     - \"SNMP Connection\" or \"SNMP Connection - XXX\"" + Environment.NewLine + "     - \"Serial Connection\" or \"Serial Connection - XXX\": for drivers that only support the physical serial port (driver connection of type serial but not support TCP nor UDP)" + Environment.NewLine + "- When having more than one connection for a specific type, the name need to be of following format where XXX is used to distinguish them (ex: XXX = Redundant, XXX = Redundant 2, XXX = Backup, XXX = Traps, XXX = Events, etc):" + Environment.NewLine + "     - \"IP Connection - XXX\"" + Environment.NewLine + "     - \"HTTP Connection - XXX\"" + Environment.NewLine + "     - etc",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UnknownConnection(IValidate test, IReadable referenceNode, IReadable positionNode, string connectionType, string connectionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckAdvancedAttribute,
                ErrorId = ErrorIds.UnknownConnection,
                FullId = "1.11.7",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unknown connection type '{0}' in Connection '{1}'.", connectionType, connectionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "- When having only one connection for a specific type, the name needs to be of following format, where the second option can (optionally) be used to add more info about the goal of the connection (ex: XXX = Traps, XXX = Events, XXX = Alarms, etc):" + Environment.NewLine + "     - \"IP Connection\" or \"IP Connection - XXX\": for drivers that support TCP and/or UDP" + Environment.NewLine + "     - \"HTTP Connection\" or \"HTTP Connection - XXX\"" + Environment.NewLine + "     - \"SSH Connection\" or \"SSH Connection - XXX\"" + Environment.NewLine + "     - \"SNMP Connection\" or \"SNMP Connection - XXX\"" + Environment.NewLine + "     - \"Serial Connection\" or \"Serial Connection - XXX\": for drivers that only support the physical serial port (driver connection of type serial but not support TCP nor UDP)" + Environment.NewLine + "- When having more than one connection for a specific type, the name need to be of following format where XXX is used to distinguish them (ex: XXX = Redundant, XXX = Redundant 2, XXX = Backup, XXX = Traps, XXX = Events, etc):" + Environment.NewLine + "     - \"IP Connection - XXX\"" + Environment.NewLine + "     - \"HTTP Connection - XXX\"" + Environment.NewLine + "     - etc",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint EmptyAttribute = 4;
        public const uint UntrimmedAttribute = 5;
        public const uint UntrimmedValueInAttribute_Sub = 6;
        public const uint UnknownConnection = 7;
    }

    public static class CheckId
    {
        public const uint CheckAdvancedAttribute = 11;
    }
}