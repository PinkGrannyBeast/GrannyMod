using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class Artillery : ModItem
	{
		public override void SetStaticDefaults() 
        {
            DisplayName.SetDefault("Artillery");
            Tooltip.SetDefault("Millitary grade missile battery");
        }
        
		public override void SetDefaults() 
        {
			item.damage = 1190;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 84;
			item.useAnimation = 84;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 8;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 133;
			item.shootSpeed = 15f;
			item.useAmmo = AmmoID.Rocket;
		}

		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RocketLauncher);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 8);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        

    	public override Vector2? HoldoutOffset()
  {
   return new Vector2(-13, 0);
  }

	}
}
