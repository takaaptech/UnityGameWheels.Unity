﻿#if UNITY_EDITOR

namespace COL.UnityGameWheels.Unity.Asset
{
    using Core.Asset;

    internal partial class EditorModeAssetModule
    {
        private class DummyAssetAccessor : IAssetAccessor
        {
            public string AssetPath { get; internal set; }

            public object AssetObject { get; internal set; }

            public AssetAccessorStatus Status { get; internal set; }
        }
    }
}

#endif