using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
    public class PentaShot : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Penta-Shot");
            Tooltip.SetDefault("A gun that shoots into 5 directions");
        }

        public override void SetDefaults() 
        {
            item.damage = 38;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item2;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 7f;
            item.useAmmo = AmmoID.Bullet;
        }
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Shotgun, 1);
			recipe.AddIngredient(ItemID.Cog, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(0);
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(90));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-1, 0);
        }
    }
}