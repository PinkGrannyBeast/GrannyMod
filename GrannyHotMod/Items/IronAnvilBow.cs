using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
    public class IronAnvilBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Iron Anvil Bow");
            Tooltip.SetDefault("It's heavy");
        }

        public override void SetDefaults() 
        {
            item.damage = 18;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 20;
            item.useAnimation = 40;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 4;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 12f;
            item.useAmmo = AmmoID.Arrow;
        }
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(null, "DirtBar", 35);
            recipe.AddIngredient(null, "IronAnvilBar", 18);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}