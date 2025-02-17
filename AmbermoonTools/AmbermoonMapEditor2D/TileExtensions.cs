﻿using Ambermoon.Data;

namespace AmbermoonMapEditor2D
{
    static class TileExtensions
    {
        public static void Fill(this Tileset.Tile target, Tileset.Tile source)
        {
            target.Flags = source.Flags;
            target.GraphicIndex = source.GraphicIndex;
            target.NumAnimationFrames = source.NumAnimationFrames;
            target.ColorIndex = source.ColorIndex;
            target.CombatBackgroundIndex = source.CombatBackgroundIndex;
            target.SitDirection = source.SitDirection;
            target.Sleep = source.Sleep;
            target.AllowedTravelTypes = source.AllowedTravelTypes;
        }
    }
}
