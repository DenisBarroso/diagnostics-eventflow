﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Microsoft.Extensions.Diagnostics.Metadata;

namespace Microsoft.Extensions.Diagnostics.Configuration
{
    public class EventSourceConfiguration
    {
        public string ProviderName { get; set; }
        public EventLevel Level { get; set; }
        public EventKeywords Keywords { get; set; }

        public List<EventMetricMetadata> Metrics { get; set; }

        public List<RequestMetadata> Requests { get; set; }

        public EventSourceConfiguration()
        {
            Level = EventLevel.LogAlways;
            Keywords = (EventKeywords) ~0;
        }
    }
}