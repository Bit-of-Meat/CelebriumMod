using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;

namespace CelebriumSouls.Projectiles
{
    public class SoulHunterProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.arrow = true;
            projectile.Name = "SoulHunterProjectile";
            projectile.width = 22;
            projectile.height = 22;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.ranged = true;

            projectile.timeLeft = 30;
            projectile.timeLeft = 200;
            projectile.tileCollide = true;
            projectile.penetrate = 30;
            projectile.light = 1f;
            projectile.aiStyle = 1;
            aiType = mod.ProjectileType("Crystal Serpent");
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }

        public override bool PreAI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + MathHelper.ToRadians(-45);

            int num309 = Dust.NewDust(new Vector2(projectile.Center.X - projectile.velocity.X * 4f + 2f, projectile.position.Y + 2f - projectile.velocity.Y * 4f), 8, 8, 20, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
            Main.dust[num309].velocity *= -0.25f;
            num309 = Dust.NewDust(new Vector2(projectile.Center.X - projectile.velocity.X * 4f + 2f, projectile.position.Y + 2f - projectile.velocity.Y * 4f), 8, 8, 20, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
            Main.dust[num309].velocity *= -0.25f;
            Main.dust[num309].position -= projectile.velocity * 0.5f;
            return true;
        }

        public override bool PreKill(int timeLeft)
        {
            projectile.type = ProjectileID.Starfury;
            return true;
        }
    }
}