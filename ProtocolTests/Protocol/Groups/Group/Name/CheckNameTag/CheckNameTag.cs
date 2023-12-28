namespace SLDisValidatorUnitTests.Protocol.Groups.Group.Name.CheckNameTag
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common.Extensions;
    using SLDisValidator2.Interfaces;
    using SLDisValidator2.Tests.Protocol.Groups.Group.Name.CheckNameTag;

    [TestClass]
    public class Validate
    {
        private readonly IValidate test = new CheckNameTag();

        #region Valid Checks

        [TestMethod]
        public void Group_CheckNameTag_Valid()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Valid,
                FileName = "Valid",
                ExpectedResults = new List<IValidationResult>()
            };

            Generic.Validate(test, data);
        }

        #endregion

        #region Invalid Checks

        [TestMethod]
        public void Group_CheckNameTag_DuplicatedValue()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "DuplicatedValue",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.DuplicatedValue(null, null, null, "Name1", "1, 2").WithSubResults(
                        Error.DuplicatedValue(null, null, null, "Name1", "1"),
                        Error.DuplicatedValue(null, null, null, "Name1", "2")),
                }
            };

            Generic.Validate(test, data);
        }

        #endregion
    }

    [TestClass]
    public class Attribute
    {
        private readonly IRoot root = new CheckNameTag();

        [TestMethod]
        public void Group_CheckNameTag_CheckCategory() => Generic.CheckCategory(root, Category.Group);

        [TestMethod]
        public void Group_CheckNameTag_CheckId() => Generic.CheckId(root, CheckId.CheckNameTag);
    }
}