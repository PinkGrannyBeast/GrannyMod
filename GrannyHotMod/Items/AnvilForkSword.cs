using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class AnvilForkSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Anvil Fork Sword");
			Tooltip.SetDefault("I asked the blacksmith for a sword but he got distracted and made a sharp fork");
		}
		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 8);
            recipe.AddIngredient(null, "IronAnvilBar", 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        
	}
}
