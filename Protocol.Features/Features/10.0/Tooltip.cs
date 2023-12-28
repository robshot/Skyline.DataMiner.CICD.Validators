﻿namespace SLDisDmFeatureCheck.Features
{
    using System.Collections.Generic;
    using System.Linq;
    using SLDisDmFeatureCheck.Common;
    using SLDisDmFeatureCheck.Common.Attributes;
    using SLDisDmFeatureCheck.Common.Interfaces;
    using SLDisDmFeatureCheck.Common.Results;
    using Skyline.DataMiner.CICD.Models.Protocol.Read;

    //[MinDataMinerVersions("10.0.0.0-9118", "9.6.11.0-8649")]
    public class Tooltip : IFeatureCheck
    {
        public string Title => "Tooltip";

        public string Description => "Support for formatted tooltips on discreets with IconRefs.";

        public IReadOnlyCollection<uint> ReleaseNotes => new uint[] { 22884, 23003 };

        public IFeatureCheckResult CheckIfUsed(FeatureCheckContext context)
        {
            var items = context?.Model?.Protocol?.Params
                               ?.Where(param => param?.Measurement?.Discreets?.Any(discreet => discreet.Tooltip != null) == true)
                               ?.Select(param => (IReadable)param)
                               ?.ToList();

            return new FeatureCheckResult(items);
        }
    }
}