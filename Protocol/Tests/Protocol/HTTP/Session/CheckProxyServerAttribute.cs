namespace SLDisValidator2.Tests.Protocol.HTTP.Session.CheckProxyServerAttribute
{
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Models.Protocol.Read.Linking;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Common.Attributes;
    using SLDisValidator2.Common.Extensions;
    using SLDisValidator2.Generic;
    using SLDisValidator2.Interfaces;

    [Test(CheckId.CheckProxyServerAttribute, Category.HTTP)]
    internal class CheckProxyServerAttribute : IValidate/*, ICodeFix, ICompare*/
    {
        public List<IValidationResult> Validate(ValidatorContext context)
        {
            List<IValidationResult> results = new List<IValidationResult>();

            foreach (IHTTPSession session in context.EachHttpSessionWithValidId())
            {
                if (session.ProxyServer == null)
                {
                    continue;
                }

                (GenericStatus valueStatus, uint _) = GenericTests.CheckBasics<uint>(session.ProxyServer.Value);

                if (valueStatus.HasFlag(GenericStatus.Empty))
                {
                    // Error message to add later
                    continue;
                }

                if (valueStatus.HasFlag(GenericStatus.Invalid))
                {
                    // Invalid value, error to add later
                    continue;
                }

                if (!context.ProtocolModel.TryGetObjectByKey<IParamsParam>(Mappings.ParamsById, session.ProxyServer.Value, out _))
                {
                    results.Add(Error.NonExistingId(this, session, session, session.ProxyServer.Value, session.Id.RawValue));
                    continue;
                }
            }

            return results;
        }

        ////public ICodeFixResult Fix(CodeFixContext context)
        ////{
        ////    CodeFixResult result = new CodeFixResult();

        ////    switch (context.Result.ErrorId)
        ////    {

        ////        default:
        ////            result.Message = String.Format("This error ({0}) isn't implemented.", context.Result.ErrorId.ToString());
        ////            break;
        ////    }

        ////    return result;
        ////}

        ////public List<IValidationResult> Compare(MajorChangeCheckContext context)
        ////{
        ////    List<IValidationResult> results = new List<IValidationResult>();

        ////    return results;
        ////}
    }
}