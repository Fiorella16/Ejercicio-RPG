using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;
using System.Collections.Generic;

namespace RoleplayGame.Library.Test
{

    public class CharactersTest
    {
        [Test]
        //Al crear un personaje y asignarle un item Magic su poder de ataque aumenta de forma acorde.
        public void SumarPoder()
        {
            Elf elfo = new Elf("Elfo");
            Magic magia=new Magic();
            List<IItem> items=new List<IItem>();
            items.Add(magia);
            int Expected = 80;

            Assert.AreEqual(Expected, elfo.AttackPower);
        }
    }




}