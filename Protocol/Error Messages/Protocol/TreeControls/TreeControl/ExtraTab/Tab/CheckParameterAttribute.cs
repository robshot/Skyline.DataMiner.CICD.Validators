namespace SLDisValidator2.Tests.Protocol.TreeControls.TreeControl.ExtraTab.Tab.CheckParameterAttribute
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
                CheckId = CheckId.CheckParameterAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "18.8.1",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' in {1} '{2}'.", "Tab@parameter", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Tab@parameter' attribute has different meaning depending on the 'Tab@type' attribute value." + Environment.NewLine + "    - parameters: a comma-separated list of PIDs is expeted. Those should refer to columns of the main table for this TreeControl level or params added to its main section via ExtraDetail tags." + Environment.NewLine + "    - relation: The PID of a column containing a foreignKey to the main table for this TreeControl level." + Environment.NewLine + "    - summary: The PID of a table is a 'grand-chidren' of the main table for this TreeControl level." + Environment.NewLine + "    - default: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "    - chart: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "    - web: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "" + Environment.NewLine + "Note that in any case, parameters referenced are expected to have the RTDisplay tag set to true.",
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
                CheckId = CheckId.CheckParameterAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "18.8.2",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "Tab@parameter", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Tab@parameter' attribute has different meaning depending on the 'Tab@type' attribute value." + Environment.NewLine + "    - parameters: a comma-separated list of PIDs is expeted. Those should refer to columns of the main table for this TreeControl level or params added to its main section via ExtraDetail tags." + Environment.NewLine + "    - relation: The PID of a column containing a foreignKey to the main table for this TreeControl level." + Environment.NewLine + "    - summary: The PID of a table is a 'grand-chidren' of the main table for this TreeControl level." + Environment.NewLine + "    - default: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "    - chart: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "    - web: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "" + Environment.NewLine + "Note that in any case, parameters referenced are expected to have the RTDisplay tag set to true.",
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
                CheckId = CheckId.CheckParameterAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "18.8.3",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "Tab@parameter", "TreeControl", treeControlPid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Tab@parameter' attribute has different meaning depending on the 'Tab@type' attribute value." + Environment.NewLine + "    - parameters: a comma-separated list of PIDs is expeted. Those should refer to columns of the main table for this TreeControl level or params added to its main section via ExtraDetail tags." + Environment.NewLine + "    - relation: The PID of a column containing a foreignKey to the main table for this TreeControl level." + Environment.NewLine + "    - summary: The PID of a table is a 'grand-chidren' of the main table for this TreeControl level." + Environment.NewLine + "    - default: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "    - chart: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "    - web: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "" + Environment.NewLine + "Note that in any case, parameters referenced are expected to have the RTDisplay tag set to true.",
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
                CheckId = CheckId.CheckParameterAttribute,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "18.8.4",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. {2} {4} '{3}'.", "Tab@parameter", attributeValue, "TreeControl", treeControlPid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Tab@parameter' attribute has different meaning depending on the 'Tab@type' attribute value." + Environment.NewLine + "    - parameters: a comma-separated list of PIDs is expeted. Those should refer to columns of the main table for this TreeControl level or params added to its main section via ExtraDetail tags." + Environment.NewLine + "    - relation: The PID of a column containing a foreignKey to the main table for this TreeControl level." + Environment.NewLine + "    - summary: The PID of a table is a 'grand-chidren' of the main table for this TreeControl level." + Environment.NewLine + "    - default: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "    - chart: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "    - web: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "" + Environment.NewLine + "Note that in any case, parameters referenced are expected to have the RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParameterAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "18.8.5",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}@{1}' references a non-existing '{2}' with {3} '{4}'.", "ExtraTabs/Tab", "parameter", "Column", "PID", columnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Tab@parameter' attribute has different meaning depending on the 'Tab@type' attribute value." + Environment.NewLine + "    - parameters: a comma-separated list of PIDs is expeted. Those should refer to columns of the main table for this TreeControl level or params added to its main section via ExtraDetail tags." + Environment.NewLine + "    - relation: The PID of a column containing a foreignKey to the main table for this TreeControl level." + Environment.NewLine + "    - summary: The PID of a table is a 'grand-chidren' of the main table for this TreeControl level." + Environment.NewLine + "    - default: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "    - chart: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "    - web: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "" + Environment.NewLine + "Note that in any case, parameters referenced are expected to have the RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ReferencedParamExpectingRTDisplay(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParameterAttribute,
                ErrorId = ErrorIds.ReferencedParamExpectingRTDisplay,
                FullId = "18.8.6",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on 'TreeControl/ExtraTabs/Tab@parameters' Param. Param ID '{0}'.", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Tab@parameter' attribute has different meaning depending on the 'Tab@type' attribute value." + Environment.NewLine + "    - parameters: a comma-separated list of PIDs is expeted. Those should refer to columns of the main table for this TreeControl level or params added to its main section via ExtraDetail tags." + Environment.NewLine + "    - relation: The PID of a column containing a foreignKey to the main table for this TreeControl level." + Environment.NewLine + "    - summary: The PID of a table is a 'grand-chidren' of the main table for this TreeControl level." + Environment.NewLine + "    - default: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "    - chart: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "    - web: No 'Tab@parameter' attribute expected in this case." + Environment.NewLine + "" + Environment.NewLine + "Note that in any case, parameters referenced are expected to have the RTDisplay tag set to true.",
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
        public const uint ReferencedParamExpectingRTDisplay = 6;
    }

    public static class CheckId
    {
        public const uint CheckParameterAttribute = 8;
    }
}