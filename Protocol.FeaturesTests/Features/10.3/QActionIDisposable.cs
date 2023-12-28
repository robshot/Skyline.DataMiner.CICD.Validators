﻿namespace SLDisDmFeatureCheckUnitTests.Features
{
    using System.Collections;
    using System.Linq;

    using FluentAssertions;
    using FluentAssertions.Equivalency;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Skyline.DataMiner.CICD.Validators.Common.Data;

    using SLDisDmFeatureCheck.Common;
    using SLDisDmFeatureCheck.Common.Results;
    using SLDisDmFeatureCheck.Features;

    using SLDisUnitTestsShared;

    [TestClass]
    public class QActionDisposableTests
    {
        private static QActionIDisposable check;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            check = new QActionIDisposable();
        }

        [TestMethod]
        public void CheckIsUsed_QActionIDisposable()
        {
            const string code = @"<Protocol><QActions><QAction id=""1"" name=""Test"" encoding=""csharp"" triggers=""10"" dllImport="""">
			<![CDATA[using System;
using Skyline.DataMiner.Scripting;

public class QAction : IDisposable
{
	public static void Run(SLProtocol protocol)	{}

	public void Dispose() {}
}
]]>
		</QAction></QActions></Protocol>";
            
            var qactionCompilationModel = ProtocolTestsHelper.GetQActionCompilationModel(code);
            var input = new ProtocolInputData(code, qactionCompilationModel);

            FeatureCheckContext context = new FeatureCheckContext(input, false);

            var result = check.CheckIfUsed(context);
            var qaction = context.Model.Protocol.QActions.First();
            var expected = new FeatureCheckResultItem(qaction);

            Assert.IsTrue(result.IsUsed);
            
            result.FeatureItems.Should().HaveCount(1);
            result.FeatureItems.First().Should().BeEquivalentTo(expected, option => option.IgnoringCyclicReferences());
        }
    }
}