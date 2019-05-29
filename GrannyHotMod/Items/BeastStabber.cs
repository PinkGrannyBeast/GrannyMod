using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class BeastStabber : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Beast Stabber");
			Tooltip.SetDefault("A shortsword made from Beast Sauce");
		}
		public override void SetDefaults()
		{
			item.damage = 1376;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 3;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item3;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "LesserHealingPotionBar", 23);
            recipe.AddIngredient(ItemID.CopperShortsword);
            recipe.AddIngredient(null, "BeastSauce", 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        
	}
}
