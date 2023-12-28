namespace SLDisValidator2.Tests.Protocol.Triggers.Trigger.Condition.CheckConditionTag
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Common.Attributes;
    using SLDisValidator2.Common.Extensions;
    using SLDisValidator2.Helpers.Conditions;
    using SLDisValidator2.Interfaces;

    [Test(CheckId.CheckConditionTag, Category.Trigger)]
    internal class CheckConditionTag : IValidate
    {
        public List<IValidationResult> Validate(ValidatorContext context)
        {
            List<IValidationResult> results = new List<IValidationResult>();

            foreach (ITriggersTrigger trigger in context.EachTriggerWithValidId())
            {
                if (trigger.Condition == null)
                {
                    continue;
                }

                if (String.IsNullOrWhiteSpace(trigger.Condition.Value))
                {
                    results.Add(Error.InvalidCondition(this, trigger, trigger, trigger.Condition.RawValue, "Condition is empty.", trigger.Id.RawValue));
                    continue;
                }

                var conditionValidationResults = new List<IValidationResult>();

                var addInvalidConditionError = new Action<string>(message => conditionValidationResults.Add(Error.InvalidCondition(this, trigger, trigger.Condition, trigger.Condition.Value, message, trigger.Id.RawValue)));
                var addInvalidParamIdError = new Action<string>(paramId => conditionValidationResults.Add(Error.NonExistingId(this, trigger, trigger.Condition, paramId, trigger.Id.RawValue)));
                var addConditionCanBeSimpliefiedWarning = new Action(() => { if (!conditionValidationResults.Any(r => r.FullId == "5.5.3")) { conditionValidationResults.Add(Error.ConditionCanBeSimplified(this, trigger, trigger.Condition, trigger.Condition.Value, trigger.Id.RawValue)); }});

                Conditional conditional = new Conditional(addInvalidConditionError, addInvalidParamIdError, addConditionCanBeSimpliefiedWarning);

                conditional.ParseConditional(trigger.Condition.Value);

                if (conditionValidationResults.Count == 0 || !conditionValidationResults.Any(result => (result.Severity == Severity.Major || result.Severity == Severity.Critical)))
                {
                    conditional.CheckConditional(context.ProtocolModel);
                }

                results.AddRange(conditionValidationResults);
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