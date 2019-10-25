using NUnit.Framework;
using RoleplayGame.Characters;
using System.Collections.Generic;

namespace RoleplayGame.Library.Test
{
    public class CharacterTest
    {
        [Test]
        public void TestCharHpLtZero()
        {
            //SILVER 15. Cuando un personaje recibe un ataque, su vida nunca puede ser menor que 0.
            bool belowZero = false;

            List<Character> allChars = new List<Character>()
            {
                new Elf("test"),
                new Troll("test"),
                new Wizard("test")
            };

            foreach (Character _char in allChars)
            {
                _char.ReceiveAttack(_char.Health+1); //le hago recibir daño igual a su vida + 1
                if (_char.Health < 0)
                {
                    belowZero = true; //chequeo si la vida es menor a 0 para el char, si lo es, setteo belowZero a true
                }
            }

            bool expected = false;

            Assert.AreEqual(expected, belowZero);
        
        }

        [Test]
        public void TestDefGtAtk()
        {
            //SILVER 16. Cuando un personaje recibe un ataque y su defensa es mayor al ataque, su vida no se modifica.
            bool Modified = false;

            List<Character> allChars = new List<Character>()
            {
                new Elf("test"),
                new Troll("test"),
                new Wizard("test")
            };

            foreach (Character _char in allChars)
            {
                int originalHP = _char.Health;
                _char.ReceiveAttack(_char.DefensePower-1); //le hago recibir daño igual a su defensa - 1
                if (_char.Health != originalHP)
                {
                    Modified = true; //chequeo si la vida se modificó, si fue así, seteo Modified a true
                }
            }

            bool expected = false;

            Assert.AreEqual(expected, Modified);
        
        
        }   
    }
}