namespace SLDisValidator2.Tests.Protocol.QActions.QAction.CSharpSLProtocolFillArrayWithColumn
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult NonExistingTable(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolFillArrayWithColumn,
                ErrorId = ErrorIds.NonExistingTable,
                FullId = "3.11.1",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}' references a non-existing '{1}' with {2} '{3}'. QAction ID '{4}'.", "SLProtocol.FillArrayWithColumn", "table", "PID", tablePid, qactionId),
                HowToFix = "",
                ExampleCode = "protocol.FillArrayWithColumn(Parameter.TableName.tablePid, Parameter.TableName.Pid.ColumnName, keys, values);",
                Details = "SLProtocol.FillArrayWithColumn is used to update the values of a column." + Environment.NewLine + "Make sure to provide it with an ID of a table parameter that exists." + Environment.NewLine + "Using Parameter class is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingColumn(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolFillArrayWithColumn,
                ErrorId = ErrorIds.NonExistingColumn,
                FullId = "3.11.2",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}' references a non-existing '{1}' with {2} '{3}'. QAction ID '{4}'.", "SLProtocol.FillArrayWithColumn", "column", "PID", columnPid, qactionId),
                HowToFix = "",
                ExampleCode = "protocol.FillArrayWithColumn(Parameter.TableName.tablePid, Parameter.TableName.Pid.ColumnName, keys, values);",
                Details = "SLProtocol.FillArrayWithColumn is used to update the values of a column." + Environment.NewLine + "Make sure to provide it with an ID of a column parameter that exists." + Environment.NewLine + "Using Parameter class is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ParamMissingHistorySet(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolFillArrayWithColumn,
                ErrorId = ErrorIds.ParamMissingHistorySet,
                FullId = "3.11.3",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("{0} overload with '{1}' argument requires '{2}'. {3} {4} '{5}'.", "SLProtocol.FillArrayWithColumn", "DateTime? timeInfo", "Param@historySet=true", "column", "PID", columnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Every overload of the 'SLProtocol.FillArrayWithColumn' method having the 'DateTime? timeInfo' argument is meant to execute a historySet." + Environment.NewLine + "Such method requires the column to be set to have the 'Param@historySet' attribute set to 'true'.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult HardCodedTablePid(IValidate test, IReadable referenceNode, IReadable positionNode, string hardCodedTablePid, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolFillArrayWithColumn,
                ErrorId = ErrorIds.HardCodedTablePid,
                FullId = "3.11.4",
                Category = Category.QAction,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unrecommended use of magic number '{0}', use '{1}' {2} instead. QAction ID '{3}'.", hardCodedTablePid, "Parameter", "class", qactionId),
                HowToFix = "",
                ExampleCode = "protocol.FillArrayWithColumn(Parameter.TableName.tablePid, Parameter.TableName.Pid.ColumnName, keys, values);",
                Details = "SLProtocol.FillArrayWithColumn is used to update the values of a column." + Environment.NewLine + "Make sure to provide it with an ID of a table parameter that exists." + Environment.NewLine + "Using Parameter class is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult HardCodedColumnPid(IValidate test, IReadable referenceNode, IReadable positionNode, string hardCodedColumnPid, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolFillArrayWithColumn,
                ErrorId = ErrorIds.HardCodedColumnPid,
                FullId = "3.11.5",
                Category = Category.QAction,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unrecommended use of magic number '{0}', use '{1}' {2} instead. QAction ID '{3}'.", hardCodedColumnPid, "Parameter", "class", qactionId),
                HowToFix = "",
                ExampleCode = "protocol.FillArrayWithColumn(Parameter.TableName.tablePid, Parameter.TableName.Pid.ColumnName, keys, values);",
                Details = "SLProtocol.FillArrayWithColumn is used to update the values of a column." + Environment.NewLine + "Make sure to provide it with an ID of a column parameter that exists." + Environment.NewLine + "Using Parameter class is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ColumnManagedByDataMiner(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string optionLocation, string optionName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolFillArrayWithColumn,
                ErrorId = ErrorIds.ColumnManagedByDataMiner,
                FullId = "3.11.6",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported {0} on {1} '{2}' with '{3}' containing '{4}'.", "set", "column", columnPid, optionLocation, optionName),
                HowToFix = "",
                ExampleCode = "",
                Details = "Some columns are fully managed by DataMiner and therefore cannot be updated from the protocol." + Environment.NewLine + "" + Environment.NewLine + "Examples:" + Environment.NewLine + "- ColumnOption@Type=\"state\"." + Environment.NewLine + "- ColumnOption@Option containing the 'element' option.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ColumnManagedByProtocolItem(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string managedByItemKind, string managedByItemId, string optionLocation, string optionName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolFillArrayWithColumn,
                ErrorId = ErrorIds.ColumnManagedByProtocolItem,
                FullId = "3.11.7",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported {0} on {1} '{2}' managed by {3} '{4}' with '{5}' containing '{6}'.", "set", "column", columnPid, managedByItemKind, managedByItemId, optionLocation, optionName),
                HowToFix = "",
                ExampleCode = "",
                Details = "Some columns are fully managed by protocol items and therefore cannot be updated from QActions." + Environment.NewLine + "" + Environment.NewLine + "Examples:" + Environment.NewLine + "- Multi-threaded timers with following ping options: rttColumn, timestampColumn, jitterColumn, latencyColumn, packetLossRateColumn." + Environment.NewLine + "- Merge actions (result destination)." + Environment.NewLine + "- ...",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UnrecommendedSetOnSnmpParam(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolFillArrayWithColumn,
                ErrorId = ErrorIds.UnrecommendedSetOnSnmpParam,
                FullId = "3.11.8",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Uncertain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unrecommended {0} on {1} '{2}' with '{3}' containing '{4}'.", "set", "column", columnPid, "ColumnOption@type", "snmp"),
                HowToFix = "",
                ExampleCode = "",
                Details = "It is typically unrecommended to update SNMP parameters from within a protocol." + Environment.NewLine + "Indeed, SNMP parameters should typically strictly be updated via polling." + Environment.NewLine + "" + Environment.NewLine + "Exceptions can sometimes be made when we update SNMP parameters based on received traps which contains, without any possible doubt, the new value." + Environment.NewLine + "" + Environment.NewLine + "Side note: There are alternatives to poll SNMP parameters in an efficient way when, for example, a cell or column or row needs to be updated but you don't want to poll the entire table:" + Environment.NewLine + "- See various snmpSet options" + Environment.NewLine + "- See dynamicSnmpGet feature." + Environment.NewLine + "- ...",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint NonExistingTable = 1;
        public const uint NonExistingColumn = 2;
        public const uint ParamMissingHistorySet = 3;
        public const uint HardCodedTablePid = 4;
        public const uint HardCodedColumnPid = 5;
        public const uint ColumnManagedByDataMiner = 6;
        public const uint ColumnManagedByProtocolItem = 7;
        public const uint UnrecommendedSetOnSnmpParam = 8;
    }

    public static class CheckId
    {
        public const uint CSharpSLProtocolFillArrayWithColumn = 11;
    }
}