﻿// Copyright (c) Microsoft Corporation and Contributors
// Licensed under the MIT license.

using GitHubExtension.Helpers;
using Microsoft.Windows.DevHome.SDK;

namespace GitHubExtension.Providers;

public class SettingsProvider : ISettingsProvider
{
    string ISettingsProvider.DisplayName => Resources.GetResource(@"SettingsProviderDisplayName");

    public AdaptiveCardSessionResult GetSettingsAdaptiveCardSession()
    {
        Log.Logger()?.ReportInfo($"GetSettingsAdaptiveCardSession");
        return new AdaptiveCardSessionResult(new SettingsUIController());
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
