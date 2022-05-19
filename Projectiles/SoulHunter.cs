using Terraria;
using Terraria.ModLoader;

namespace CelebriumMod.Projectiles {
    public class SoulHunter : ModProjectile {
        public override void SetDefaults() {
            Projectile.width = 22;
            Projectile.height = 22;
            Projectile.friendly = true;
            Projectile.timeLeft = 30;
            Projectile.light = 1f;
        }
    }
}
