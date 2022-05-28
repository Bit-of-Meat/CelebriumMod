using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelebriumSouls.NPCs.Enemies
{
    public class Wolf : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wolf");
            Main.npcFrameCount[npc.type] = 16;
        }
        public override void SetDefaults()
        {
            npc.width = 60;
            npc.height = 40;
            npc.lifeMax = 100;
            npc.defense = 7;
            npc.damage = 25;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 5f;
            npc.knockBackResist = 0.65f;
            npc.aiStyle = NPCID.Zombie;
            aiType = NPCID.Zombie;
            animationType = NPCID.Zombie;
            banner = Item.NPCtoBanner(NPCID.Zombie);
            bannerItem = Item.BannerToItem(banner);
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.20f;
        }
    }
}