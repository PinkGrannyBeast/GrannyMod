using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
    public class GuidesFinalBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Guide's Final Bow");
            Tooltip.SetDefault("The last gift the Guide has to offer you in Terraria");
        }

        public override void SetDefaults() 
        {
            item.damage = 78;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 14;
            item.useAnimation = 14;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 12;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 16f;
            item.useAmmo = AmmoID.Arrow;
        }
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GuideBow", 1);
            recipe.AddIngredient(null, "BeastSauce", 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 7 + Main.rand.Next(2);
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(35));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-36, 0);
        }
    }
}