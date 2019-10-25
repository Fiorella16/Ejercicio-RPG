using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;
using System.Collections.Generic;
namespace RoleplayGame.Characters.Test
{
    public class WizardTest
    {
      
        [Test]
        public void TestVidaMago()
        {
            Wizard mago = new Wizard("Gandalf");
            int vidaEsperada=80;
            Assert.AreEqual(vidaEsperada,mago.Health);

        }
        [Test]
        public void TestMagiaMago()
        {
            Wizard mago = new Wizard("Dumbuldore");
            Magic magia = new Magic();
            Assert.AreEqual(magia.GetType(),mago.Items[0].GetType());
        }
    }
}