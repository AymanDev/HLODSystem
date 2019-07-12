﻿using System;
using Unity.HLODSystem.Utils;
using UnityEngine;

namespace Unity.HLODSystem
{
    public interface IBatcher
    {
        
        void Batch(Vector3 rootPosition, DisposableList<HLODBuildInfo> targets, Action<float> onProgress);

    }
}