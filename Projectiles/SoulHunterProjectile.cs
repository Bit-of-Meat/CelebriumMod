using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

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

            int trail = Dust.NewDust(projectile.Center, 8, 8, DustID.PurificationPowder, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
            Main.dust[trail].velocity *= -0.25f;
            Main.dust[trail].position -= projectile.velocity * 0.5f;
            return true;
        }

        public override bool PreKill(int timeLeft)
        {
            projectile.type = ProjectileID.Starfury;
            return true;
        }
    }
}