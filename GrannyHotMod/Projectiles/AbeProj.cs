using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Projectiles
{
	public class AbeProj : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Abraham Lincoln ball"); 
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;    
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;    
		}

		public override void SetDefaults() {
			projectile.width = 18;              
			projectile.height = 18;           
			projectile.aiStyle = 1;   
			projectile.friendly = true;  
			projectile.hostile = false;      
			projectile.ranged = true;        
			projectile.penetrate = 5;    
			projectile.timeLeft = 800;          
			projectile.alpha = 1;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in) Make sure to delete this if you aren't using an aiStyle that fades in. You'll wonder why your projectile is invisible.
			projectile.light = 0.5f;           
			projectile.ignoreWater = true;          
			projectile.tileCollide = true;       
			projectile.extraUpdates = 1;      
			aiType = ProjectileID.Bullet;     
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			projectile.penetrate--;
			if (projectile.penetrate <= 0) {
				projectile.Kill();
			}
			else {
				Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
				Main.PlaySound(SoundID.Item10, projectile.position);
				if (projectile.velocity.X != oldVelocity.X) {
					projectile.velocity.X = -oldVelocity.X;
				}
				if (projectile.velocity.Y != oldVelocity.Y) {
					projectile.velocity.Y = -oldVelocity.Y;
				}
			}
			return false;
		}

		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor) {
			Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
			for (int k = 0; k < projectile.oldPos.Length; k++) {
				Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
				Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
				spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
			}
			return true;
		}

		public override void Kill(int timeLeft)
		{
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
		}
	}
}