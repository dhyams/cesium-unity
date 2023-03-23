﻿using UnityEngine;

namespace CesiumForUnity
{
    [ExecuteInEditMode]
    public abstract partial class CesiumTileExcluder : MonoBehaviour
    {
        /// <summary>
        /// Determines whether the given tile should be excluded from loading and rendering.
        /// </summary>
        /// <param name="tile">The tile to check. This instance is only valid for the duration of this call.</param>
        /// <returns>True if the tile should be excluded, false if the tile should be loaded and rendered.</returns>
        public abstract bool ShouldExclude(Cesium3DTile tile);
    }
}
