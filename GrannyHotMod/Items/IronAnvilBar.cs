using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
    public class IronAnvilBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Genius bar created by Einstein's Grandmother");
        }

        public override void SetDefaults()
        {
            item.width = 50;
            item.height = 50;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 8;

        }

       		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronAnvil, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}