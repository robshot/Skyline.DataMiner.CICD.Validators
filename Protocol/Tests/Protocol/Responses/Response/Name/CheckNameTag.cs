namespace SLDisValidator2.Tests.Protocol.Responses.Response.Name.CheckNameTag
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Common.Attributes;
    using SLDisValidator2.Common.Extensions;
    using SLDisValidator2.Generic;
    using SLDisValidator2.Interfaces;

    [Test(CheckId.CheckNameTag, Category.Response)]
    public class CheckNameTag : IValidate/*, ICodeFix, ICompare*/
    {
        public List<IValidationResult> Validate(ValidatorContext context)
        {
            List<IValidationResult> results = new List<IValidationResult>();

            var responses = context.EachResponseWithValidId().ToList();

            foreach (var response in responses)
            {
                // TODO: missing, empty, invalid, untrimmed, etc...
            }

            var resultsForDuplicateNames = GenericTests.CheckDuplicates(
                items: responses,
                getDuplicationIdentifier: response => response.Name?.Value,
                getId: response => response.Id?.RawValue,
                generateSubResult: x => Error.DuplicatedValue(this, x.item, x.item, x.duplicateValue, x.id),
                generateSummaryResult: x => Error.DuplicatedValue(this, null, null, x.duplicateValue, String.Join(", ", x.ids)).WithSubResults(x.subResults)
                );

            results.AddRange(resultsForDuplicateNames);

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