using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class BeastWand : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("The might of Beast in Magic");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults() {
			item.damage = 73;
			item.magic = true;
			item.mana = 4;
			item.width = 70;
			item.height = 70;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 521;
			item.shootSpeed = 16f;
		}

		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(null, "BeastSauce", 16);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        
	}
}
