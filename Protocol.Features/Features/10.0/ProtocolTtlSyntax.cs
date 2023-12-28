﻿namespace SLDisDmFeatureCheck.Features
{
    using System.Collections.Generic;
    using System.Linq;
    using SLDisDmFeatureCheck.Common;
    using SLDisDmFeatureCheck.Common.Attributes;
    using SLDisDmFeatureCheck.Common.Interfaces;
    using SLDisDmFeatureCheck.Common.Results;
    using Skyline.DataMiner.CICD.Models.Protocol.Enums;
    using Skyline.DataMiner.CICD.Models.Protocol.Read;

    //[MinDataMinerVersions("10.0.0.0-9118", "9.6.3.0-8092")]
    internal class ProtocolTtlSyntax : IFeatureCheck
    {
        public string Title => "Protocol TTL Syntax";

        public string Description => "Allow infinite TTL in partitions attribute (Elastic)";

        public IReadOnlyCollection<uint> ReleaseNotes => new uint[] { 19993 };

        public IFeatureCheckResult CheckIfUsed(FeatureCheckContext context)
        {
            // Not sure if also need to check if IndexingOptions enabled="true" is on the table??

            var items = context?.Model?.Protocol?.Params
                            ?.Where(param => param?.Database?.Partition?.Value == EnumDatabasePartition.Infinite)
                            ?.Select(x => (IReadable)x)
                            ?.ToList();

            return new FeatureCheckResult(items);
        }
    }
}