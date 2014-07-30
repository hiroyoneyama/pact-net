﻿using System;
using System.Net.Http;

namespace PactNet
{
    public interface IPactProvider
    {
        string ConsumerName { get; }
        string ProviderName { get; }
        string PactFileUri { get; }
        HttpClient HttpClient { get; }
        IProviderStates ProviderStatesFor(string consumerName, Action setUp = null, Action tearDown = null);
        IPactProvider ServiceProvider(string providerName, HttpClient httpClient);
        IPactProvider HonoursPactWith(string consumerName);
        IPactProvider PactUri(string uri);
        void Verify(string providerDescription = null, string providerState = null);
    }
}