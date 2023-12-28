namespace SLDisValidator2.Tests.Protocol.Params.Param.Measurement.Discreets.Discreet.CheckDiscreetTag
{
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Common.Attributes;
    using SLDisValidator2.Common.Extensions;
    using SLDisValidator2.Interfaces;

    [Test(CheckId.CheckDiscreetTag, Category.Param)]
    public class CheckDiscreetTag : IValidate/*, ICodeFix, ICompare*/
    {
        public List<IValidationResult> Validate(ValidatorContext context)
        {
            List<IValidationResult> results = new List<IValidationResult>();

            foreach (IParamsParam param in context.EachParamWithValidId())
            {
                var discreets = param.Measurement?.Discreets;
                if (discreets == null)
                {
                    // No need to check if there isn't a Discreets Tag.
                    continue;
                }

                if (discreets.Count == 0 && discreets.DependencyId == null)
                {
                    // No Discreet found, and the dependencyId attribute is also absent.
                    results.Add(Error.MissingTag(this, param, discreets, param.Id.RawValue));
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