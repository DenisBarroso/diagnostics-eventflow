﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Extensions.Diagnostics
{
    using System;
    using System.Collections.Generic;

    public class EventData
    {
        private IDictionary<Type, object> metadata;

        public DateTimeOffset Timestamp { get; set; }

        public string ProviderName { get; set; }

        public int EventId { get; set; }

        public string Message { get; set; }

        public string Level { get; set; }

        public string Keywords { get; set; }

        public string EventName { get; set; }

        public string ActivityID { get; set; }

        public IDictionary<string, object> Payload { get; set; }

        public IDictionary<Type, object> Metadata
        {
            get
            {
                if (this.metadata == null)
                {
                    this.metadata = new Dictionary<Type, object>();
                }

                return this.metadata;
            }
        }
    }
}