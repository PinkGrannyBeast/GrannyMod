using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class DartBook : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Such epic its lit");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults() {
			item.damage = 13;
			item.magic = true;
			item.mana = 7;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item6;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("DartProj");
			item.shootSpeed = 5f;
		}

		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DartTrap, 2);
            recipe.AddIngredient(ItemID.Silk, 8);
            recipe.AddIngredient(ItemID.Leather, 6);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        
	}
}