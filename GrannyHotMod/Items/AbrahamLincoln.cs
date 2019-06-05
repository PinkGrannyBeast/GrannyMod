using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
    public class AbrahamLincoln : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Slavery is baaaaaad");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 10;

        }

       		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TopHat);
            recipe.AddIngredient(ItemID.GuideVoodooDoll);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}