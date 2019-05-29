using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class BarBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bar Blade");
			Tooltip.SetDefault("Sword from the bar bars");
		}
		public override void SetDefaults()
		{
			item.damage = 61;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "LesserHealingPotionBar", 20);
            recipe.AddIngredient(null, "MushroomBar", 5);
            recipe.AddIngredient(null, "DirtBar", 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        
	}
}
