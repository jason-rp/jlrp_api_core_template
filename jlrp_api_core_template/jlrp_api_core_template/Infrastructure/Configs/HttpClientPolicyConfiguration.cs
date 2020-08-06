using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jlrp_api_core_template.Infrastructure.Configs
{
    public class HttpClientPolicyConfiguration
    {
        public int RetryCount { get; set; }
        public int RetryDelayInMs { get; set; }
        public int RetryTimeoutInSeconds { get; set; }
        public int BreakDurationInSeconds { get; set; }
        public int MaxAttemptBeforeBreak { get; set; }
        public int HandlerTimeoutInMinutes { get; set; }
    }
}
