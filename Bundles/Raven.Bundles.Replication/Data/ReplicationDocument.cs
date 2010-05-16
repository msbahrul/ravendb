﻿using System.Collections.Generic;

namespace Raven.Bundles.Replication.Data
{
    public class ReplicationDocument
    {
        public string Id { get; set; }

        public List<ReplicationDestination> Destinations { get; set; }

        public ReplicationDocument()
        {
            Destinations = new List<ReplicationDestination>();
            Id = ReplicationConstants.RavenReplicationDestinations;
        }
    }
}