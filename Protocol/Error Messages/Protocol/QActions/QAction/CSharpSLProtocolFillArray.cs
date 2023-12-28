namespace SLDisValidator2.Tests.Protocol.QActions.QAction.CSharpSLProtocolFillArray
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    public static class Error
    {
        public static IValidationResult NonExistingParam(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolFillArray,
                ErrorId = ErrorIds.NonExistingParam,
                FullId = "3.9.1",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}' references a non-existing '{1}' with {2} '{3}'. QAction ID '{4}'.", "SLProtocol.FillArray", "table", "PID", tablePid, qactionId),
                HowToFix = "",
                ExampleCode = "protocol.FillArray(Parameter.TableName.tablePid, ..);",
                Details = "SLProtocol.FillArray is used to update a table with new values." + Environment.NewLine + "Make sure to provide it with an ID of a table parameter that exists." + Environment.NewLine + "Using Parameter class is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ParamMissingHistorySet(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolFillArray,
                ErrorId = ErrorIds.ParamMissingHistorySet,
                FullId = "3.9.2",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("{0} overload with '{1}' argument requires '{2}'. {3} {4} '{5}'.", "SLProtocol.FillArray", "DateTime? timeInfo", "Param@historySet=true", "column", "PID", columnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Every overload of the 'SLProtocol.FillArray' method having the 'DateTime? timeInfo' argument is meant to execute a historySet." + Environment.NewLine + "Such method requires the columns of the table to be set to have the 'Param@historySet' attribute set to 'true'.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult HardCodedPid(IValidate test, IReadable referenceNode, IReadable positionNode, string hardCodedTablePid, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolFillArray,
                ErrorId = ErrorIds.HardCodedPid,
                FullId = "3.9.3",
                Category = Category.QAction,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unrecommended use of magic number '{0}', use '{1}' {2} instead. QAction ID '{3}'.", hardCodedTablePid, "Parameter", "class", qactionId),
                HowToFix = "",
                ExampleCode = "protocol.FillArray(Parameter.TableName.tablePid, ..);",
                Details = "SLProtocol.FillArray is used to update a table with new values." + Environment.NewLine + "Make sure to provide it with an ID of a table parameter that exists." + Environment.NewLine + "Using Parameter class is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    public static class ErrorIds
    {
        public const uint NonExistingParam = 1;
        public const uint ParamMissingHistorySet = 2;
        public const uint HardCodedPid = 3;
    }

    public static class CheckId
    {
        public const uint CSharpSLProtocolFillArray = 9;
    }
}