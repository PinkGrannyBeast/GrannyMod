using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class MushroomForkStaff : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Mushrooms from the Fork of a God");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults() {
			item.damage = 43;
			item.magic = true;
			item.mana = 7;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 318;
			item.shootSpeed = 16f;
		}

		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Mushroom, 2);
            recipe.AddIngredient(null, "DirtBar", 10);
            recipe.AddIngredient(null, "MushroomBar", 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        
	}
}