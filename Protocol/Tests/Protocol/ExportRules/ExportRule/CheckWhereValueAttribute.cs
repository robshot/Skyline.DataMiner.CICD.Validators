namespace SLDisValidator2.Tests.Protocol.ExportRules.ExportRule.CheckWhereValueAttribute
{
    using System.Collections.Generic;
    using System.Linq;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;

    using SLDisValidator2.Common;
    using SLDisValidator2.Common.Attributes;
    using SLDisValidator2.Generic;
    using SLDisValidator2.Interfaces;

    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    [Test(CheckId.CheckWhereValueAttribute, Category.ExportRule)]
    internal class CheckWhereValueAttribute : IValidate/*, ICodeFix, ICompare*/
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
                // Both of these attributes don't mean anything without the whereValue.
                bool isRequired = exportRule.WhereTag != null || exportRule.WhereAttribute != null;

                (GenericStatus status, _, _) = GenericTests.CheckBasics(exportRule.WhereValue, isRequired);

                if (status.HasFlag(GenericStatus.Missing))
                {
                    results.Add(Error.MissingAttribute(this, exportRule, exportRule));
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