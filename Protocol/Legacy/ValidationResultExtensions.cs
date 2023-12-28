﻿namespace Skyline.DataMiner.ProtocolValidator
{
    using System;

    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;

    internal static class ValidationResultExtensions
    {
        public static IValidationResult WithDveExport(this IValidationResult result, int tablePid, string name)
        {
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }

            if (result is ValidationResult classResult)
            {
                classResult.DveExport = (tablePid, name);

                if (classResult.SubResults != null)
                {
                    foreach (var sr in classResult.SubResults)
                    {
                        // Apply recursively to sub results.
                        sr.WithDveExport(tablePid, name);
                    } 
                }
            }

            return result;
        }
    }
}
