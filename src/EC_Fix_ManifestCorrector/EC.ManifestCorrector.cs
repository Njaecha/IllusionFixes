﻿using BepInEx;
using Common;

namespace IllusionFixes
{
    [BepInProcess(Constants.GameProcessName)]
    [BepInPlugin(GUID, PluginName, Constants.PluginsVersion)]
    public partial class ManifestCorrector : BaseUnityPlugin
    {
        public const string GUID = "EC_Fix_ManifestCorrector";
    }
}