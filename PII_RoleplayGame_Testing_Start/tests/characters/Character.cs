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
            int original=elfo.AttackPower;
            elfo.AddItem(magia);
            int Expected = magia.AttackPower+ original;

            Assert.AreEqual(Expected, elfo.AttackPower);
        }
    }




}