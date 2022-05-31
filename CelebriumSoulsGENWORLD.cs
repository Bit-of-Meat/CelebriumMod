using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;

namespace CelebriumSouls
{
    public class CelebriumSoulsGENWORLD : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(x => x.Name.Equals("Shinies"));
            if (shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new PassLegacy("CelebriumSouls Ore Generation", OreGeneration));
            }
        }

        private void OreGeneration(GenerationProgress progress)
        {
            progress.Message = "CelebriumSouls Создаёт руды!";

            for (int i = 0; i < (int)((Main.maxTilesX * Main.maxTilesY) * 7E-04); i++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

                Tile tile = Framing.GetTileSafely(x, y);
                if (tile.active() && (tile.type == TileID.Granite || tile.type == TileID.Marble || tile.type == TileID.Ash))
                {
                    WorldGen.TileRunner(x, y, WorldGen.genRand.Next(2, 7), WorldGen.genRand.Next(1, 5), TileType<Tiles.CelebriumOre>());
                }
            }
        }
    }
}