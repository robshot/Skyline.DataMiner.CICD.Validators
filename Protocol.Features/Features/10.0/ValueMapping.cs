﻿namespace SLDisDmFeatureCheck.Features
{
    using System.Collections.Generic;
    using System.Linq;
    using SLDisDmFeatureCheck.Common;
    using SLDisDmFeatureCheck.Common.Attributes;
    using SLDisDmFeatureCheck.Common.Interfaces;
    using SLDisDmFeatureCheck.Common.Results;
    using Skyline.DataMiner.CICD.Models.Protocol.Read;

    //[MinDataMinerVersions("10.0.0.0-9118", "10.0.2.0-8924")]
    internal class ValueMapping : IFeatureCheck
    {
        public string Title => "ValueMapping";

        public string Description => "There is now a new protocol XML tag available, \"ValueMapping\", with two attributes, \"remoteValue\" and \"value\".";

        public IReadOnlyCollection<uint> ReleaseNotes => new uint[] { 24127 };

        public IFeatureCheckResult CheckIfUsed(FeatureCheckContext context)
        {
            var items = context?.Model?.Protocol?.Params
                               ?.Where(param => param?.Mediation?.Any(linkto => linkto?.Any(valueMapping => valueMapping != null) == true) == true)
                               ?.Select(param => (IReadable)param)
                               ?.ToList();

            return new FeatureCheckResult(items);
        }
    }
}