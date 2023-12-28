namespace SLDisValidator2.Tests.Protocol.Display.CheckPageOrderAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageOrderAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "1.22.1",
                Category = Category.Protocol,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}'.", "pageOrder"),
                HowToFix = "",
                ExampleCode = "<Display defaultPage=\"General\" pageOrder=\"General;----------;Data Page 1;Data Page 2;----------;WebInterface#http://[Polling Ip]/\" />",
                Details = "Skyline recommends the following structure for driver pages:" + Environment.NewLine + "- General" + Environment.NewLine + "- -----------" + Environment.NewLine + "- Data Page(s)" + Environment.NewLine + "- -----------" + Environment.NewLine + "- WebInterface",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageOrderAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "1.22.2",
                Category = Category.Protocol,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}'.", "pageOrder"),
                HowToFix = "",
                ExampleCode = "<Display defaultPage=\"General\" pageOrder=\"General;----------;Data Page 1;Data Page 2;----------;WebInterface#http://[Polling Ip]/\" />",
                Details = "Skyline recommends the following structure for driver pages:" + Environment.NewLine + "- General" + Environment.NewLine + "- -----------" + Environment.NewLine + "- Data Page(s)" + Environment.NewLine + "- -----------" + Environment.NewLine + "- WebInterface",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string attributeValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageOrderAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "1.22.3",
                Category = Category.Protocol,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}'. Current value '{1}'.", "pageOrder", attributeValue),
                HowToFix = "",
                ExampleCode = "<Display defaultPage=\"General\" pageOrder=\"General;----------;Data Page 1;Data Page 2;----------;WebInterface#http://[Polling Ip]/\" />",
                Details = "Skyline recommends the following structure for driver pages:" + Environment.NewLine + "- General" + Environment.NewLine + "- -----------" + Environment.NewLine + "- Data Page(s)" + Environment.NewLine + "- -----------" + Environment.NewLine + "- WebInterface",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UnsupportedPage(IValidate test, IReadable referenceNode, IReadable positionNode, string pageName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageOrderAttribute,
                ErrorId = ErrorIds.UnsupportedPage,
                FullId = "1.22.4",
                Category = Category.Protocol,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported popup page '{0}' in 'Protocol/Display@pageOrder' attribute.", pageName),
                HowToFix = "",
                ExampleCode = "<Display defaultPage=\"General\" pageOrder=\"General;----------;Data Page 1;Data Page 2;----------;WebInterface#http://[Polling Ip]/\" />",
                Details = "Skyline recommends the following structure for driver pages:" + Environment.NewLine + "- General" + Environment.NewLine + "- -----------" + Environment.NewLine + "- Data Page(s)" + Environment.NewLine + "- -----------" + Environment.NewLine + "- WebInterface",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingPage(IValidate test, IReadable referenceNode, IReadable positionNode, string pageName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageOrderAttribute,
                ErrorId = ErrorIds.MissingPage,
                FullId = "1.22.5",
                Category = Category.Protocol,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing page '{0}' on 'Protocol/Display@pageOrder' attribute.", pageName),
                HowToFix = "",
                ExampleCode = "<Display defaultPage=\"General\" pageOrder=\"General;----------;Data Page 1;Data Page 2;----------;WebInterface#http://[Polling Ip]/\" />",
                Details = "Skyline recommends the following structure for driver pages:" + Environment.NewLine + "- General" + Environment.NewLine + "- -----------" + Environment.NewLine + "- Data Page(s)" + Environment.NewLine + "- -----------" + Environment.NewLine + "- WebInterface",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingWebPage(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageOrderAttribute,
                ErrorId = ErrorIds.MissingWebPage,
                FullId = "1.22.6",
                Category = Category.Protocol,
                Severity = Severity.Warning,
                Certainty = Certainty.Uncertain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "Missing WebInterface page.",
                HowToFix = "Make sure the webInterface page(s) are defined as last and preceded by a separator page.",
                ExampleCode = "<Display defaultPage=\"General\" pageOrder=\"General;----------;Data Page 1;Data Page 2;----------;WebInterface#http://[Polling Ip]/\" />",
                Details = "Skyline recommends the following structure for driver pages:" + Environment.NewLine + "- General" + Environment.NewLine + "- -----------" + Environment.NewLine + "- Data Page(s)" + Environment.NewLine + "- -----------" + Environment.NewLine + "- WebInterface",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult WrongWebPagePosition(IValidate test, IReadable referenceNode, IReadable positionNode, string pageName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageOrderAttribute,
                ErrorId = ErrorIds.WrongWebPagePosition,
                FullId = "1.22.7",
                Category = Category.Protocol,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Web page '{0}' should be defined after all regular pages and the first web page should be preceded by a separator.", pageName),
                HowToFix = "Make sure the webInterface page(s) are defined as last and preceded by a separator page.",
                ExampleCode = "<Display defaultPage=\"General\" pageOrder=\"General;----------;Data Page 1;Data Page 2;----------;WebInterface#http://[Polling Ip]/\" />",
                Details = "Skyline recommends the following structure for driver pages:" + Environment.NewLine + "- General" + Environment.NewLine + "- -----------" + Environment.NewLine + "- Data Page(s)" + Environment.NewLine + "- -----------" + Environment.NewLine + "- WebInterface",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UnexistingPage(IValidate test, IReadable referenceNode, IReadable positionNode, string pageName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageOrderAttribute,
                ErrorId = ErrorIds.UnexistingPage,
                FullId = "1.22.8",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("The specified page '{0}' does not exist.", pageName),
                HowToFix = "",
                ExampleCode = "<Display defaultPage=\"General\" pageOrder=\"General;----------;Data Page 1;Data Page 2;----------;WebInterface#http://[Polling Ip]/\" />",
                Details = "Skyline recommends the following structure for driver pages:" + Environment.NewLine + "- General" + Environment.NewLine + "- -----------" + Environment.NewLine + "- Data Page(s)" + Environment.NewLine + "- -----------" + Environment.NewLine + "- WebInterface",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult DuplicateEntries(IValidate test, IReadable referenceNode, IReadable positionNode, string pageName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageOrderAttribute,
                ErrorId = ErrorIds.DuplicateEntries,
                FullId = "1.22.9",
                Category = Category.Protocol,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Page '{0}' has been added more than once to the pageOrder attribute.", pageName),
                HowToFix = "",
                ExampleCode = "<Display defaultPage=\"General\" pageOrder=\"General;----------;Data Page 1;Data Page 2;----------;WebInterface#http://[Polling Ip]/\" />",
                Details = "Skyline recommends the following structure for driver pages:" + Environment.NewLine + "- General" + Environment.NewLine + "- -----------" + Environment.NewLine + "- Data Page(s)" + Environment.NewLine + "- -----------" + Environment.NewLine + "- WebInterface",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingPage_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string pageName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageOrderAttribute,
                ErrorId = ErrorIds.MissingPage_Sub,
                FullId = "1.22.10",
                Category = Category.Protocol,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Param with ID '{0}' is positioned on page '{1}' which is not ordered via 'Protocol/Display@pageOrder' attribute.", pid, pageName),
                HowToFix = "",
                ExampleCode = "<Display defaultPage=\"General\" pageOrder=\"General;----------;Data Page 1;Data Page 2;----------;WebInterface#http://[Polling Ip]/\" />",
                Details = "Skyline recommends the following structure for driver pages:" + Environment.NewLine + "- General" + Environment.NewLine + "- -----------" + Environment.NewLine + "- Data Page(s)" + Environment.NewLine + "- -----------" + Environment.NewLine + "- WebInterface",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageOrderAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "1.22.11",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}@{1}' references a non-existing '{2}' with {3} '{4}'.", "Protocol/Display", "pageOrder", "Param", "ID", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Via the 'Protocol/Display@pageOrder' attribute, it's possible to add pages which will link to an internet page via its URL." + Environment.NewLine + "Such URL can be made dynamic by refering to parameter IDs." + Environment.NewLine + "Such referenced parameters then require the RTDisplay tag to be set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ReferencedParamRTDisplayExpected(IValidate test, IReadable referenceNode, IReadable positionNode, string referencedPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPageOrderAttribute,
                ErrorId = ErrorIds.ReferencedParamRTDisplayExpected,
                FullId = "1.22.12",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on Param '{0}' referenced by the 'Protocol/Display@pageOrder' attribute.", referencedPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Via the 'Protocol/Display@pageOrder' attribute, it's possible to add pages which will link to an internet page via its URL." + Environment.NewLine + "Such URL can be made dynamic by refering to parameter IDs." + Environment.NewLine + "Such referenced parameters then require the RTDisplay tag to be set to true.",
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
        public const uint UnsupportedPage = 4;
        public const uint MissingPage = 5;
        public const uint MissingWebPage = 6;
        public const uint WrongWebPagePosition = 7;
        public const uint UnexistingPage = 8;
        public const uint DuplicateEntries = 9;
        public const uint MissingPage_Sub = 10;
        public const uint NonExistingId = 11;
        public const uint ReferencedParamRTDisplayExpected = 12;
    }

    public static class CheckId
    {
        public const uint CheckPageOrderAttribute = 22;
    }
}