﻿namespace SLDisDmFeatureCheckUnitTests.Features
{
    using System.Linq;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SLDisDmFeatureCheck.Common;
    using SLDisDmFeatureCheck.Common.Interfaces;
    using SLDisDmFeatureCheck.Common.Results;
    using SLDisDmFeatureCheck.Features;
    
    using Skyline.DataMiner.CICD.Models.Protocol.Read;

    using SLDisUnitTestsShared;

    [TestClass]
    public class HistorySets_FillArray_BulkTests
    {
        private static HistorySets_FillArray_Bulk check;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            check = new HistorySets_FillArray_Bulk();
        }

        [TestMethod]
        public void CheckIsUsed_CSharp()
        {
            const string fileName = "HistorySets_FillArray_BulkTests.xml";
            var input = ProtocolTestsHelper.GetProtocolInputData(fileName);

            FeatureCheckContext context = new FeatureCheckContext(input, false);

            IFeatureCheckResult result = check.CheckIfUsed(context);

            Assert.IsTrue(result.IsUsed);
            Assert.IsTrue(result.FeatureItems.All(x => x is CSharpFeatureCheckResultItem));

            var ids = result.FeatureItems.Select(item => ((IQActionsQAction)item.Node).Id.Value);
            var expectedIds = context.Model.Protocol.QActions.Select(qaction => qaction.Id.Value);
            ids.Should().BeEquivalentTo(expectedIds);
        }
    }
}