namespace SLDisValidator2.Tests.Protocol.Actions.Action.Type.CheckTypeTag
{
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Common.Attributes;
    using SLDisValidator2.Common.Extensions;
    using SLDisValidator2.Generic;
    using SLDisValidator2.Interfaces;

    [Test(CheckId.CheckTypeTag, Category.Action)]
    public class CheckTypeTag : IValidate, ICodeFix/*, ICompare*/
    {
        public List<IValidationResult> Validate(ValidatorContext context)
        {
            List<IValidationResult> results = new List<IValidationResult>();

            foreach (var action in context.EachActionWithValidId())
            {
                var actionType = action.Type;
                (GenericStatus status, _, _) = GenericTests.CheckBasics(actionType, isRequired: true);

                // Missing
                if (status.HasFlag(GenericStatus.Missing))
                {
                    results.Add(Error.MissingTag(this, action, action, action.Id.RawValue));
                    continue;
                }

                // Empty
                if (status.HasFlag(GenericStatus.Empty))
                {
                    results.Add(Error.EmptyTag(this, action, actionType, action.Id.RawValue));
                    continue;
                }

                // Invalid
                if (status.HasFlag(GenericStatus.Invalid))
                {
                    results.Add(Error.InvalidValue(this, action, actionType, actionType.RawValue, action.Id.RawValue));
                    continue;
                }

                // Untrimmed
                if (status.HasFlag(GenericStatus.Untrimmed))
                {
                    results.Add(Error.UntrimmedTag(this, action, actionType, action.Id.RawValue, actionType.RawValue));
                    continue;
                }
            }

            return results;
        }

        public ICodeFixResult Fix(CodeFixContext context)
        {
            CodeFixResult result = new CodeFixResult();

            if (!(context.Result.ReferenceNode is IActionsAction readAction))
            {
                result.Message = "ReferenceNode not of type IActionsAction.";
                return result;
            }

            var editAction = context.Protocol?.Actions?.Get(readAction);
            if (editAction == null)
            {
                result.Message = "editAction is null.";
                return result;
            }

            switch (context.Result.ErrorId)
            {
                case ErrorIds.UntrimmedTag:

                    editAction.Type.Value = readAction.Type.Value;
                    result.Success = true;

                    break;
                default:
                    result.Message = $"This error ({context.Result.ErrorId}) isn't implemented.";
                    break;
            }

            return result;
        }

        ////public List<IValidationResult> Compare(MajorChangeCheckContext context)
        ////{
        ////    List<IValidationResult> results = new List<IValidationResult>();

        ////    return results;
        ////}
    }
}