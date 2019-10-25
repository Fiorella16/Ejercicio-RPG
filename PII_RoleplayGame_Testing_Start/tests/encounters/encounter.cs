using NUnit.Framework;
using System.Collections.Generic;
using RoleplayGame.Encounters;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class EncounterTest
    {
        [Test]
        public void TestExEnc()
        {
            bool noItem = false;

            //SILVER 17. Cuando se da un encuentro de tipo ExchangeEncounter entre dos personajes y un elemento, el emisor pierde el elemento y el receptor lo gana.
            Character test1 = new Wizard("test");
            Character test2 = new Wizard("test");
            Character testCopy = test1;
            
            ExchangeEncounter exEn = new ExchangeEncounter(test1, test2);
            
            foreach (IItem item in test1.Items)
            {
                // item NO TERMINADO
            }
            
            bool expected = true;
            Assert.AreEqual(expected, noItem);
        }

        //Test 20, son varios:
        [Test]
        public void TestAlive()
        {
            Character test1 = new Wizard("test");
            Character test2 = new Troll("test");
            AttackEncounter attack = new AttackEncounter(test1, test2); // los hago pelear, permitiendo que test1 inicie el encuentro
            //dado el daño de wizard, troll debería seguir vivo
            bool expected = false;
            Assert.AreEqual(expected, test2.IsDead);
        }

        
        [Test]
        public void TestDead()
        {//no se llega a termianr el test
            Character test1 = new Wizard("test");
            Character test2 = new Troll("test");

            AttackEncounter attack = new AttackEncounter(test1, test2); // los hago pelear, permitiendo que test1 inicie el encuentro
            //dado el daño de wizard, troll debería seguir vivo
            bool expected = false;
            Assert.AreEqual(expected, test2.IsDead);
        }
    }

}