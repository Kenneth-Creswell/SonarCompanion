﻿namespace SonarCompanion_VSIntegration.MessageBus.Messages
{
    public class SonarIssuesRequested : Message
    {
        public string ProjectKey { get; set; }
    }
}