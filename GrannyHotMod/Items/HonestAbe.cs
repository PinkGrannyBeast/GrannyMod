using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace GrannyHotMod.Items
    {
        public class HonestAbe : ModItem
    {
    public override void SetStaticDefaults()
    	{
        	DisplayName.SetDefault("Honest Abe");
        	Tooltip.SetDefault("Sometimes you need to end a Civil War yourself");
    	}
    	
        public override void SetDefaults()
    	   {
           item.damage = 2451; 
           item.ranged = true;
           item.width = 40;
           item.height = 40;
           item.useTime = 50;
           item.useAnimation = 50;
           item.useStyle = 5;
           item.noMelee = true;
           item.knockBack = 4;
           item.value = 10000;
           item.rare = 4;
           item.UseSound = SoundID.Item11;
           item.autoReuse = true;
           item.shoot = mod.ProjectileType("AbeProj");
           item.shootSpeed = 2f;   
           item.useAmmo = AmmoID.Bullet;
           }
           
        public override void AddRecipes()
    	   {
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(null, "BeastSauce", 14);
           recipe.AddIngredient(null, "AbrahamLincoln");
           recipe.AddIngredient(ItemID.Cannon);
           recipe.AddIngredient(ItemID.Cannonball, 10);
           recipe.AddTile(TileID.MythrilAnvil);
           recipe.SetResult(this);
           recipe.AddRecipe();
           }
  
    	
    	public override Vector2? HoldoutOffset()
        {
            return new Vector2(-10, 0);
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
        	Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(6));
        	speedX = perturbedSpeed.X;
        	speedY = perturbedSpeed.Y;
        	Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("AbeProj"), damage, knockBack, player.whoAmI);
        	return false;
        }
  
    }
}
