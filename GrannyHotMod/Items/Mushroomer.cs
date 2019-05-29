using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class Mushroomer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mushroomer");
			Tooltip.SetDefault("Massive mushroom bulb on a mushroom stick");
		}
		public override void SetDefaults()
		{
			item.damage = 40;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item3;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 4);
            recipe.AddIngredient(ItemID.WoodenHammer);
            recipe.AddIngredient(ItemID.Mushroom, 10);
            recipe.AddIngredient(null, "MushroomBar", 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        
	}
}
