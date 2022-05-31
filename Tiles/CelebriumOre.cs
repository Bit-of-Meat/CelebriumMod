using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CelebriumSouls.Tiles
{
    public class CelebriumOre : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            drop = ItemType<Items.Placeables.CelebriumOre>();

            ModTranslation name = CreateMapEntryName();
            AddMapEntry(new Color(98, 36, 97), name);

            minPick = 60;
        }
    }
}