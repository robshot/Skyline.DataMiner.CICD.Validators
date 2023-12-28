namespace SLDisValidator2.Tests.Protocol.ExportRules.ExportRule.CheckWhereAttributeAttribute
{
    using System.Collections.Generic;
    using System.Linq;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Common.Attributes;
    using SLDisValidator2.Generic;
    using SLDisValidator2.Interfaces;

    [Test(CheckId.CheckWhereAttributeAttribute, Category.ExportRule)]
    public class CheckWhereAttributeAttribute : IValidate/*, ICodeFix, ICompare*/
    {
        public List<IValidationResult> Validate(ValidatorContext context)
        {
            List<IValidationResult> results = new List<IValidationResult>();

            var exportRules = context?.ProtocolModel?.Protocol?.ExportRules;
            if (exportRules == null || !exportRules.Any())
            {
                return results;
            }
            
            foreach (IExportRulesExportRule exportRule in exportRules)
            {
                (GenericStatus status, string rawValue, _) = GenericTests.CheckBasics(exportRule.WhereAttribute, isRequired: false);

                if (status.HasFlag(GenericStatus.Empty))
                {
                    results.Add(Error.EmptyAttribute(this, exportRule, exportRule));
                    continue;
                }

                if (status.HasFlag(GenericStatus.Untrimmed))
                {
                    results.Add(Error.UntrimmedAttribute(this, exportRule, exportRule.WhereAttribute, rawValue));
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
        ////            result.Message = $"This error ({context.Result.ErrorId}) isn't implemented.";
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