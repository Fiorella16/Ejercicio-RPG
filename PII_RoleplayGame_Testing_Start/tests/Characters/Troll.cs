using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;
using System.Collections.Generic;

namespace RoleplayGame.Library.Test
{

public class TrollTest
    {
        [Test]
        // /La creación de un Troll le asigna vida 150
        public void Troll(string name)
        {
            Troll troll = new Troll("trol");
            int Expected = 150;
            Assert.AreEqual(Expected, troll.Health);
        }
    

    // la creación de un Troll le asigna  un item Armor y Stick.
    [Test]
        public void Troll1(string name)
    {
        List<IItem> items=new List<IItem>();
        Troll troll = new Troll("trol");
        Armor armor= new Armor();
        Stick stick=new Stick();
        items.Add(armor);
        items.Add(stick);
        Assert.AreEqual(armor.GetType(), troll.Items[0].GetType());
        Assert.AreEqual(stick.GetType(), troll.Items[1].GetType());

    }
    }
}
