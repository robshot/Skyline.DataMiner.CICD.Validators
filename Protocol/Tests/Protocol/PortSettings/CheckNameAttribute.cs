namespace SLDisValidator2.Tests.Protocol.PortSettings.CheckNameAttribute
{
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Common.Attributes;
    using SLDisValidator2.Generic;
    using SLDisValidator2.Interfaces;

    [Test(CheckId.CheckNameAttribute, Category.PortSettings)]
    internal class CheckNameAttribute : IValidate, ICodeFix/*, ICompare*/
    {
        public List<IValidationResult> Validate(ValidatorContext context)
        {
            List<IValidationResult> results = new List<IValidationResult>();

            if (context.ProtocolModel?.Protocol?.Type?.Value == null)
            {
                // Can't check if there isn't a Type (Currently Connections tag isn't supported)
                return results;
            }

            bool isRequired = context.ProtocolModel.Protocol.Type.Value != Skyline.DataMiner.CICD.Models.Protocol.Enums.EnumProtocolType.Virtual;

            var portSettings = context?.ProtocolModel?.Protocol?.PortSettings;
            var name = portSettings?.Name;
            (GenericStatus status, string rawValue, string value) = GenericTests.CheckBasics(name, isRequired);

            if (status.HasFlag(GenericStatus.Missing))
            {
                results.Add(Error.MissingAttribute(this, portSettings, portSettings, "0"));
                return results;
            }

            if (status.HasFlag(GenericStatus.Empty))
            {
                results.Add(Error.EmptyAttribute(this, portSettings, name, "0"));
                return results;
            }

            if (status.HasFlag(GenericStatus.Untrimmed))
            {
                results.Add(Error.UntrimmedAttribute(this, portSettings, name, "0", rawValue));
                return results;
            }

            return results;
        }

        public ICodeFixResult Fix(CodeFixContext context)
        {
            CodeFixResult result = new CodeFixResult();

            var editNode = context.Protocol.PortSettings;

            switch (context.Result.ErrorId)
            {
                case ErrorIds.EmptyAttribute:
                case ErrorIds.MissingAttribute:
                    string newConnection = ConnectionHelper.CreateConnectionName(context.Protocol.Read, (IPortSettingsBase)editNode.Read);
                    editNode.Name = newConnection;
                    result.Success = true;
                    break;

                case ErrorIds.UntrimmedAttribute:
                    editNode.Name.Value = editNode.Name.Value.Trim();
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