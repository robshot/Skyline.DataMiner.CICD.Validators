namespace SLDisValidator2.Tests.Protocol.Timers.Timer.CheckOptionsAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using SLDisValidator2.Common;
    using SLDisValidator2.Interfaces;

    internal static class Error
    {
        internal static IValidationResult NonExistingIdInOption(IValidate test, IReadable referenceNode, IReadable positionNode, string timerOption, string referItemType, string referItemId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.NonExistingIdInOption,
                FullId = "7.3.2",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("'{0}' option refers to a non-existing {1} '{2}'.", timerOption, referItemType, referItemId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidValueInOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionName, string optionValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidValueInOption,
                FullId = "7.3.3",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("'{0}' option has an invalid value '{1}'.", optionName, optionValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string timerId, string attributeValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidAttribute,
                FullId = "7.3.5",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value for Timer@options attribute. Timer ID '{0}'. Current Value '{1}'.", timerId, attributeValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingIpOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionName, string timerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.MissingIpOption,
                FullId = "7.3.6",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Option '{0}' requires the 'ip' option in Timer@options. Timer ID '{1}'.", optionName, timerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidIgnoreIfOption(IValidate test, IReadable referenceNode, IReadable positionNode, string ignoreIfValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidIgnoreIfOption,
                FullId = "7.3.7",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value for 'ignoreIf' option. Expected format: 'ignoreIf:<columnIdx>,<value>'. Current value '{0}'.", ignoreIfValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Expected format: \"ignoreIf:<columnIdx>,<value>\", where <columnIdx> specifies the zero-based column index of a column of the table specified in the \"ip\" option, which holds the value to be compared with the value specified in <value>.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidEachOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidEachOption,
                FullId = "7.3.8",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value for 'each' option. Expected format: 'each:<period>'. Current value '{0}'.", optionValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Expected format: 'each:<period>', where <period> specifies the period (in ms) that each row should be executed in the table.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidDynamicThreadPoolOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidDynamicThreadPoolOption,
                FullId = "7.3.9",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value for 'dynamicThreadPool' option. Expected format: 'dynamicThreadPool:<threadPoolSizeMonitorPid>'. Current value '{0}'.", optionValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Expected format: 'dynamicThreadPool:<threadPoolSizeMonitorPid>', where <threadPoolSizeMonitorPid> specifies the ID of the parameter that will be used to show the current size of the thread pool.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidInstanceOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidInstanceOption,
                FullId = "7.3.10",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value for 'instance' option. Expected format: 'instance:<tablePid>,<columnIdx>'. Current value '{0}'.", optionValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Expected format: 'instance:<tablePid>,<columnIdx>', where  <tablePid> specifies the table parameter ID and <columnIdx> specifies the zero-based column index of the column that holds the instance value.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidIpOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidIpOption,
                FullId = "7.3.11",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value for 'ip' option. Expected format: 'ip:<tablePid>,<columnIdx>'. Current value '{0}'.", optionValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Expected format: 'ip:<tablePid>,<columnIdx>', where <tablePid> specifies the table parameter ID and <columnIdx> specifies the zero-based column index of the column that holds the IP address or the primary key (in case a QAction for each row of the table is executed directly from the timer).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidPollingRateOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidPollingRateOption,
                FullId = "7.3.12",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value for 'pollingRate' option. Expected format: 'pollingRate:<interval>,<maxCount>,<releaseCount>'. Current value '{0}'.", optionValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Expected format: 'pollingRate:<interval>,<maxCount>,<releaseCount>', where  <interval> specifies the interval (in ms).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidQActionOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidQActionOption,
                FullId = "7.3.13",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value for 'qaction' option. Expected format: 'qaction:<qactionId>'. Current value '{0}'.", optionValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Expected format: 'qaction:<qactionId>', where <qactionId> specifies the ID of the QAction.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidQActionBeforeOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidQActionBeforeOption,
                FullId = "7.3.14",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value for 'qactionBefore' option. Expected format: 'qactionBefore:<qactionId>'. Current value '{0}'.", optionValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Expected format: 'qactionBefore:<qactionId>', where <qactionId> specifies the ID of the QAction.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidQActionAfterOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidQActionAfterOption,
                FullId = "7.3.15",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value for 'qactionAfter' option. Expected format: 'qactionAfter:<qactionId>'. Current value '{0}'.", optionValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Expected format: 'qactionAfter:<qactionId>', where <qactionId> specifies the ID of the QAction.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidThreadPoolOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidThreadPoolOption,
                FullId = "7.3.16",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value for 'threadPool' option. Expected format: 'threadPool:<size>,<calculationInterval>,<usagePid>,<waitingPid>,<maxDurationPid>,<avgDurationPid>,<counterPid>,<queueSize>'. Current value '{0}'.", optionValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Expected format: 'threadPool:<size>,<calculationInterval>,<usagePid>,<waitingPid>,<maxDurationPid>,<avgDurationPid>,<counterPid>,<stackSize>', where: " + Environment.NewLine + " - <size> specifies the  maximum number of threads available in the thread pool." + Environment.NewLine + " - <calculationInterval> specifies the thread statistics refresh interval (in s)." + Environment.NewLine + " - <usagePid> specifies the ID of the parameter that will display the number of threads that are in use (refreshes each <calculationInterval> s)." + Environment.NewLine + " - <waitingPid> specifies the ID of the parameter that will display the number of threads that are waiting because all the thread pool threads are in use (refreshes each <calculationInterval> s)." + Environment.NewLine + " - <maxDurationPid>: specifies the ID of the parameter that will display how long it took to execute the slowest thread during the last calculation interval (expressed in ms)." + Environment.NewLine + " - <avgDurationPid>: specifies the ID of the parameter that will display how long it took on average to execute a thread during the last calculation interval (expressed in ms)." + Environment.NewLine + " - <counterPid>: specifies the ID of the parameter that will display the number of threads that were finished during the last calculation interval." + Environment.NewLine + " - <queueSize>: specifies the number of items that can be put in waiting  state. When the waiting thread pool has reached the stack size, a notice alarm is generated." + Environment.NewLine + "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingEachOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionName, string timerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.MissingEachOption,
                FullId = "7.3.17",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Option '{0}' requires the 'each' option in Timer@options. Timer ID '{1}'.", optionName, timerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "This option requires the \"each\" option to be defined because the \"each\" option specifies the period (in ms) that each row should be executed in the table.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingThreadPoolOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionName, string timerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.MissingThreadPoolOption,
                FullId = "7.3.18",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Option '{0}' requires the 'threadPool' option in Timer@options. Timer ID '{1}'.", optionName, timerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingIdInDynamicThreadPoolOption(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.NonExistingIdInDynamicThreadPoolOption,
                FullId = "7.3.19",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Option '{0}' references a non-existing '{1}' with {2} '{3}'.", "dynamicThreadPool", "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingValueInOption(IValidate test, IReadable referenceNode, IReadable positionNode, string placeholderName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.MissingValueInOption,
                FullId = "7.3.20",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Required value '{0}' is not defined.", placeholderName),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidPingOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidPingOption,
                FullId = "7.3.21",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value for 'ping' option. Current value: '{0}'.", optionValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The following configuration options are available in the 'ping' option (multiple options are separated with a comma (',') and the option value is defined using the following format <optionName>=<optionValue>):" + Environment.NewLine + " - rttColumn: Specifies the 1-based column where the RTT value (in ms) should be stored. The table this column belongs to is specified in the 'ip' option." + Environment.NewLine + " - timeoutPid: (Obsolete) Specifies the ID of the parameter that will store the key of the row that resulted in timeout." + Environment.NewLine + " - ttl: The time to live of the packet (maximum number of hops). Default: 10." + Environment.NewLine + " - timeout: Max time (in ms) before the ping is flagged as timeout when no response is returned. Default: 500." + Environment.NewLine + " - timestampColumn: Specifies the 1-based column where the timestamp should be stored when the ping has been executed. The table this column belongs to is specified in the 'ip' option." + Environment.NewLine + " - type: Specifies the type of ping that is used: ICMP or Winsock. Default: ICMP." + Environment.NewLine + " - size: Specifies the payload size of the packet that is used to execute the ping. Default: 0." + Environment.NewLine + " - continueSnmpOnTimeout: Specifies whether the group should be executed when the ping is in timeout." + Environment.NewLine + " - jitterColumn: Specifies the 1-based column index of the column that will contain the jitter (in ms).  The table this column belongs to is specified in the 'ip' option." + Environment.NewLine + " - latencyColumn: Specifies the 1-based column index of the column that will contain the latency (in ms).  The table this column belongs to is specified in the 'ip' option." + Environment.NewLine + " - packetLossRateColumn: Specifies the 1-based column index of the column that will contain the packet loss rate (decimal value ranging from 0.01 to 1).  The table this column belongs to is specified in the 'ip' option." + Environment.NewLine + " - amountPacketMeasurements: Specifies the number of packets that will be sent for calculating the jitter, latency and packet loss rate." + Environment.NewLine + " - amountPacketMeasurementsPid: Specifies the ID of the parameter that holds the number of packets that will be sent for calculating the jitter, latency and packet loss rate." + Environment.NewLine + " - amountPackets: Specifies the number of packets to be sent to the device." + Environment.NewLine + " - amountPacketsPid: Specifies the ID of the parameter that holds the number of packets to be sent to the device." + Environment.NewLine + " - excludeWorstResults: Specifies the percentage of worst result to exclude. " + Environment.NewLine + " excludeWorstResultsPid:  Specifies the ID of the parameter that holds the percentage of worst result to exclude.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UnknownOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.UnknownOption,
                FullId = "7.3.22",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unknown option '{0}' detected.", optionName),
                HowToFix = "",
                ExampleCode = "",
                Details = "The timer options are formatted as follows: <optionName>:<optionValue> where <optionName> should be one of the following:" + Environment.NewLine + "- each" + Environment.NewLine + "- dynamicThreadPool" + Environment.NewLine + "- ignoreIf" + Environment.NewLine + "- instance" + Environment.NewLine + "- ip" + Environment.NewLine + "- ping" + Environment.NewLine + "- pollingRate" + Environment.NewLine + "- qaction" + Environment.NewLine + "- qactionBefore" + Environment.NewLine + "- qactionAfter" + Environment.NewLine + "- threadPool" + Environment.NewLine + "Options should be separated using semicolons (';').",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult DuplicateOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.DuplicateOption,
                FullId = "7.3.23",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicate option '{0}' detected.", optionName),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UnknownOptionInPingOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.UnknownOptionInPingOption,
                FullId = "7.3.24",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format(" Unknown option '{0}' detected in 'ping' option.", optionName),
                HowToFix = "",
                ExampleCode = "",
                Details = "The timer options are formatted as follows: <optionName>=<optionValue> where <optionName> should be one of the following:" + Environment.NewLine + " - rttColumn" + Environment.NewLine + " - timeoutPid" + Environment.NewLine + " - ttl" + Environment.NewLine + " - timeout" + Environment.NewLine + " - timestampColumn" + Environment.NewLine + " - type" + Environment.NewLine + " - size" + Environment.NewLine + " - continueSnmpOnTimeout" + Environment.NewLine + " - jitterColumn" + Environment.NewLine + " - latencyColumn" + Environment.NewLine + " - packetLossRateColumn" + Environment.NewLine + " - amountPacketsMeasurements" + Environment.NewLine + " - amountPacketsMeasurementsPid" + Environment.NewLine + " - amountPackets" + Environment.NewLine + " - amountPacketsPid" + Environment.NewLine + " - excludeWorstResults" + Environment.NewLine + " - excludeWorstResultsPid" + Environment.NewLine + "Options should be separated by a comma (',').",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult DuplicateOptionInPingOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.DuplicateOptionInPingOption,
                FullId = "7.3.25",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicate option '{0}' detected in 'ping' option.", optionName),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ThreadPoolCalculationIntervalDefined(IValidate test, IReadable referenceNode, IReadable positionNode, string timerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ThreadPoolCalculationIntervalDefined,
                FullId = "7.3.26",
                Category = Category.Timer,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Thread pool statistics can have a big impact on performance. Timer ID '{0}'.", timerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "In case the thread pool statistics are of no interest, disable the calculation of these by setting the <calculationInterval> to -1." + Environment.NewLine + "Also, set the value of the options that specify the ID of the parameter that will show the statistic to -1." + Environment.NewLine + "For example: threadPool:10,-1,-1,-1,-1,-1,-1,500.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UseOfObsoleteTimeoutPidOptionInPingOption(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.UseOfObsoleteTimeoutPidOptionInPingOption,
                FullId = "7.3.27",
                Category = Category.Timer,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "The use of the timeoutPid option in the ping option is obsolete.",
                HowToFix = "",
                ExampleCode = "",
                Details = "The use of the timeoutPid option in the ping option is obsolete. Instead, provide an additional column in the table that will indicate whether there was a timeout for each row.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UseOfObsoleteQActionOption(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.UseOfObsoleteQActionOption,
                FullId = "7.3.28",
                Category = Category.Timer,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "The use of the qaction option is obsolete.",
                HowToFix = "",
                ExampleCode = "",
                Details = "The use of the qaction option is obsolete as it does not execute multi-threaded but sequentially. Instead, use the qactionBefore option.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingColumnIdxInOption(IValidate test, IReadable referenceNode, IReadable positionNode, string timerOption, string columnIdx, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.NonExistingColumnIdxInOption,
                FullId = "7.3.29",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("'{0}' option refers to a non-existing column {1} '{2}' in table '{3}'.", timerOption, "idx", columnIdx, tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingColumnPositionInOption(IValidate test, IReadable referenceNode, IReadable positionNode, string timerOption, string columnPosition, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.NonExistingColumnPositionInOption,
                FullId = "7.3.30",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("'{0}' option refers to a non-existing column {1} '{2}' in table '{3}'.", timerOption, "1-based position", columnPosition, tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint NonExistingIdInOption = 2;
        public const uint InvalidValueInOption = 3;
        public const uint InvalidAttribute = 5;
        public const uint MissingIpOption = 6;
        public const uint InvalidIgnoreIfOption = 7;
        public const uint InvalidEachOption = 8;
        public const uint InvalidDynamicThreadPoolOption = 9;
        public const uint InvalidInstanceOption = 10;
        public const uint InvalidIpOption = 11;
        public const uint InvalidPollingRateOption = 12;
        public const uint InvalidQActionOption = 13;
        public const uint InvalidQActionBeforeOption = 14;
        public const uint InvalidQActionAfterOption = 15;
        public const uint InvalidThreadPoolOption = 16;
        public const uint MissingEachOption = 17;
        public const uint MissingThreadPoolOption = 18;
        public const uint NonExistingIdInDynamicThreadPoolOption = 19;
        public const uint MissingValueInOption = 20;
        public const uint InvalidPingOption = 21;
        public const uint UnknownOption = 22;
        public const uint DuplicateOption = 23;
        public const uint UnknownOptionInPingOption = 24;
        public const uint DuplicateOptionInPingOption = 25;
        public const uint ThreadPoolCalculationIntervalDefined = 26;
        public const uint UseOfObsoleteTimeoutPidOptionInPingOption = 27;
        public const uint UseOfObsoleteQActionOption = 28;
        public const uint NonExistingColumnIdxInOption = 29;
        public const uint NonExistingColumnPositionInOption = 30;
    }

    public static class CheckId
    {
        public const uint CheckOptionsAttribute = 3;
    }
}