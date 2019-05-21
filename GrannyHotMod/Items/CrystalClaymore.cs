using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class CrystalClaymore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("CrystalClaymore");
			Tooltip.SetDefault("Big brother of the Pearlwood Sword.");
		}
		public override void SetDefaults()
		{
			item.damage = 64;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 12;
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
			recipe.AddIngredient(ItemID.CrystalShard, 15);
            recipe.AddIngredient(ItemID.PearlwoodSword);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 30);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
