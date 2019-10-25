using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;
using System.Collections.Generic;

namespace RoleplayGame.Library.Test
{
    public class ElfTest
    {
        [Test]
        // La creación de un Elf le asigna vida 120 
        public void Elf()
        {
            Elf elfo = new Elf("Elfo");
            int Expected = 120;
            Assert.AreEqual(Expected, elfo.Health);
        }
    

    // la creación de un elf le asigna  un item Robes
    [Test]
    
        public void Elf1()
    {
        List<IItem> items=new List<IItem>();
        Elf elfo = new Elf("Elfo");
        Robes robes = new Robes();
        items.Add(robes);
        Assert.AreEqual(robes.GetType(), elfo.Items[0].GetType());
    }
    }
}


