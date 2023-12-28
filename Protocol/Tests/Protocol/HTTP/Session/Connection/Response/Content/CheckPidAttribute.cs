namespace SLDisValidator2.Tests.Protocol.HTTP.Session.Connection.Response.Content.CheckPidAttribute
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

    [Test(CheckId.CheckPidAttribute, Category.HTTP)]
    internal class CheckPidAttribute : IValidate/*, ICodeFix, ICompare*/
    {
        public List<IValidationResult> Validate(ValidatorContext context)
        {
            List<IValidationResult> results = new List<IValidationResult>();

            foreach (IHTTPSession session in context.EachHttpSessionWithValidId())
            {
                foreach (IHTTPSessionConnection connection in context.EachHttpConnectionWithValidId(session))
                {
                    if (connection.Response?.Content == null)
                    {
                        continue;
                    }

                    (GenericStatus status, string rawValue, uint? _) = GenericTests.CheckBasics(connection.Response.Content.Pid, isRequired: true);

                    if (status.HasFlag(GenericStatus.Missing))
                    {
                        continue;
                    }

                    if (status.HasFlag(GenericStatus.Empty))
                    {
                        results.Add(Error.EmptyAttribute(this, connection.Response.Content, connection.Response.Content, session.Id.RawValue, connection.Id.RawValue));
                        continue;
                    }

                    if (status.HasFlag(GenericStatus.Invalid))
                    {
                        results.Add(Error.InvalidAttribute(this, connection.Response.Content, connection.Response.Content, rawValue, session.Id.RawValue, connection.Id.RawValue));
                        continue;
                    }

                    if (!context.ProtocolModel.TryGetObjectByKey<IParamsParam>(Mappings.ParamsById, rawValue, out _))
                    {
                        results.Add(Error.NonExistingId(this, connection.Response.Content, connection.Response.Content, rawValue, session.Id.RawValue, connection.Id.RawValue));
                        continue;
                    }
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