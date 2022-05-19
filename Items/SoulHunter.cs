using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace CelebriumMod.Items {
	public class SoulHunter : ModItem {
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("A sword that can steal celebrium souls. \nSummons swords made from souls and mana.");
		}

		public override void SetDefaults() {
			Item.rare = ItemRarityID.Expert;
			Item.damage = 12;
			Item.DamageType = DamageClass.Magic;
			Item.width = 46;
			Item.height = 46;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shootSpeed = 12f;
			Item.mana = 5;
			Item.shoot = ModContent.ProjectileType<Projectiles.SoulHunter>();
			Item.flame = true;
		}

		public override void HoldItem(Player player) {
			Lighting.AddLight(Item.Center, 1f, 1f, 1f);
		}
	}
}