using NUnit.Framework;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class MagickStickTest
    {

        [Test]
        public void TestMagicStickPower()
        {
            // BRONCE 1. El item MagicStick tiene un poder de ataque equivalente a (ataque de magia + ( ataque de stick * 3 ) )

            MagicStick mStick = new MagicStick();
            Stick stick = new Stick();
            Magic magic = new Magic();
            int expected = magic.AttackPower + (stick.AttackPower * 3);
            Assert.AreEqual(expected, mStick.AttackPower);
        }

        
        [Test]
        public void TestMagicStickDefense()
        {
            // BRONCE 2. El item MagicStick tiene el poder de defensa de la magia que tiene.

            MagicStick mStick = new MagicStick();
            Magic magic = new Magic();
            int expected = magic.DefensePower;
            Assert.AreEqual(expected, mStick.DefensePower);
        }
    }
}