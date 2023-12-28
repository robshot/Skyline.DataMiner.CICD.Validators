namespace SLDisValidator2.Tests.Protocol.Params.Param.Alarm.CheckTypeAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;

    internal static class ErrorCompare
    {
        internal static IValidationResult RemovedNormalizationAlarmType(IReadable referenceNode, IReadable positionNode, string alarmType, string paramId)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckTypeAttribute,
                ErrorId = ErrorIds.RemovedNormalizationAlarmType,
                FullId = "2.23.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Normalization with Alarm type '{0}' on Param '{1}' was removed.", alarmType, paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UpdatedNormalizationAlarmType(IReadable referenceNode, IReadable positionNode, string alarmType, string paramId, string newAlarmType)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckTypeAttribute,
                ErrorId = ErrorIds.UpdatedNormalizationAlarmType,
                FullId = "2.23.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Normalization with Alarm type '{0}' on Param '{1}' was changed into '{2}'.", alarmType, paramId, newAlarmType),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult AddedNormalizationAlarmType(IReadable referenceNode, IReadable positionNode, string normalizationType, string pid)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckTypeAttribute,
                ErrorId = ErrorIds.AddedNormalizationAlarmType,
                FullId = "2.23.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Normalization with Alarm type '{0}' on Param '{1}' was added.", normalizationType, pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint RemovedNormalizationAlarmType = 1;
        public const uint UpdatedNormalizationAlarmType = 2;
        public const uint AddedNormalizationAlarmType = 3;
    }

    public static class CheckId
    {
        public const uint CheckTypeAttribute = 23;
    }
}