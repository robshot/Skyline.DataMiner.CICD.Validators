namespace SLDisValidator2.Tests.Protocol.QActions.QAction.CSharpNotifyProtocolNtFillArrayWithColumn
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult UnexpectedImplementation(IValidate test, IReadable referenceNode, IReadable positionNode, string arguments, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpNotifyProtocolNtFillArrayWithColumn,
                ErrorId = ErrorIds.UnexpectedImplementation,
                FullId = "3.34.1",
                Category = Category.QAction,
                Severity = Severity.BubbleUp,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}' with arguments '{1}' is not implemented as expected. QAction ID '{2}'.", "NotifyProtocol(220/*NT_FILL_ARRAY_WITH_COLUMN*/, ...)", arguments, qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "NotifyProtocol(220/*NT_FILL_ARRAY_WITH_COLUMN*/, ...) is used to update the values of column(s)." + Environment.NewLine + "See DDL for more information." + Environment.NewLine + "Also note that using Parameter class is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingTable(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpNotifyProtocolNtFillArrayWithColumn,
                ErrorId = ErrorIds.NonExistingTable,
                FullId = "3.34.2",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}' references a non-existing '{1}' with {2} '{3}'. QAction ID '{4}'.", "NotifyProtocol(220/*NT_FILL_ARRAY_WITH_COLUMN*/, ...)", "table", "PID", tablePid, qactionId),
                HowToFix = "",
                ExampleCode = "object[] columnPids = new object[]" + Environment.NewLine + "{" + Environment.NewLine + " Parameter.TableName.tablePid," + Environment.NewLine + " Parameter.TableName.Pid.ColumnName" + Environment.NewLine + "};" + Environment.NewLine + "object[] columnValues = new object[]" + Environment.NewLine + "{" + Environment.NewLine + " keys," + Environment.NewLine + " values" + Environment.NewLine + "};" + Environment.NewLine + "protocol.NotifyProtocol((int)NotifyType.NT_FILL_ARRAY_WITH_COLUMN, columnPids, columnValues);",
                Details = "NotifyProtocol(220/*NT_FILL_ARRAY_WITH_COLUMN*/, ...) is used to update the values of column(s)." + Environment.NewLine + "Make sure to provide it with the ID of a table parameter that exists." + Environment.NewLine + "Using Parameter class is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingColumn(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpNotifyProtocolNtFillArrayWithColumn,
                ErrorId = ErrorIds.NonExistingColumn,
                FullId = "3.34.3",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}' references a non-existing '{1}' with {2} '{3}'. QAction ID '{4}'.", "NotifyProtocol(220/*NT_FILL_ARRAY_WITH_COLUMN*/, ...)", "column", "PID", columnPid, qactionId),
                HowToFix = "",
                ExampleCode = "object[] columnPids = new object[]" + Environment.NewLine + "{" + Environment.NewLine + " Parameter.TableName.tablePid," + Environment.NewLine + " Parameter.TableName.Pid.ColumnName" + Environment.NewLine + "};" + Environment.NewLine + "object[] columnValues = new object[]" + Environment.NewLine + "{" + Environment.NewLine + " keys," + Environment.NewLine + " values" + Environment.NewLine + "};" + Environment.NewLine + "protocol.NotifyProtocol((int)NotifyType.NT_FILL_ARRAY_WITH_COLUMN, columnPids, columnValues);",
                Details = "NotifyProtocol(220/*NT_FILL_ARRAY_WITH_COLUMN*/, ...) is used to update the values of column(s)." + Environment.NewLine + "Make sure to provide it with column parameter IDs that exists excluding the index (Primary Key) column." + Environment.NewLine + "Using Parameter class is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ColumnMissingHistorySet(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpNotifyProtocolNtFillArrayWithColumn,
                ErrorId = ErrorIds.ColumnMissingHistorySet,
                FullId = "3.34.4",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("NotifyProtocol(220/*NT_FILL_ARRAY_WITH_COLUMN*/, ...) method with one or more DateTime(s) given to it requires 'Param@historySet=true' on column with PID '{0}'.", columnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "NotifyProtocol(220/*NT_FILL_ARRAY_WITH_COLUMN*/, ...) with DateTime given on table or cell level requires related column parameter(s) to be set to have the 'Param@historySet' attribute set to 'true'.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult HardCodedTablePid(IValidate test, IReadable referenceNode, IReadable positionNode, string hardCodedTablePid, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpNotifyProtocolNtFillArrayWithColumn,
                ErrorId = ErrorIds.HardCodedTablePid,
                FullId = "3.34.5",
                Category = Category.QAction,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unrecommended use of magic number '{0}', use '{1}' {2} instead. QAction ID '{3}'.", hardCodedTablePid, "Parameter", "class", qactionId),
                HowToFix = "",
                ExampleCode = "object[] columnPids = new object[]" + Environment.NewLine + "{" + Environment.NewLine + " Parameter.TableName.tablePid," + Environment.NewLine + " Parameter.TableName.Pid.ColumnName" + Environment.NewLine + "};" + Environment.NewLine + "object[] columnValues = new object[]" + Environment.NewLine + "{" + Environment.NewLine + " keys," + Environment.NewLine + " values" + Environment.NewLine + "};" + Environment.NewLine + "protocol.NotifyProtocol((int)NotifyType.NT_FILL_ARRAY_WITH_COLUMN, columnPids, columnValues);",
                Details = "NotifyProtocol(220/*NT_FILL_ARRAY_WITH_COLUMN*/, ...) is used to update the values of column(s)." + Environment.NewLine + "Make sure to provide it with an ID of a table parameter that exists." + Environment.NewLine + "Using Parameter class is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult HardCodedColumnPid(IValidate test, IReadable referenceNode, IReadable positionNode, string hardCodedColumnPid, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpNotifyProtocolNtFillArrayWithColumn,
                ErrorId = ErrorIds.HardCodedColumnPid,
                FullId = "3.34.6",
                Category = Category.QAction,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unrecommended use of magic number '{0}', use '{1}' {2} instead. QAction ID '{3}'.", hardCodedColumnPid, "Parameter", "class", qactionId),
                HowToFix = "",
                ExampleCode = "object[] columnPids = new object[]" + Environment.NewLine + "{" + Environment.NewLine + " Parameter.TableName.tablePid," + Environment.NewLine + " Parameter.TableName.Pid.ColumnName" + Environment.NewLine + "};" + Environment.NewLine + "object[] columnValues = new object[]" + Environment.NewLine + "{" + Environment.NewLine + " keys," + Environment.NewLine + " values" + Environment.NewLine + "};" + Environment.NewLine + "protocol.NotifyProtocol((int)NotifyType.NT_FILL_ARRAY_WITH_COLUMN, columnPids, columnValues);",
                Details = "NotifyProtocol(220/*NT_FILL_ARRAY_WITH_COLUMN*/, ...) is used to update the values of column(s)." + Environment.NewLine + "Make sure to provide it with column parameter IDs that exists excluding the index (Primary Key) column." + Environment.NewLine + "Using Parameter class is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ColumnManagedByDataMiner(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string optionLocation, string optionName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpNotifyProtocolNtFillArrayWithColumn,
                ErrorId = ErrorIds.ColumnManagedByDataMiner,
                FullId = "3.34.7",
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

        public static IValidationResult ColumnManagedByProtocolItem(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string managedByItemKind, string managedByItemId, string optionLocation, string optionName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpNotifyProtocolNtFillArrayWithColumn,
                ErrorId = ErrorIds.ColumnManagedByProtocolItem,
                FullId = "3.34.8",
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

        public static IValidationResult UnrecommendedSetOnSnmpParam(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpNotifyProtocolNtFillArrayWithColumn,
                ErrorId = ErrorIds.UnrecommendedSetOnSnmpParam,
                FullId = "3.34.9",
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

    public static class ErrorIds
    {
        public const uint UnexpectedImplementation = 1;
        public const uint NonExistingTable = 2;
        public const uint NonExistingColumn = 3;
        public const uint ColumnMissingHistorySet = 4;
        public const uint HardCodedTablePid = 5;
        public const uint HardCodedColumnPid = 6;
        public const uint ColumnManagedByDataMiner = 7;
        public const uint ColumnManagedByProtocolItem = 8;
        public const uint UnrecommendedSetOnSnmpParam = 9;
    }

    public static class CheckId
    {
        public const uint CSharpNotifyProtocolNtFillArrayWithColumn = 34;
    }
}