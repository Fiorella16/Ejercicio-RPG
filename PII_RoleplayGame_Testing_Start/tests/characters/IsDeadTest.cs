using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;
namespace RoleplayGame.Characters.Test
{
    public class IsDeadTest
    {
        [Test]
        public void CharacterIsDead()
        {
            Wizard mago = new Wizard("Gandalf");
            bool prueba = true;
            mago.ReceiveAttack(mago.Health+mago.DefensePower);
            Assert.AreEqual(prueba,mago.IsDead);
        }
    }
}