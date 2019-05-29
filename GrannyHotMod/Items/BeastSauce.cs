using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
    public class BeastSauce : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The secret and holy mixture of Beast.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 13;

        }

       		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PurificationPowder, 8);
            recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddIngredient(ItemID.Lens, 15);
            recipe.AddIngredient(ItemID.Glass, 7);
            recipe.AddIngredient(ItemID.RedBrick, 13);
            recipe.AddIngredient(ItemID.LunarTabletFragment, 4);
            recipe.AddIngredient(ItemID.Acorn, 3);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}