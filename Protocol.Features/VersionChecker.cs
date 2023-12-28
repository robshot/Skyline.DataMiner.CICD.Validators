﻿namespace SLDisDmFeatureCheck
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    using Microsoft.CodeAnalysis;

    using Skyline.DataMiner.CICD.Models.Protocol;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;

    using SLDisDmFeatureCheck.Common;
    using SLDisDmFeatureCheck.Common.Attributes;
    using SLDisDmFeatureCheck.Common.Exceptions;
    using SLDisDmFeatureCheck.Common.Interfaces;
    using SLDisDmFeatureCheck.Common.Results;

    public static class VersionChecker
    {
	    private static IEnumerable<(IFeatureCheck feature, MinDataMinerVersionsAttribute minVersion, MaxDataMinerVersionsAttribute maxVersion)> allFeatures;
        
        /// <summary>
        /// Gets the used features.
        /// </summary>
        /// <param name="input">The protocol input data.</param>
        /// <param name="compiledQActions"></param>
        /// <param name="isSolutionBased">Boolean indicating if solution based.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// model
        /// or
        /// data
        /// </exception>
        /// <exception cref="DataMinerVersionCheckException">Internal error, see internal exception for more details.</exception>
        public static IDmaVersionCheckResults GetUsedFeatures(IProtocolInputData input, IReadOnlyDictionary<ProjectId, CompiledQActionProject> compiledQActions, bool isSolutionBased, CancellationToken cancellationToken)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (input.Model.Protocol == null)
            {
                return new DmaVersionCheckResults();
            }

            DmaVersionCheckResults result = new DmaVersionCheckResults();

            List<Feature> usedFeatures = new List<Feature>();

            try
            {
                InitializeFeatures();

                FeatureCheckContext context = new FeatureCheckContext(input, compiledQActions, isSolutionBased);

                foreach ((IFeatureCheck feature, MinDataMinerVersionsAttribute minAttr, MaxDataMinerVersionsAttribute maxAttr) in allFeatures)
                {
                    IFeatureCheckResult checkResult = feature.CheckIfUsed(context);

                    if (checkResult.IsUsed)
                    {
                        usedFeatures.Add(new Feature(feature, checkResult, minAttr, maxAttr));
                    }

                    if (cancellationToken.IsCancellationRequested)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DataMinerVersionCheckException("Internal error, see internal exception for more details.", ex);
            }

            result.Features = usedFeatures;

            return result;
        }

        private static void InitializeFeatures()
        {
            if (allFeatures != null)
            {
                return;
            }

            // TODO: Can be tweaked later, maybe with inheritance?
            var minFeatures = MinDataMinerVersionsAttribute.GetFeatures();
            var maxFeatures = MaxDataMinerVersionsAttribute.GetFeatures().ToList();

            List<(IFeatureCheck, MinDataMinerVersionsAttribute, MaxDataMinerVersionsAttribute)> features = new List<(IFeatureCheck, MinDataMinerVersionsAttribute, MaxDataMinerVersionsAttribute)>();

            foreach ((IFeatureCheck feature, MinDataMinerVersionsAttribute version) in minFeatures)
            {
                // Not ideal, but we'll need to see if we implement a comparer or something that makes it unique.
                var temp = maxFeatures.FirstOrDefault(x => x.feature.Title == feature.Title);

                // temp will not be null, but the inner 'fields' will be default
                features.Add((feature, version, temp.version));
            }

            allFeatures = features;
        }
    }
}