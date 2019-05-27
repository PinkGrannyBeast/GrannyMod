using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
    public class LesserHealingPotionBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Dumb bar from healing potions what the g");
        }

        public override void SetDefaults()
        {
            item.width = 50;
            item.height = 50;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 9;

        }

       		public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bottle, 4);
            recipe.AddIngredient(ItemID.LesserHealingPotion, 2);
            recipe.AddIngredient(ItemID.IronOre, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}