using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class LesserHealingPotionSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lesser Healing Potion Sword");
			Tooltip.SetDefault("A sword fit for a true man");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item4;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 8);
            recipe.AddIngredient(ItemID.WoodenSword);
            recipe.AddIngredient(ItemID.LesserHealingPotion, 2);
            recipe.AddIngredient(null, "LesserHealingPotionBar", 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        
	}
}
