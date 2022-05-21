using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelebriumSouls.Items
{
	public class SoulHunter : ModItem
	{
		public static short glowMask;
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SoulHunter"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic modded sword.");
			if (Main.netMode != NetmodeID.Server)
				glowMask = GlowMaskAPI.Tools.instance.AddGlowMask(mod.GetTexture("Items/SoulHunter_GlowMask"));
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{ //There is a 1/6 chance of dust occurring. Experiment with the chances by changing the 6
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Electric);
			}
		}

		public override void SetDefaults() 
		{
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.shootSpeed = 12f;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.shoot = mod.ProjectileType("SoulHunterProjectile");
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.glowMask = glowMask;
		}
	
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}