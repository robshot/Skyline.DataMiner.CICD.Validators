﻿namespace SLDisDmFeatureCheck.Features
{
    using System.Collections.Generic;
    using System.Linq;
    using SLDisDmFeatureCheck.Common;
    using SLDisDmFeatureCheck.Common.Attributes;
    using SLDisDmFeatureCheck.Common.Interfaces;
    using SLDisDmFeatureCheck.Common.Results;
    using Skyline.DataMiner.CICD.Models.Protocol.Read;

    //[MinDataMinerVersions("9.6.0.0-8235", "9.5.7.0-6665")]
    public class ParameterSaveInterval : IFeatureCheck
    {
        public string Title => "Parameter save interval";

        public string Description => "Specifies that only one save operation must be executed per interval.";

        public IReadOnlyCollection<uint> ReleaseNotes => new uint[] { 16708 };

        public IFeatureCheckResult CheckIfUsed(FeatureCheckContext context)
        {
            var items = context?.Model?.Protocol?.Params
                                    ?.Where(x => x?.SaveInterval != null)
                                    ?.Select(x => (IReadable)x)
                                    ?.ToList();

            return new FeatureCheckResult(items);
        }
    }
}