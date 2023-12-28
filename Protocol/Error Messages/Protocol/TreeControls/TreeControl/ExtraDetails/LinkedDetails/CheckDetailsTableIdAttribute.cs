namespace SLDisValidator2.Tests.Protocol.TreeControls.TreeControl.ExtraDetails.LinkedDetails.CheckDetailsTableIdAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDetailsTableIdAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "18.6.1",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' in {1} '{2}'.", "LinkedDetails@detailsTableId", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "LinkedDetails@detailsTableId attribute should contain one of the following:" + Environment.NewLine + "- tablePid: Extra info from that table will then be added to the TreeControl." + Environment.NewLine + "- fkColumnPid: Extra info from the table to which the FK Column belongs will then be added to the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "In both cases, the table containing extra details should have its RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDetailsTableIdAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "18.6.2",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "LinkedDetails@detailsTableId", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "LinkedDetails@detailsTableId attribute should contain one of the following:" + Environment.NewLine + "- tablePid: Extra info from that table will then be added to the TreeControl." + Environment.NewLine + "- fkColumnPid: Extra info from the table to which the FK Column belongs will then be added to the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "In both cases, the table containing extra details should have its RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDetailsTableIdAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "18.6.3",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "LinkedDetails@detailsTableId", "TreeControl", treeControlPid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "LinkedDetails@detailsTableId attribute should contain one of the following:" + Environment.NewLine + "- tablePid: Extra info from that table will then be added to the TreeControl." + Environment.NewLine + "- fkColumnPid: Extra info from the table to which the FK Column belongs will then be added to the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "In both cases, the table containing extra details should have its RTDisplay tag set to true.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string attributeValue, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDetailsTableIdAttribute,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "18.6.4",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. {2} {4} '{3}'.", "LinkedDetails@detailsTableId", attributeValue, "TreeControl", treeControlPid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "LinkedDetails@detailsTableId attribute should contain one of the following:" + Environment.NewLine + "- tablePid: Extra info from that table will then be added to the TreeControl." + Environment.NewLine + "- fkColumnPid: Extra info from the table to which the FK Column belongs will then be added to the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "In both cases, the table containing extra details should have its RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDetailsTableIdAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "18.6.5",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}@{1}' references a non-existing '{2}' with {3} '{4}'.", "ExtraDetails/LinkedDetails", "detailsTableId", "Table", "PID", tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "LinkedDetails@detailsTableId attribute should contain one of the following:" + Environment.NewLine + "- tablePid: Extra info from that table will then be added to the TreeControl." + Environment.NewLine + "- fkColumnPid: Extra info from the table to which the FK Column belongs will then be added to the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "In both cases, the table containing extra details should have its RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ReferencedTableExpectingRTDisplay(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDetailsTableIdAttribute,
                ErrorId = ErrorIds.ReferencedTableExpectingRTDisplay,
                FullId = "18.6.6",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on TreeControl/ExtraDetails table. Table PID '{0}'.", tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "LinkedDetails@detailsTableId attribute should contain one of the following:" + Environment.NewLine + "- tablePid: Extra info from that table will then be added to the TreeControl." + Environment.NewLine + "- fkColumnPid: Extra info from the table to which the FK Column belongs will then be added to the TreeControl." + Environment.NewLine + "" + Environment.NewLine + "In both cases, the table containing extra details should have its RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MissingAttribute = 1;
        public const uint EmptyAttribute = 2;
        public const uint UntrimmedAttribute = 3;
        public const uint InvalidValue = 4;
        public const uint NonExistingId = 5;
        public const uint ReferencedTableExpectingRTDisplay = 6;
    }

    public static class CheckId
    {
        public const uint CheckDetailsTableIdAttribute = 6;
    }
}