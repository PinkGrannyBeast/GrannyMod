using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace GrannyHotMod.Items
{
 public class BeastRailgun : ModItem
 {
  public override void SetStaticDefaults()
    	{
        	DisplayName.SetDefault("Beast Railgun");
        	Tooltip.SetDefault("Railgun firing the energy of Beast");
    	}
    	
  public override void SetDefaults()
    	{
   item.damage = 56;
   item.ranged = true;
   item.width = 40;
   item.height = 40;
   item.useTime = 3;
   item.useAnimation = 20;
   item.useStyle = 5;
   item.noMelee = true;
   item.knockBack = 4;
   item.value = 10000;
   item.rare = 8;
   item.UseSound = SoundID.Item11;
   item.autoReuse = true;
   item.shoot = 10;
   item.shootSpeed = 26f;
   item.useAmmo = AmmoID.Bullet;
  }
		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "LesserHealingPotionBar", 10);
            recipe.AddIngredient(null, "DirtBar", 10);
            recipe.AddIngredient(null, "BeastSauce", 11);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    	
    	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
  {
        	Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(6));
        	speedX = perturbedSpeed.X;
        	speedY = perturbedSpeed.Y;
        	Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 126, damage, knockBack, player.whoAmI);
        	return false;
  }
  
    	
    	public override Vector2? HoldoutOffset()
  {
   return new Vector2(-13, 0);
  }
 }
}

