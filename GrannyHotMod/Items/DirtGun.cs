using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class DirtGun : ModItem
	{
		public override void SetStaticDefaults() 
        {
            DisplayName.SetDefault("Dirt Gun");
            Tooltip.SetDefault("The weapon of a dirt cowboy");
        }
        
		public override void SetDefaults() 
        {
			item.damage = 10;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 25;
			item.useAnimation = 25;
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
			recipe.AddIngredient(ItemID.Wood, 2);
            recipe.AddIngredient(ItemID.FlintlockPistol);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddIngredient(null, "DirtBar", 20);
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
