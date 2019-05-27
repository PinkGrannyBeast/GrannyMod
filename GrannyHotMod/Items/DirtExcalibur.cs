using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class DirtExcalibur : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dirt Excalibur");
			Tooltip.SetDefault("Arthurdigit's true sword");
		}
		public override void SetDefaults()
		{
			item.damage = 300;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 60;
			item.useAnimation = 300;
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
			recipe.AddIngredient(ItemID.Wood, 8);
            recipe.AddIngredient(ItemID.WoodenSword);
            recipe.AddIngredient(ItemID.DirtBlock, 50);
            recipe.AddIngredient(null, "DirtBar", 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        
	}
}
