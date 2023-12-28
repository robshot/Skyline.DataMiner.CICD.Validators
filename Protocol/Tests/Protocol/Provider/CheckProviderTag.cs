namespace SLDisValidator2.Tests.Protocol.Provider.CheckProviderTag
{
    using System;
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Common.Attributes;
    using SLDisValidator2.Generic;
    using SLDisValidator2.Interfaces;

    [Test(CheckId.CheckProviderTag, Category.Protocol)]
    public class CheckProviderTag : IValidate, ICodeFix
    {
        public List<IValidationResult> Validate(ValidatorContext context)
        {
            List<IValidationResult> results = new List<IValidationResult>();

            var model = context.ProtocolModel;

            if (model.Protocol == null)
            {
                return results;
            }

            var provider = model.Protocol.Provider;

            (GenericStatus status, string rawValue, string value) = GenericTests.CheckBasics(provider, true);

            if (status.HasFlag(GenericStatus.Missing))
            {
                results.Add(Error.MissingTag(this, model.Protocol, model.Protocol));
                return results;
            }

            if (status.HasFlag(GenericStatus.Empty))
            {
                results.Add(Error.EmptyTag(this, provider, provider));
                return results;
            }

            SkylineUserChecks(provider);

            return results;

            void SkylineUserChecks(IValueTag<string> valueTag)
            {
                if (String.IsNullOrEmpty(context.ValidatorSettings.ExpectedProvider))
                {
                    return;
                }

                if (!String.Equals(valueTag.Value, context.ValidatorSettings.ExpectedProvider))
                {
                    string[] possibleProviders =
                    {
                        context.ValidatorSettings.ExpectedProvider,
                        // Fill with Provider from Settings page? (extra feature)
                    };

                    results.Add(Error.InvalidTag(this, valueTag, valueTag, valueTag.Value, String.Join(", ", possibleProviders)));
                }
            }
        }

        public ICodeFixResult Fix(CodeFixContext context)
        {
            CodeFixResult result = new CodeFixResult();

            var editNode = context.Protocol.GetOrCreateProvider();

            switch (context.Result.ErrorId)
            {
                case ErrorIds.MissingTag:
                    editNode.Value = "Skyline Communications";
                    result.Success = true;
                    break;

                default:
                    result.Message = $"This error ({context.Result.ErrorId}) isn't implemented.";
                    break;
            }

            return result;
        }
    }
}