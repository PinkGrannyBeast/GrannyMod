using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class DirtSniper : ModItem
	{
		public override void SetStaticDefaults() 
        {
            DisplayName.SetDefault("Dirt Sniper");
            Tooltip.SetDefault("The weapon of a dirt cowboy yeehaw version 2");
        }
        
		public override void SetDefaults() 
        {
			item.damage = 120;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 50;
			item.useAnimation = 55;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item10;
			item.autoReuse = true;
			item.shoot = 2;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddIngredient(ItemID.IllegalGunParts);
            recipe.AddIngredient(ItemID.DirtBlock, 5);
            recipe.AddIngredient(null, "DirtBar", 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}
                public override Vector2? HoldoutOffset()
		{
			return new Vector2(-20, 0);
		}

	}
}