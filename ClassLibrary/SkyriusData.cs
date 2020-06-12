using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public class SkyriusData

    {
        public static List<Skyrius> categoryList = new List<Skyrius>() {
            new Skyrius() { Id = 1, Name = "Pediatrija" },
            new Skyrius() { Id = 2, Name = "Odontologoja" },
            new Skyrius() { Id = 3, Name = "Chirurgija" }
        };
        public Skyrius SelectCategory(string skyrius)
        {
            return categoryList.Find(x => x.Name == skyrius);
        }
        public void AddNewCategory(string name)
        {
            categoryList.Add(new Skyrius() { Id = categoryList.Count + 1, Name = name });
        }

    }
}
