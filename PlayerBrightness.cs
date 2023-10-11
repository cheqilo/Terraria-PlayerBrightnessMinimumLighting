using Microsoft.Xna.Framework; // Import the necessary namespace for Vector3
using Terraria.ModLoader;
using Terraria;

namespace PlayerBrightness
{
	public class PlayerBrightness : ModPlayer
	{
        private static Vector3 staticVector = new Vector3(0.7f, 0.7f, 0.7f);
        public override void PreUpdateMovement()
        {
            Lighting.AddLight(Player.position, staticVector);
        }
    }
}