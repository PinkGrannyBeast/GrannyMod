using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class StaffofEpic : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Such epic its lit");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults() {
			item.damage = 10;
			item.magic = true;
			item.mana = 7;
			item.width = 40;
			item.height = 40;
			item.useTime = 5;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 125;
			item.shootSpeed = 16f;
		}

		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(null, "DirtBar", 10);
            recipe.AddIngredient(null, "LesserHealingPotionBar", 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        
	}
}